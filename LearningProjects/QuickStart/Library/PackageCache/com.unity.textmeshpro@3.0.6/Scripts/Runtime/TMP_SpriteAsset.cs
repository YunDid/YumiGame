this.y = v.y;
        }

        /// <summary>Constructs a double2 vector from a single float value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(float v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>Constructs a double2 vector from a float2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(float2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }


        /// <summary>Implicitly converts a single double value to a double2 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(double v) { return new double2(v); }

        /// <summary>Explicitly converts a single bool value to a double2 vector by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double2(bool v) { return new double2(v); }

        /// <summary>Explicitly converts a bool2 vector to a double2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double2(bool2 v) { return new double2(v); }

        /// <summary>Implicitly converts a single int value to a double2 vector by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(int v) { return new double2(v); }

        /// <summary>Implicitly converts a int2 vector to a double2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(int2 v) { return new double2(v); }

        /// <summary>Implicitly converts a single uint value to a double2 vector by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(uint v) { return new double2(v); }

        /// <summary>Implicitly converts a uint2 vector to a double2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(uint2 v) { return new double2(v); }

        /// <summary>Implicitly converts a single half value to a double2 vector by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(half v) { return new double2(v); }

        /// <summary>Implicitly converts a half2 vector to a double2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(half2 v) { return new double2(v); }

        /// <summary>Implicitly converts a single float value to a double2 vector by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(float v) { return new double2(v); }

        /// <summary>Implicitly converts a float2 vector to a double2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(float2 v) { return new double2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator * (double2 lhs, double2 rhs) { return new double2 (lhs.x * rhs.x, lhs.y * rhs.y); }

        /// <summary>Returns the result of a componentwise multiplication operation on a double2 vector and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator * (double2 lhs, double rhs) { return new double2 (lhs.x * rhs, lhs.y * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a double value and a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator * (double lhs, double2 rhs) { return new double2 (lhs * rhs.x, lhs * rhs.y); }


        /// <summary>Returns the result of a componentwise addition operation on two double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator + (double2 lhs, double2 rhs) { return new double2 (lhs.x + rhs.x, lhs.y + rhs.y); }

        /// <summary>Returns the result of a componentwise addition operation on a double2 vector and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator + (double2 lhs, double rhs) { return new double2 (lhs.x + rhs, lhs.y + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a double value and a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator + (double lhs, double2 rhs) { return new double2 (lhs + rhs.x, lhs + rhs.y); }


        /// <summary>Returns the result of a componentwise subtraction operation on two double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator - (double2 lhs, double2 rhs) { return new double2 (lhs.x - rhs.x, lhs.y - rhs.y); }

        /// <summary>Returns the result of a componentwise subtraction operation on a double2 vector and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator - (double2 lhs, double rhs) { return new double2 (lhs.x - rhs, lhs.y - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a double value and a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator - (double lhs, double2 rhs) { return new double2 (lhs - rhs.x, lhs - rhs.y); }


        /// <summary>Returns the result of a componentwise division operation on two double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator / (double2 lhs, double2 rhs) { return new double2 (lhs.x / rhs.x, lhs.y / rhs.y); }

        /// <summary>Returns the result of a componentwise division operation on a double2 vector and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator / (double2 lhs, double rhs) { return new double2 (lhs.x / rhs, lhs.y / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a double value and a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator / (double lhs, double2 rhs) { return new double2 (lhs / rhs.x, lhs / rhs.y); }


        /// <summary>Returns the result of a componentwise modulus operation on two double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator % (double2 lhs, double2 rhs) { return new double2 (lhs.x % rhs.x, lhs.y % rhs.y); }

        /// <summary>Returns the result of a componentwise modulus operation on a double2 vector and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator % (double2 lhs, double rhs) { return new double2 (lhs.x % rhs, lhs.y % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a double value and a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator % (double lhs, double2 rhs) { return new double2 (lhs % rhs.x, lhs % rhs.y); }


        /// <summary>Returns the result of a componentwise increment operation on a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator ++ (double2 val) { return new double2 (++val.x, ++val.y); }


        /// <summary>Returns the result of a componentwise decrement operation on a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator -- (double2 val) { return new double2 (--val.x, --val.y); }


        /// <summary>Returns the result of a componentwise less than operation on two double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (double2 lhs, double2 rhs) { return new bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }

        /// <summary>Returns the result of a componentwise less than operation on a double2 vector and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (double2 lhs, double rhs) { return new bool2 (lhs.x < rhs, lhs.y < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a double value and a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (double lhs, double2 rhs) { return new bool2 (lhs < rhs.x, lhs < rhs.y); }


        /// <summary>Returns the result of a componentwise less or equal operation on two double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (double2 lhs, double2 rhs) { return new bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }

        /// <summary>Returns the result of a componentwise less or equal operation on a double2 vector and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (double2 lhs, double rhs) { return new bool2 (lhs.x <= rhs, lhs.y <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a double value and a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (double lhs, double2 rhs) { return new bool2 (lhs <= rhs.x, lhs <= rhs.y); }


        /// <summary>Returns the result of a componentwise greater than operation on two double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (double2 lhs, double2 rhs) { return new bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }

        /// <summary>Returns the result of a componentwise greater than operation on a double2 vector and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (double2 lhs, double rhs) { return new bool2 (lhs.x > rhs, lhs.y > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a double value and a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (double lhs, double2 rhs) { return new bool2 (lhs > rhs.x, lhs > rhs.y); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (double2 lhs, double2 rhs) { return new bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a double2 vector and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (double2 lhs, double rhs) { return new bool2 (lhs.x >= rhs, lhs.y >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a double value and a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (double lhs, double2 rhs) { return new bool2 (lhs >= rhs.x, lhs >= rhs.y); }


        /// <summary>Returns the result of a componentwise unary minus operation on a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator - (double2 val) { return new double2 (-val.x, -val.y); }


        /// <summary>Returns the result of a componentwise unary plus operation on a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator + (double2 val) { return new double2 (+val.x, +val.y); }


        /// <summary>Returns the result of a componentwise equality operation on two double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (double2 lhs, double2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }

        /// <summary>Returns the result of a componentwise equality operation on a double2 vector and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (double2 lhs, double rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a double value and a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (double lhs, double2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }


        /// <summary>Returns the result of a componentwise not equal operation on two double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (double2 lhs, double2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }

        /// <summary>Returns the result of a componentwise not equal operation on a double2 vector and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (double2 lhs, double rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a double value and a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (double lhs, double2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }




        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double2(y, y); }
        }



        /// <summary>Returns the double element at a specified index.</summary>
        unsafe public double this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
               