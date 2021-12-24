Impl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator ++ (float2x3 val) { return new float2x3 (++val.c0, ++val.c1, ++val.c2); }


        /// <summary>Returns the result of a componentwise decrement operation on a float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator -- (float2x3 val) { return new float2x3 (--val.c0, --val.c1, --val.c2); }


        /// <summary>Returns the result of a componentwise less than operation on two float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (float2x3 lhs, float2x3 rhs) { return new bool2x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }

        /// <summary>Returns the result of a componentwise less than operation on a float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (float2x3 lhs, float rhs) { return new bool2x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (float lhs, float2x3 rhs) { return new bool2x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }


        /// <summary>Returns the result of a componentwise less or equal operation on two float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (float2x3 lhs, float2x3 rhs) { return new bool2x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (float2x3 lhs, float rhs) { return new bool2x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (float lhs, float2x3 rhs) { return new bool2x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }


        /// <summary>Returns the result of a componentwise greater than operation on two float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (float2x3 lhs, float2x3 rhs) { return new bool2x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }

        /// <summary>Returns the result of a componentwise greater than operation on a float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (float2x3 lhs, float rhs) { return new bool2x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (float lhs, float2x3 rhs) { return new bool2x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (float2x3 lhs, float2x3 rhs) { return new bool2x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (float2x3 lhs, float rhs) { return new bool2x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (float lhs, float2x3 rhs) { return new bool2x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }


        /// <summary>Returns the result of a componentwise unary minus operation on a float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator - (float2x3 val) { return new float2x3 (-val.c0, -val.c1, -val.c2); }


        /// <summary>Returns the result of a componentwise unary plus operation on a float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator + (float2x3 val) { return new float2x3 (+val.c0, +val.c1, +val.c2); }


        /// <summary>Returns the result of a componentwise equality operation on two float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (float2x3 lhs, float2x3 rhs) { return new bool2x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }

        /// <summary>Returns the result of a componentwise equality operation on a float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (float2x3 lhs, float rhs) { return new bool2x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (float lhs, float2x3 rhs) { return new bool2x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }


        /// <summary>Returns the result of a componentwise not equal operation on two float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (float2x3 lhs, float2x3 rhs) { return new bool2x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }

        /// <summary>Returns the result of a componentwise not equal operation on a float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (float2x3 lhs, float rhs) { return new bool2x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (float lhs, float2x3 rhs) { return new bool2x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }



        /// <summary>Returns the float2 element at a specified index.</summary>
        unsafe public ref float2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (float2x3* array = &this) { return ref ((float2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the float2x3 is equal to a given float2x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(float2x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        /// <summary>Returns true if the float2x3 is equal to a given float2x3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((float2x3)o); }


        /// <summary>Returns a hash code for the float2x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the float2x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float2x3({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f)", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y);
        }

        /// <summary>Returns a string representation of the float2x3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float2x3({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a float2x3 matrix constructed from three float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(float2 c0, float2 c1, float2 c2) { return new float2x3(c0, c1, c2); }

        /// <summary>Returns a float2x3 matrix constructed from from 6 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(float m00, float m01, float m02,
                                        float m10, float m11, float m12)
        {
            return new float2x3(m00, m01, m02,
                                m10, m11, m12);
        }

        /// <summary>Returns a float2x3 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(float v) { return new float2x3(v); }

        /// <summary>Returns a float2x3 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(bool v) { return new float2x3(v); }

        /// <summary>Return a float2x3 matrix constructed from a bool2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(bool2x3 v) { return new float2x3(v); }

        /// <summary>Returns a float2x3 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(int v) { return new float2x3(v); }

        /// <summary>Return a float2x3 matrix constructed from a int2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(int2x3 v) { return new float2x3(v); }

        /// <summary>Returns a float2x3 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(uint v) { return new float2x3(v); }

        /// <summary>Return a float2x3 matrix constructed from a uint2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(uint2x3 v) { return new float2x3(v); }

        /// <summary>Returns a float2x3 matrix constructed from a single double value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(double v) { return new float2x3(v); }

        /// <summary>Return a float2x3 matrix constructed from a double2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
  