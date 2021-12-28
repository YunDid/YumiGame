sset(barPath);

                WorkspaceTreeNode fooNode = BuildWorkspaceTreeNode.Controlled();

                apiMock.SetupGetWorkspaceTreeNode(fooPath, fooNode);
                apiMock.SetupGetWorkspaceTreeNode(barPath, null);
                apiMock.SetupGetWorkingBranch(new BranchInfo());

                AssetList assetList = new AssetList();
                assetList.Add(fooAsset);
                assetList.Add(barAsset);

                SelectedAssetGroupInfo groupInfo =
                    SelectedAssetGroupInfo.BuildFromAssetList(
                        assetList,
                        new AssetStatusCacheMock());

                Assert.IsFalse(groupInfo.IsPrivateSelection);
            }
            finally
            {
                Plastic.InitializeAPIForTesting(new PlasticAPI());
            }
        }

        [Test]
        public void TestIsAddedSelection()
        {
            try
            {
                PlasticApiMock apiMock = new PlasticApiMock();

                Plastic.InitializeAPIForTesting(apiMock);

                string fooPath = Path.Combine(Path.GetTempPath(), "foo.c");
                string barPath = Path.Combine(Path.GetTempPath(), "bar.c");

                Asset fooAsset = new Asset(fooPath);
                Asset barAsset = new Asset(barPath);

                WorkspaceTreeNode fooNode = BuildWorkspaceTreeNode.Added();
                WorkspaceTreeNode barNode = BuildWorkspaceTreeNode.Added();

                apiMock.SetupGetWorkspaceTreeNode(fooPath, fooNode);
                apiMock.SetupGetWorkspaceTreeNode(barPath, barNode);
                apiMock.SetupGetWorkingBranch(new BranchInfo());

                AssetList assetList = new AssetList();
                assetList.Add(fooAsset);
                assetList.Add(barAsset);

                SelectedAssetGroupInfo groupInfo =
                    SelectedAssetGroupInfo.BuildFromAssetList(
                        assetList,
                        new AssetStatusCacheMock());

                Assert.IsTrue(groupInfo.IsAddedSelection);
            }
            finally
            {
                Plastic.InitializeAPIForTesting(new PlasticAPI());
            }
        }

        [Test]
        public void TestIsNotAddedSelection()
        {
            try
            {
                PlasticApiMock apiMock = new PlasticApiMock();

                Plastic.InitializeAPIForTesting(apiMock);

                string fooPath = Path.Combine(Path.GetTempPath(), "foo.c");
                string barPath = Path.Combine(Path.GetTempPath(), "bar.c");

                Asset fooAsset = new Asset(fooPath);
                Asset barAsset = new Asset(barPath);

                WorkspaceTreeNode fooNode = BuildWorkspaceTreeNode.Added();
                WorkspaceTreeNode barNode = BuildWorkspace