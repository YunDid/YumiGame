t2x2 float2x2(float2 c0, float2 c1) { return new float2x2(c0, c1); }

        /// <summary>Returns a float2x2 matrix constructed from from 4 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(float m00, float m01,
                                        float m10, float m11)
        {
            return new float2x2(m00, m01,
                                m10, m11);
        }

        /// <summary>Returns a float2x2 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(float v) { return new float2x2(v); }

        /// <summary>Returns a float2x2 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(bool v) { return new float2x2(v); }

        /// <summary>Return a float2x2 matrix constructed from a bool2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(bool2x2 v) { return new float2x2(v); }

        /// <summary>Returns a float2x2 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(int v) { return new float2x2(v); }

        /// <summary>Return a float2x2 matrix constructed from a int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(int2x2 v) { return new float2x2(v); }

        /// <summary>Returns a float2x2 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(uint v) { return new float2x2(v); }

        /// <summary>Return a float2x2 matrix constructed from a uint2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(uint2x2 v) { return new float2x2(v); }

        /// <summary>Returns a float2x2 matrix constructed from a single double value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(double v) { return new float2x2(v); }

        /// <summary>Return a float2x2 matrix constructed from a double2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(double2x2 v) { return new float2x2(v); }

        /// <summary>Return the float2x2 transpose of a float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 transpose(float2x2 v)
        {
            return float2x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y);
        }

        /// <summary>Returns the float2x2 full inverse of a float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 inverse(float2x2 m)
        {
            float a = m.c0.x;
            float b = m.c1.x;
            float c = m.c0.y;
            float d = m.c1.y;

            float det = a * d - b * c;

            return float2x2(d, -b, -c, a) * (1.0f / det);
        }

        /// <summary>Returns the determinant of a float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float determinant(float2x2 m)
        {
            float a = m.c0.x;
            float b = m.c1.x;
            float c = m.c0.y;
            float d = m.c1.y;

            return a * d - b * c;
        }

        /// <summary>Returns a uint hash code of a float2x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float2x2 v)
        {
            return csum(asuint(v.c0) * uint2(0x9C9F0823u, 0x5A9CA13Bu) + 
                  