ecified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator << (uint2x2 x, int n) { return new uint2x2 (x.c0 << n, x.c1 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a uint2x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator >> (uint2x2 x, int n) { return new uint2x2 (x.c0 >> n, x.c1 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (uint2x2 lhs, uint2x2 rhs) { return new bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (uint2x2 lhs, uint rhs) { return new bool2x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (uint lhs, uint2x2 rhs) { return new bool2x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (uint2x2 lhs, uint2x2 rhs) { return new bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (uint2x2 lhs, uint rhs) { return new bool2x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (uint lhs, uint2x2 rhs) { return new bool2x2 (lhs != rhs.c0, lhs != rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator ~ (uint2x2 val) { return new uint2x2 (~val.c0, ~val.c1); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator & (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator & (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 & rhs, lhs.c1 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator & (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs & rhs.c0, lhs & rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator | (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator | (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 | rhs, lhs.c1 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator | (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs | rhs.c0, lhs | rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator ^ (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator ^ (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator ^ (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }



        /// <summary>Returns the uint2 element at a specified index.</summary>
        unsafe public ref uint2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint2x2* array = &this) { return ref ((uint2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the uint2x2 is equal to a given uint2x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(uint2x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the uint2x2 is equal to a given uint2x2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((uint2x2)o); }


        /// <summary>Returns a hash code for the uint2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the uint2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("uint2x2({0}, {1},  {2}, {3})", c0.x, c1.x, c0.y, c1.y);
        }

        /// <summary>Returns a string representation of the uint2x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint2x2({0}, {1},  {2}, {3})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a uint2x2 matrix constructed from two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 uint2x2(uint2 c0, uint2 c1) { return new uint2x2(c0, c1); }

        /// <summary>Returns a uint2x2 matrix constructed from from 4 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 uint2x2(uint m00, uint m01,
                                      uint m10, uint m11)
        {
            return new uint2x2(m00, m01,
                               m10, m11);
        }

        /// <summary>Returns a uint2x2 matrix constructed from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 uint2x2(uint v) { return new uint2x2(v); }

        /// <summary>Returns a uint2x2 matrix constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 uint2x2(bool v) { return new uint2x2(v); }

        /// <summary>Return a uint2x2 matrix 