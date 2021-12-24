sion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(uint3x3 v) { return new double3x3(v); }

        /// <summary>Returns a double3x3 matrix constructed from a single float value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(float v) { return new double3x3(v); }

        /// <summary>Return a double3x3 matrix constructed from a float3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(float3x3 v) { return new double3x3(v); }

        /// <summary>Return the double3x3 transpose of a double3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 transpose(double3x3 v)
        {
            return double3x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z);
        }

        /// <summary>Returns the double3x3 full inverse of a double3x3 matrix