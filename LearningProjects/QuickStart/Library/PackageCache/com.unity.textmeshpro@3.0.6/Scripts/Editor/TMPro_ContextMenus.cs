 and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator % (float2x4 lhs, float rhs) { return new float2x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator % (float lhs, float2x4 rhs) { return new float2x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }


        /// <summary>Returns the result of a componentwise increment operation on a float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator ++ (float2x4 val) { return new float2x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        /// <summary>Returns the result of a componentwise decrement operation on a float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator -- (float2x4 val) { return new float2x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        /// <summary>Returns the result of a componentwise less than operation on two float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (float2x4 lhs, float2x4 rhs) { return new bool2x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }

        /// <summary>Returns the result of a componentwise less than operation on a float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (float2x4 lhs, float rhs) { return new bool2x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (float lhs, float2x4 rhs) { return new bool2x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }


        /// <summary>Returns the result of a componentwise less or equal operation on two float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (float2x4 lhs, float2x4 rhs) { return new bool2x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (float2x4 lhs, float rhs) { return new bool2x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (float lhs, float2x4 rhs) { return new bool2x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }


        /// <summary>Returns the result of a componentwise greater than operation on two float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (float2x4 lhs, float2x4 rhs) { return new bool2x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }

        /// <summary>Returns the result of a componentwise greater than operation on a float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (float2x4 lhs, float rhs) { return new bool2x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (float lhs, float2x4 rhs) { return new bool2x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (float2x4 lhs, float2x4 rhs) { return new bool2x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (float2x4 lhs, float rhs) { return new bool2x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (float lhs, float2x4 rhs) { return new bool2x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }


        /// <summary>Returns the result of a componentwise unary minus operation on a float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator - (float2x4 val) { return new float2x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        /// <summary>Returns the result of a componentwise unary plus operation on a float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator + (float2x4 val) { return new float2x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        /// <summary>Returns the result of a componentwise equality operation on two float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (float2x4 lhs, float2x4 rhs) { return new bool2x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on a float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (float2x4 lhs, float rhs) { return new bool2x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (float lhs, float2x4 rhs) { return new bool2x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (float2x4 lhs, float2x4 rhs) { return new bool2x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on a float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (float2x4 lhs, float rhs) { return new bool2x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (float lhs, float2x4 rhs) { return new bool2x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }



        /// <summary>Returns the float2 element at a specified index.</summary>
        unsafe public ref float2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (float2x4* array = &this) { return ref ((float2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the float2x4 is equal to a given float2x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(float2x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the float2x4 is equal to a given float2x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((float2x4)o); }


        /// <summary>Returns a hash code for the float2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the float2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float2x4({0}f, {1}f, {2}f, {3}f,  {4}f, {5}f, {6}f, {7}f)", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y);
        }

        /// <summary>Returns a string representation of the float2x4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float2x4({0}f, {1}f, {2}f, {3}f,  {4}f, {5}f, {6}f, {7}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a float2x4 matrix constructed from four float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(float2 c0, float2 c1, float2 c2, float2 c3) { return new float2x4(c0, c1, c2, c3); }

        /// <summary>Returns a float2x4 matrix constructed from from 8 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(float m00, float m01, float m02, float m03,
                                        float m10, float m11, float m12, float m13)
        {
            return new float2x4(m00, m01, m02, m03,
                                m10, m11, m12, m13);
        }

        /// <summary>Returns a float2x4 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(float v) { return new float2x4(v); }

        /// <summary>Returns a float2x4 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(bool v) { return new float2x4(v); }

        /// <summary>Return a float2x4 matrix constructed from a bool2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(bool2x4 v) { return new float2x4(v); }

        /// <summary>Returns a float2x4 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(int v) { return new float2x4(v); }

        /// <summary>Return a float2x4 matrix constructed from a int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(int2x4 v) { return new float2x4(v); }

        /// <summary>Returns a float2x4 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(uint v) { return new float2x4(v); }

        /// <summary>Return a float2x4 matrix constructed from a uint2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(uint2x4 v) { return new float2x4(v); }

        /// <summary>Returns a float2x4 matrix constructed from a single double value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(double v) { return new float2x4(v); }

        /// <summary>Return a float2x4 matrix constructed from a double2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(double2x4 v) { return new float2x4(v); }

        /// <summary>Return the float4x2 transpose of a float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 transpose(float2x4 v)
        {
            return float4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        /// <summary>Returns a uint hash code of a float2x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float2x4 v)
        {
            return csum(asuint(v.c0) * uint2(0xD35C9B2Du, 0xA10D9E27u) + 
                        asuint(v.c1) * uint2(0x568DAAA9u, 0x7530254Fu) + 
                        asuint(v.c2) * uint2(0x9F090439u, 0x5E9F85C9u) + 
                        asuint(v.c3) * uint2(0x8C4CA03Fu, 0xB8D969EDu)) + 0xAC5DB57Bu;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a float2x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(float2x4 v)
        {
            return (asuint(v.c0) * uint2(0xA91A02EDu, 0xB3C49313u) + 
                    asuint(v.c1) * uint2(0xF43A9ABBu, 0x84E7E01Bu) + 
                    asuint(v.c2) * uint2(0x8E055BE5u, 0x6E624EB7u) + 
                    asuint(v.c3) * uint2(0x7383ED49u, 0xDD49C23Bu)) + 0xEBD0D005u;
        }

    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        