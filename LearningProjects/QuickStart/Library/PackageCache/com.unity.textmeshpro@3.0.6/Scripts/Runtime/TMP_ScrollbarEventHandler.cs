       bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [TestCompiler]
        public static void bool4x4_operator_bitwise_xor_wide_wide()
        {
            bool4x4 a0 = bool4x4(true, false, true, true, true, true, false, false, false, false, true, false, false, false, true, false);
            bool4x4 b0 = bool4x4(false, true, false, false, false, true, false, false, true, true, true, false, false, false, true, true);
            bool4x4 r0 = bool4x4(true, true, true, true, true, false, false, false, true, true, false, false, false, false, false, true);
            Tes