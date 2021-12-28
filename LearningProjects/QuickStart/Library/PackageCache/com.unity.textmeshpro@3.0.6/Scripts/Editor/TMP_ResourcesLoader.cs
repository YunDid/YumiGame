eItemsByMount.Add(outOfDateItems);

            IncomingChangesTree innerTree = IncomingChangesTree.BuildIncomingChangeCategories(
                checkedStateManager,
                outOfDateItemsByMount,
                fileConflicts);

            UnityIncomingChangesTree tree =
                UnityIncomingChangesTree.BuildIncomingChangeCategories(innerTree);

            IncomingChangeInfo changeInfo = FindChangeInfo.FromDifference(
                changed, tree);

            Assert.IsNotNull(
                changeInfo,
                "ChangeInfo not found");

            Assert.IsNull(
                tree.GetMetaChange(changeInfo),
                "Meta change should be null");
        }

        [Test]
        public void TestChangedWithMeta()
        {
            MountPointWithPath rootMountPointWithPath = BuildRootMountPointWithPath();

            Difference changed = Build.ChangedDifference(
                "/foo/bar.c");

            Difference changedMeta = Build.ChangedDifference(
                "/foo/bar.c.meta");

            OutOfDateItemsByMount outOfDateItems = new OutOfDateItemsByMount()
            {
                Mount = rootMountPointWithPath
            };

            outOfDateItems.Changed.Add(changed);
            outOfDateItems.Changed.Add(changedMeta);

            CheckedStateManager checkedStateManager = new CheckedStateManager();
            List<OutOfDateItemsByMount> outOfDateItemsByMount =
                new List<OutOfDateItemsByMount>();
            List<GluonFileConflict> fileConflicts = new List<GluonFileConflict>();

            outOfDateItemsByMount.Add(outOfDateItems);

            IncomingChangesTree innerTree = IncomingChangesTree.BuildIncomingChangeCategories(
                checkedStateManager,
                outOfDateItemsByMount,
                fileConflicts);

            UnityIncomingChangesTree tree =
                UnityIncomingChangesTree.BuildIncomingChangeCategories(innerTree);

            IncomingChangeInfo changeInfo = FindChangeInfo.FromDifference(
                changed, tree);

            Assert.IsNotNull(
                changeInfo,
                "ChangeInfo not found");

            Assert.IsNotNull(
  