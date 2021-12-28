using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using NUnit.Framework;
using Unity.Cloud.Collaborate.Models;
using Unity.Cloud.Collaborate.Models.Structures;

namespace Unity.Cloud.Collaborate.Tests.Models
{
    public class ChangesModelTests
    {
        class TestableChangesModel : ChangesModel
        {
            public TestSourceControlProvider Provider => (TestSourceControlProvider)m_Provider;

            public TestableChangesModel() : base (new TestSourceControlProvider())
            {

            }

            public void SetToggled([CanBeNull] Dictionary<string, bool> toggled = null)
            {
                if (toggled != null)
                {
                    toggledEntries = toggled;
                }
            }

            internal override void UpdateChangeList(IReadOnlyList<IChangeEntry> list)
            {
                base.UpdateChangeList(list);
                ValidateData();
            }

            public override bool UpdateEntryToggle(string path, bool value)
            {
                var refresh = base.UpdateEntryToggle(path, value);
                ValidateData();
                return refresh;
            }

            void ValidateData()
            {
                var toggledCount = 0;
                foreach (var x in entryData.Select(entry => entry.Value))
                {
                    Assert.IsTrue(toggledEntries.TryGetValue(x.Entry.Path, out var toggled) && x.Toggled == toggled);
                    if (!x.All && toggled) toggledCount++;
                }
                Assert.AreEqual(toggledCount, ToggledCount);
            }
        }

        [Test]
        public void ChangesModel_NullSourceControlEntries_EmptyResultLists()
        {
            var model = new TestableChangesModel();
            model.OnStart();
            model.UpdateChangeList(new List<IChangeEntry>());

            var fullList = model.GetAllEntries();
            Assert.AreEqual(1, fullList.Count);
            Assert.IsTrue(fullList[0].All);

            Assert.AreEqual(0, model.GetToggledEntries().Count);
            Assert.AreEqual(0, model.GetUntoggledEntries().Count);

            Assert.AreEqual(0, model.ToggledCount);
        }

        [Test]
        public void ChangesModel_EmptySourceControlEntries_EmptyResultLists()
        {
            var model = new TestableChangesModel();
            model.OnStart();
            model.UpdateChangeList(new List<IChangeEntry>());

            var fullList = model.GetAllEntries();
            Assert.AreEqual(1, fullList.Count);
            Assert.IsTrue(fullList[0].All);

            Assert.AreEqual(0, model.GetToggledEntries().Count);
            Assert.AreEqual(0, model.GetUntoggledEntries().Count);

            Assert.AreEqual(0, model.ToggledCount);
        }

        [Test]
        public void ChangesModel_SingleSourceControlEntries_SingleUntoggledResult()
        {
            var model = new TestableChangesModel();
            model.OnStart();
            var changes = BuildChangesList(1);
            model.UpdateChangeList(changes);

            var fullList = model.GetAllEntries();
            Assert.AreEqual(2, fullList.Count);
            Assert.IsTrue(fullList[0].All);
            Assert.IsFalse(fullList[0].Toggled);
            Assert.IsFalse(fullList[1].All);
            Assert.IsFalse(fullList[1].Toggled);

            var toggledList = model.GetToggledEntries();
            Assert.AreEqual(0, toggledList.Count);

            var untoggledList = model.GetUntoggledEntries();
            Assert.AreEqual(1, untoggledList.Count);
            Assert.IsFalse(untoggledList[0].All);
            Assert.IsFalse(untoggledList[0].Toggled);

            Assert.AreEqual(0, model.ToggledCount);
        }

        [Test]
        public void ChangesModel_MultipleSourceControlEntries_ToggleSingle()
        {
            const int entryCount = 5;

            var model = new TestableChangesModel();
            model.OnStart();
            var changes = BuildChangesList(entryCount);
            model.UpdateChangeList(changes);

            var fullList = model.GetAllEntries();
            Assert.AreEqual(entryCount, model.TotalCount);
            Assert.AreEqual(entryCount + 1, fullList.Count);
            Assert.IsTrue(fullList[0].All);

            var toggledEntry = fullList[entryCount / 2 + 1];
            model.UpdateEntryToggle(toggledEntry.Entry.Path, true);
            Assert.IsTrue(toggledEntry.Toggled);

            fullList = model.GetAllEntries();
            Assert.AreEqual(entryCount + 1, fullList.Count);
            foreach (var entry in fullList)
            {
                if (entry == fullList[0])
                {
                    Assert.IsTrue(entry.All);
                }
                else
                {
                    Assert.IsFalse(entry.All);
                }

                if (entry == toggledEntry)
                {
                    Assert.IsTrue(entry.Toggled);
                }
                else
                {
                    Assert.IsFalse(entry.Toggled);
                }
            }

            var toggledList = model.GetToggledEntries();
            Assert.AreEqual(1, toggledList.Count);
            Assert.AreEqual(toggledEntry, toggledList[0]);

            var untoggledList = model.GetUntoggledEntries();
            Assert.AreEqual(entryCount -1, untoggledList.Count);
            foreach (var entry in untoggledList)
            {
                Assert.IsFalse(entry.All);
                Assert.AreNotEqual(toggledEntry, entry);
            }

            Assert.AreEqual(1, model.ToggledCount);
        }

