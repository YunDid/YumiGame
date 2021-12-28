er), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a double4x2 matrix constructed from two double4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(double4 c0, double4 c1) { return new double4x2(c0, c1); }

        /// <summary>Returns a double4x2 matrix constructed from from 8 double values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(double m00, double m01,
                                          double m10, double m11,
                                          double m20, double m21,
                                          double m30, double m31)
        {
            return new double4x2(m00, m01,
                                 m10, m11,
                                 m20, m21,
                                 m30, m31);
        }

        /// <summary>Returns a double4x2 matrix constructed from a single double value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(double v) { return new double4x2(v); }

        /// <summary>Returns a double4x2 matrix constructed from a single bool value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(bool v) { return new double4x2(v); }

        /// <summary>Return a double4x2 matrix constructed from a bool4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(bool4x2 v) { return new double4x2(v); }

        /// <summary>Returns a double4x2 matrix constructed from a single int value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(int v) { return new double4x2(v); }

        /// <summary>Return a double4x2 matrix constructed from a int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(int4x2 v) { return new double4x2(v); }

        /// <summary>Returns a double4x2 matrix