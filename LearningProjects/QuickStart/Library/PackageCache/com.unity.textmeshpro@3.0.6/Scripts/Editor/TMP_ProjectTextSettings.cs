e movedMeta = Build.MovedDifference(
                "/foo/bar.c.meta",
                "/foo/var.c.meta");

            OutOfDateItemsByMount outOfDateItems = new OutOfDateItemsByMount()
            {
                Mount = rootMountPointWithPath
            };

            outOfDateItems.Moved.Add(moved);
            outOfDateItems.Moved.Add(movedMeta);

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
                moved, tree);

            Assert.IsNotNull(
                changeInfo,
                "ChangeInfo not found");

            Assert.IsNotNull(
                tree.GetMetaChange(changeInfo),
                "Meta chang