 {
            ulong sx = ((ulong)NextState() << 20) ^ NextState();
            return asdouble(0x3ff0000000000000 | sx) - 1.0;
        }

        /// <summary>Returns a uniformly random double2 value with all components in the interval [0, 1).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2 NextDouble2()
        {
            ulong sx = ((ulong)NextState() << 20) ^ NextState();
            ulong sy = ((ulong)NextState() << 20) ^ NextState();
            return double2(asdouble(0x3ff0000000000000 | sx),
                           asdouble(0x3ff0000000000000 | sy)) - 1.0;
        }

        /// <summary>Returns a uniformly random double3 value with all components in the interval [0, 1).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3 NextDouble3()
        {
            ulong sx = ((ulong)NextState() << 20) ^ NextState();
            ulong sy = ((ulong)NextState() << 20) ^ NextState();
            ulong sz = ((ulong)NextState() << 20) ^ NextState();
            return double3(asdouble(0x3ff0000000000000 | sx),
                           asdouble(0x3ff0000000000000 | sy),
                           asdouble(0x3ff0000000000000 | sz)) - 1.0;
        }

        /// <summary>Returns a uniformly random double4 value with all components in the interval [0, 1).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4 NextDouble4()
        {
            ulong sx = ((ulong)NextState() << 20) ^ NextState();
            ulong sy = ((ulong)NextState() << 20) ^ NextState();
            ulong sz = ((ulong)NextState() << 20) ^ NextState();
            ulong sw = ((ulong)NextState() << 20) ^ NextState();
            return double4(asdouble(0x3ff0000000000000 | sx),
                           asdouble(0x3ff0000000000000 | sy),
                           asdouble(0x3ff0000000000000 | sz),
                           asdouble(0x3ff0000000000000 | sw)) - 1.0;
        }


        /// <summary>Returns a uniformly random double value in the interval [0, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double NextDouble(double max) { return NextDouble() * max; }

        /// <summary>Returns a uniformly random double2 value with all components in the interval [0, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2 NextDouble2(double2 max) { return NextDouble2() * max; }

        /// <summary>Returns a uniformly random double3 value with all components in the interval [0, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3 NextDouble3(double3 max) { return NextDouble3() * max; }

        /// <summary>Returns a uniformly random double4 value with all 