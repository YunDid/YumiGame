(a0 ^ b0, r0);

            bool a1 = (false);
            bool4x4 b1 = bool4x4(true, false, true, false, false, false, false, true, false, true, false, true, true, false, true, false);
            bool4x4 r1 = bool4x4(true, false, true, false, false, false, false, true, false, true, false, true, true, false, true, false);
            TestUtils.AreEqual(a1 ^ b1, r1);

            bool a2 = (false);
            bool4x4 b2 = bool4x4(false, false, true, false, false, false, false, false, true, false, false, true, true, false, false, true);
            bool4x4 r2 = bool4x4(false, false, true, false, false, false, false, false, true, false, false, true, true, false, false, true);
            TestUtils.AreEqual(a2 ^ b2, r2);

            bool a3 = (fa