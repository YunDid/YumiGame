int2x3 operator & (uint2x3 lhs, uint rhs) { return new uint2x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a uint2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator & (uint lhs, uint2x3 rhs) { return new uint2x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two uint2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator | (uint2x3 lhs, uint2x3 rhs) { return new uint2x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator | (uint2x3 lhs, uint rhs) { return new uint2x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a uint2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator | (uint lhs, uint2x3 rhs) { return new uint2x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two uint2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator ^ (uint2x3 lhs, uint2x3 rhs) { return new uint2x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]