

    }

    public static partial class math
    {
        /// <summary>Returns a double3x2 matrix constructed from two double3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x2 double3x2(double3 c0, double3 c1) { return new double3x2(c0, c1); }

        /// <summary>Returns a double3x2 matrix constructed from from 6 double values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x2 double3x2(double m00, double m01,
                                          double m10, double m11,
                                          double m20, double m21)
        {
            return new double3x2(m00, m01,
                                 m10, m11,
                                 m20, m21);
        }

        /// <summary>Returns a double3x2 matrix constructed from a single double value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x2 double3x2(double v) { return new double3x2(v); }

        /// <summary>Returns a double3x2 matrix constructed from a single bool value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x2 double3x2(bool v) { return new double3x2(v); }

        /// <summary>Return a double3x2 matrix constructed from a bool3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x2 double3x2(bool3x2 v) { return new double3x2(v); }

        /// <summary>Returns a double3x2 matrix constructed from a single int value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x2 double3x2(int v) { return new double3x2(v); }

        /// <summary>Return a double3x2 matrix constructed from a int3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x2 double3x2(int3x2 v) { return new double3x2(v); }

        /// <summary>Returns a double3x2 matrix constructed from a single uint value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x2 double3x2(uint v) { return new double3x2(v); }

        /// <summary>Return a double3x2 matrix constructed from a uint3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x2 double3x2(uint3x2 v) { return new double3x2(v); }

        /// <summary>Returns a double3x2 matrix constructed from a single float value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x2 double3x2(float v) { return new double3x2(v); }

        /// <summary>Return a double3x2 matrix constructed from a float3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x2 double3x2(float3x2 v) { return new double3x2(v); }

        /// <summary>Return the double2x3 transpose of a double3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 transpose(double3x2 v)
        {
            return double2x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z);
        }

        /// <summary>Returns a uint hash code of a double3x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double3x2 v)
        {
            return csum(fold_to_uint(v.c0) * uint3(0xEE390C97u, 0x9C8A2F05u, 0x4DDC6509u) + 
                        fold_to_uint(v.c1) * uint3(0x7CF083CBu, 0x5C4D6CEDu, 0xF9137117u)) + 0xE857DCE1u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a double3x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hashwide(double3x2 v)
        {
            return (fold_to_uint(v.c0) * uint3(0xF62213C5u, 0x9CDAA959u, 0xAA269ABFu) + 
                    fold_to_uint(v.c1) * uint3(0xD54BA36Fu, 0xFD0847B9u, 0x8189A683u)) + 0xB139D651u;
        }

    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 