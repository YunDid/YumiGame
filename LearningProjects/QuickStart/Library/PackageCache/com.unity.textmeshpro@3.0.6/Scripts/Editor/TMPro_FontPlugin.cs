  public static float3x2 float3x2(float3 c0, float3 c1) { return new float3x2(c0, c1); }

        /// <summary>Returns a float3x2 matrix constructed from from 6 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(float m00, float m01,
                                        float m10, float m11,
                                        float m20, float m21)
        {
            return new float3x2(m00, m01,
                                m10, m11,
                                m20, m21);
        }

        /// <summary>Returns a float3x2 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(float v) { return new float3x2(v); }

        /// <summary>Returns a float3x2 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(bool v) { return new float3x2(v); }

        /// <summary>Return a float3x2 matrix constructed from a bool3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(bool3x2 v) { return new float3x2(v); }

        /// <summary>Returns a float3x2 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(int v) { return new float3x2(v); }

        /// <summary>Return a float3x2 matrix constructed from a int3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(int3x2 v) { return new float3x2(v); }

        /// <summary>Returns a float3x2 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(uint v) { return new float3x2(v); }

        /// <summary>Return a float3x2 matrix constructed from a uint3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(uint3x2 v) { return new float3x2(v); }

        /// <summary>Returns a float3x2 matrix constructed from a single double value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(double v) { return new float3x2(v); }

        /// <summary>Return a float3x2 matrix constructed from a double3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(double3x2 v) { return new float3x2(v); }

        /// <summary>Return the float2x3 transpose of a float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 transpose(float3x2 v)
        {
            return float2x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z);
        }

        /// <summary>Returns a uint hash code of a float3x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float3x2 v)
        {
            return csum(asuint(v.c0) * uint3(0xE121E6ADu, 0xC9CA1249u, 0x69B60C81u) + 
                        asuint(v.c1) * uint3(0xE0EB6C25u, 0xF648BEABu, 0x6BDB2B07u)) + 0xEF63C699u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a float3x2 vector.
        /// When multiple elements are to be hashes