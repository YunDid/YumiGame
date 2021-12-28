nt2x4 matrix constructed from a float2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(float2x4 v) { return new uint2x4(v); }

        /// <summary>Returns a uint2x4 matrix constructed from a single double value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(double v) { return new uint2x4(v); }

        /// <summary>Return a uint2x4 matrix constructed from a double2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(double2x4 v) { return new uint2x4(v); }

        /// <summary>Return the uint4x2 transpose of a uint2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 transpose(uint2x4 v)
        {
            return uint4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        /// <summary>Returns a uint hash code of a uint2x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(uint2x4 v)
        {
            return csum(v.c0 * uint2(0x9DF50593u, 0xF18EEB85u) + 
                        v.c1 * uint2(0x9E19BFC3u, 0x8196B06Fu) + 
                        v.c2 * u