        [Test]
        public void ChangesModel_MultipleSourceControlEntries_ToggleAll()
        {
            const int entryCount = 5;

            var model = new TestableChangesModel();
            model.OnStart();
            var changes = BuildChangesList(entryCount);
            model.UpdateChangeList(changes);

            var fullList = model.GetAllEntries();
            Assert.AreEqual(entryCount + 1, fullList.Count);
            Assert.IsTrue(fullList[0].All);

            model.UpdateEntryToggle(fullList[0].Entry.Path, true);

            fullList = model.GetAllEntries();
            Assert.AreEqual(entryCount + 1, fullList.Count);
            foreach (var entry in fullList)
            {
                if (entry == fullList[0])
                {
                    Assert.IsTrue(entry.All);
                }
                else
                {
                    Assert.IsFalse(entry.All);
                }
                Assert.IsTrue(entry.Toggled);
            }

            var toggledList = model.GetToggledEntries();
            Assert.AreEqual(entryCount, toggledList.Count);
            foreach (var entry in toggledList)
            {
                Assert.IsFalse(entry.All);
            }

            var untoggledList = model.GetUntoggledEntries();
            Assert.AreEqual(0, untoggledList.Count);

            Assert.AreEqual(entryCount, model.ToggledCount);
        }

        [Test]
        public void ChangesModel_MultipleSourceControlEntries_ToggleAllIndividually()
        {
            const int entryCount = 5;

            var model = new TestableChangesModel();
            model.OnStart();
            var changes = BuildChangesList(entryCount);
            model.UpdateChangeList(changes);

            var fullList = model.GetAllEntries();
            Assert.AreEqual(entryCount + 1, fullList.Count);
            Assert.IsTrue(fullList[0].All);

            fullList = model.GetAllEntries();
            foreach (var entry in fullList.Where(entry => !entry.All))
            {
                model.UpdateEntryToggle(entry.Entry.Path, true);
            }

            Assert.AreEqual(entryCount + 1, fullList.Count);
            foreach (var entry in fullList)
            {
                if (entry == fullList[0])
                {
                    Assert.IsTrue(entry.All);
                }
                else
                {
                    Assert.IsFalse(entry.All);
                }
                Assert.IsTrue(entry.Toggled);
            }

            var toggledList = model.GetToggledEntries();
            Assert.AreEqual(entryCount, toggledList.Count);
            foreach (var entry in toggledList)
            {
                Assert.IsFalse(entry.All);
            }

            var untoggledList = model.GetUntoggledEntries();
            Assert.AreEqual(0, untoggledList.Count);

            Assert.AreEqual(entryCount, model.ToggledCount);
        }

        [Test]
        public void ChangesModel_MultipleSourceControlEntries_UntoggleSingleFromAll()
        {
            const int entryCount = 5;

            var model = new TestableChangesModel();
            model.OnStart();
            var changes = BuildChangesList(entryCount);
            model.UpdateChangeList(changes);

            var fullList = model.GetAllEntries();
            Assert.AreEqual(entryCount + 1, fullList.Count);
            Assert.IsTrue(fullList[0].All);

            model.UpdateEntryToggle(fullList[0].Entry.Path, true);
            var untoggledEntry = fullList[entryCount / 2 + 1];
            model.UpdateEntryToggle(untoggledEntry.Entry.Path, false);
            Assert.IsFalse(untoggledEntry.Toggled);

            fullList = model.GetAllEntries();
            Assert.AreEqual(entryCount + 1, fullList.Count);
            foreach (var entry in fullList)
            {
                if (entry == fullList[0])
                {
                    Assert.IsTrue(entry.All);
                }
                else
                {
                    Assert.IsFalse(entry.All);
                }

                if (entry == untoggledEntry || entry.All)
                {
                    Assert.IsFalse(entry.Toggled);
                }
                else
                {
                    Assert.IsTrue(entry.Toggled);
                }
            }

            var toggledList = model.GetToggledEntries();
            Assert.AreEqual(entryCount - 1, toggledList.Count);
            foreach (var entry in toggledList)
            {
                Assert.IsFalse(entry.All);
                Assert.AreNotEqual(untoggledEntry, entry);
            }

            var untoggledList = model.GetUntoggledEntries();
            Assert.AreEqual(1, untoggledList.Count);
            Assert.AreEqual(untoggledEntry, untoggledList[0]);

            Assert.AreEqual(entryCount - 1, model.ToggledCount);
        }

        [Test]
        public void ChangesModel_MultipleSourceControlEntries_SomeConflicted()
        {
            const string conflictedPrefix = "conflicted-path";

            var model = new TestableChangesModel();
            model.OnStart();
            var changes = new List<IChangeEntry>();
            AddEntry(changes, "path1", ChangeEntryStatus.Modified, false);
            AddEntry(changes, "path2", ChangeEntryStatus.Modified, false);
            AddEntry(changes, "path3", ChangeEntryStatus.Modified, false);
            AddEntry(changes, $"{conflictedPrefix}4", ChangeEntryStatus.Modified, false, true);
            AddEntry(changes, $"{conflictedPrefix}5", ChangeEntryStatus.Modified, false, true);
            model.UpdateChangeList(changes);

            var conflictedList = model.GetConflictedEntries();
            model.Provider.ConflictedState = true;
       