th
            };

            outOfDateItems.Added.Add(added);

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
                added, tree);

            Assert.IsNotNull(
                changeInfo,
                "ChangeInfo not found");

            Assert.IsNull(
                tree.GetMetaChange(changeInfo),
                "Meta change should be null");
        }

        [Test]
        public void TestAddedWithMeta()
        {
            MountPointWithPath rootMountPointWithPath = BuildRootMountPointWithPath();

            Difference added = Build.AddedDifference(
                "/foo/bar.c");

            Difference addedMeta = Build.AddedDifference(
                "/foo/bar.c.meta");

            OutOfDateItemsByMount outOfDateItems = new OutOfDateItemsByMount()
            {
                Mount = rootMountPointWithPath
            };

            outOfDateItems.Added.Add(added);
            outOfDateItems.Added.Add(addedMeta);

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
                added, tree);

            Assert.IsNotNull(
                changeInfo,
                "ChangeInfo not found");

            Assert.IsNotNull(
                tree.GetMetaChange(changeInfo),
                "Meta change should not be null");
        }

        [Test]
        public void TestDeletedNoMeta()
        {
            MountPointWithPath rootMountPointWithPath = BuildRootMountPointWithPath();

            Difference deleted = Build.DeletedDifference(
                "/foo/bar.c");

            OutOfDateItemsByMount outOfDateItems = new OutOfDateItemsByMount()
            {
                Mount = rootMountPointWithPath
            };

            outOfDateItems.Deleted.Add(deleted);

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
                deleted, tree);

            Assert.IsNotNull(
                changeInfo,
                "ChangeInfo not found");

            Assert.IsNull(
                tree.GetMetaChange(changeInfo),
                "Meta change should be null");
        }

        [Test]
        public void TestDeletedWithMeta()
        {
            MountPointWithPath rootMountPointWithPath = BuildRootMountPointWithPath();

            Difference deleted = Build.DeletedDifference(
                "/foo/bar.c");

            Difference deletedMeta = Build.DeletedDifference(
                "/foo/bar.c.meta");

            OutOfDateItemsByMount outOfDateItems = new OutOfDateItemsByMount()
            {
                Mount = rootMountPointWithPath
            };

            outOfDateItems.Deleted.Add(deleted);
            outOfDateItems.Deleted.Add(deletedMeta);

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
                deleted, tree);

            Assert.IsNotNull(
                changeInfo,
                "ChangeInfo not found");

            Assert.IsNotNull(
                tree.GetMetaChange(changeInfo),
                "Meta change should not be null");
        }

        [Test]
        public void TestChangedWithDeletedMeta()
        {
            MountPointWithPath rootMountPointWithPath = BuildRootMountPointWithPath();

            Difference changed = Build.ChangedDifference(
                "/foo/bar.c");

            Difference deletedMeta = Build.DeletedDifference(
                "/foo/bar.c.meta");

            OutOfDateItemsByMount outOfDateItems = new OutOfDateItemsByMount()
            {
                Mount = rootMountPointWithPath
            };

            outOfDateItems.Changed.Add(changed);
            outOfDateItems.Deleted.Add(deletedMeta);

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

            IncomingChangeInfo deleteInfo = FindChangeInfo.FromDifference(
                deletedMeta, tree);

            Assert.IsNotNull(
                changeInfo,
                "ChangeInfo not found");

            Assert.IsNotNull(
                deleteInfo,
                "DeleteInfo not found");

            Assert.IsNull(
                tree.GetMetaChange(changeInfo),
                "Meta change should be null");
        }

        [Test]
        public void TestOnlyMeta()
        {
            MountPointWithPath rootMountPointWithPath = BuildRootMountPointWithPath();

            Difference changedMeta = Build.ChangedDifference(
                "/foo/bar.c.meta");

            OutOfDateItemsByMount outOfDateItems = new OutOfDateItemsByMount()
            {
                Mount = rootMountPointWithPath
            };

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

            IncomingChangeInfo changeInfoMeta = FindChangeInfo.FromDifference(
                changedMeta, tree);

            Assert.IsNotNull(
                changeInfoMeta,
                "ChangeInfo not found");

            Assert.IsNull(
                tree.GetMetaChange(changeInfoMeta),
                "Meta change should be null");
        }

        static MountPointWithPath BuildRootMountPointWithPath()
        {
            return new MountPointWithPath(
                MountPointId.WORKSPACE_ROOT,
                new RepositorySpec()
                {
                    Name = "myrep",
                    Server = "myserver:8084"
                },
                "/myroot");
        }

        class Build
        {
            internal static GluonFileConflict FileConflict(
                MountPointWithPath mount,
                string path)
            {
                return new GluonFileConflict(
                    mount,
                    BuildFileRevision(),
                    BuildFileRevision(),
                    path);
            }

            internal static Difference AddedDifference(
                string path)
            {
                return new DiffChanged(
                    BuildFileRevision(), -1, path, -1,
                    Difference.DiffNodeStatus.Added);
            }

            internal static Difference MovedDifference(
                string srcPath,
           