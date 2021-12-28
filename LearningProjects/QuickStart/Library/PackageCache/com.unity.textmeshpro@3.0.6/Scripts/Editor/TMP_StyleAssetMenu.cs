veInlining)]
        public static double4x3 double4x3(uint v) { return new double4x3(v); }

        /// <summary>Return a double4x3 matrix constructed from a uint4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(uint4x3 v) { return new double4x3(v); }

        /// <summary>Returns a double4x3 matrix constructed from a single float value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(float v) { return new double4x3(v); }

        /// <summary>Return a double4x3 matrix constructed from a float4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(float4x3 v) { return new double4x3(v); }

        /// <summary>Return the double3x4 transpose of a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 transpose(double4x3 v)
        {
            return double3x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w);
        }

        /// <summary>Returns a uint hash code of a double4x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double4x3 v)
        {
            return csum(fold_to_uint(v.c0) * uint4(0x7AA07CD3u, 0xAF642BA9u, 0xA8F2213Bu, 0x9F3FDC37u) + 
                        fold_to_uint(v.c1) * uint4(0xAC60D0C3u, 0x9263662Fu, 0xE69626F