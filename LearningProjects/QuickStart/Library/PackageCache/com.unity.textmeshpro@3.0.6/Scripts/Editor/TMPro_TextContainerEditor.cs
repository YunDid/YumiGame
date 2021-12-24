 int toggledIndex2 = entryCount / 2 + 1;
            const int untoggledIndex = entryCount - 1;

            var changes = BuildChangesList(entryCount);
            var dictionary = new Dictionary<string, bool>();
            changes.ForEach( (x) => dictionary[x.Path] = false );
            dictionary[changes[toggledIndex1].Path] = true;
            dictionary[changes[toggledIndex2].Path] = true;
            dictionary[changes[untoggledIndex].Path] = false;

            var model = new TestableChangesModel();
            model.OnStart();
            model.SetToggled(dictionary);
            model.UpdateChangeList(changes);

            var fullList = model.GetAllEntries();
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

                if (entry.Entry.Path == changes[toggledIndex1].Path || entry.Entry.Path == changes[toggledIndex2].Path)
                {
                    Assert.IsTrue(entry.Toggled);
                }
                else
                {
                    Assert.IsFalse(entry.Toggled);
                }
            }

            var toggledList = model.GetToggledEntries();
            Assert.AreEqual(toggledCount, toggledList.Count);
            foreach (var entry in toggledList)
            {
                Assert.IsTrue(entry.Entry.Path == changes[toggledIndex1].Path || entry.Entry.Path == changes[toggledIndex2].Path);
                Assert.IsFalse(entry.All);
                Assert.IsTrue(entry.Toggled);
            }

            var untoggledList = model.GetUntoggledEntries();
            Assert.AreEqual(entryCount - toggledCount, untoggledList.Count);
            foreach (var entry in untoggledList)
            {
                Assert.IsTrue(entry.Entry.Path != changes[toggledIndex1].Path && entry.Entry.Path != changes[toggledIndex2].Path);
                Assert.IsFalse(entry.All);
                Assert.IsFalse(entry.Toggled);
            }
        }

        [Test]
        public void ChangesModel_SearchFilters_CaseInsensitive()
        {
            var changes = new List<IChangeEntry>();
            AddEntry(changes, "alpha1", ChangeEntryStatus.Modified, false);
            AddEntry(changes, "alpha2", ChangeEntryStatus.Modified, false);
            AddEntry(changes, "bravo", ChangeEntryStatus.Modified, false);
            AddEntry(changes, "charlie", ChangeEntryStatus.Modified, false);
            AddEntry(changes, "Delta3", ChangeEntryStatus.Modified, false);
            AddEntry(changes, "delta4", ChangeEntryStatus.Modified, false);
            AddEntry(changes, "delta5", ChangeEntryStatus.Modified, false);
            AddEntry(changes, "echo", ChangeEntryStatus.Modified, false);
            AddEntry(changes, "Foxtrot6", ChangeEntryStatus.Modified, false);
            AddEntry(changes, "Foxtrot7", ChangeEntryStatus.Modified, false);
            AddEntry(changes, "golf", ChangeEntryStatus.Modified, false);

            var dictionary = new Dictionary<string, bool>
            {
                ["delta5"] = true, ["Foxtrot6"] = true, ["Foxtrot7"] = true, ["golf"] = true
            };

            var model = new TestableChangesModel();
            model.OnStart();
            model.SetToggled(dictionary);
            model.UpdateChangeList(changes);

            var fullList = model.GetAllEntries();
            Assert.AreEqual(changes.Count, model.TotalCount);
            Assert.AreEqual(changes.Count + 1, fullList.Count);
            Assert.IsTrue(fullList[0].All);

            var searchFullList = model.GetAllEntries("alpha");
            Assert.AreEqual(2, searchFullList.Count);
            foreach (var entry in searchFullList)
            {
                Assert.IsFalse(entry.All);
                Assert.IsFalse(entry.Toggled);
            }

            var toggledList = model.GetToggledEntries();
            Assert.AreEqual(dictionary.Count, toggledList.Count);
            foreach (var entry in toggledList)
            {
                Assert.IsFalse(entry.All);
            }

            var searchToggledList = model.GetToggledEntries("fox");
            Assert.AreEqual(2, searchToggledList.Count);
            foreach (var entry in searchToggledList)
            {
                Assert.IsTrue(entry.Entry.Path.ToLower().Contains("fox"));
                Assert.IsFalse(entry.All);
                Assert.IsTrue(entry.Toggled);
            }

            var untoggledList = model.GetUntoggledEntries();
            Assert.AreEqual(changes.Count - dictionary.Count, untoggledList.Count);

            var searchUntoggledList = model.GetUntoggledEntries("Del");
            Assert.AreEqual(2, searchUntoggledList.Count);
            foreach (var entry in searchUntoggledList)
            {
                Assert.IsTrue(entry.Entry.Path.ToLower().Contains("del"));
                Assert.AreNotEqual("delta5", entry.Entry.Path);
                Assert.IsFalse(entry.All);
                Assert.IsFalse(entry.Toggled);
            }

            Assert.AreEqual(dictionary.Count, model.ToggledCount);
        }

        [Test]
        public void TestRequestInitialData()
        {
            var provider = new TestSourceControlProvider();
            var model = new ChangesModel(provider);
            model.OnStart();

            var callCount = 0;
            bool? callValue = null;
            model.BusyStatusUpdated += b =>
            {
                callCount++;
                callValue = b;
            };

            Assert.IsFalse(model.Busy);
            model.RequestInitialData();
            Assert.AreEqual(1, provider.RequestedChangeListCount);
            Assert.IsNotNull(provider.RequestedChangeListCallback);
            Assert.IsTrue(model.Busy);
            Assert.IsTrue(callValue);
            provider.RequestedChangeListCallback.Invoke(new List<IChangeEntry>());
            Assert.IsFalse(model.Busy);
            Assert.IsFalse(callValue);
            Assert.AreEqual(2, callCount);
        }

        [Test]
        public void TestReceiveUpdatedChangeListEvent()
        {
            var provider = new TestSourceControlProvider();
            var model = new ChangesModel(provider);
            model.OnStart();

            var callCount = 0;
            bool? callValue = null;
            model.BusyStatusUpdated += b =>
            {
                callCount++;
                callValue = b;
            };

            Assert.IsFalse(model.Busy);
            provider.TriggerUpdatedChangeEntries();
            Assert.AreEqual(1, provider.RequestedChangeListCount);
            Assert.IsNotNull(provider.RequestedChangeListCallback);
            Assert.IsTrue(model.Busy);
            Assert.IsTrue(callValue);
            provider.RequestedChangeListCallback.Invoke(new List<IChangeEntry>());
            Assert.IsFalse(model.Busy);
            Assert.IsFalse(callValue);
            Assert.AreEqual(2, callCount);
        }

        [Test]
        public void TestRequestDiff()
        {
            var provider = new TestSourceControlProvider();
            var model = new ChangesModel(provider);
            model.OnStart();

            const string path = "path";
            model.RequestDiffChanges(path);
            Assert.AreEqual(1, provider.RequestedDiffChangesCount);
            Assert.AreEqual(path, provider.RequestedDiffChangesPath);
        }

        [Test]
        public void TestRequestDiscard()
        {
            var provider = new TestSourceControlProvider();
            var model = new ChangesModel(pr