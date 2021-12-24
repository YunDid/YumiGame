    CheckNextIntMax(max.y);
            return int2((int)(NextState() * (ulong)max.x >> 32),
                        (int)(NextState() * (ulong)max.y >> 32));
        }

        /// <summary>Returns a uniformly random int3 value with all components in the interval [0, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3 NextInt3(int3 max)
        {
            CheckNextIntMax(max.x);
            CheckNextIntMax(max.y);
            CheckNextIntMax(max.z);
            return int3((int)(NextState() * (ulong)max.x >> 32),
                        (int)(NextState() * (ulong)max.y >> 32),
                        (int)(NextState() * (ulong)max.z >> 32));
        }

        /// <summary>Returns a uniformly random int4 value with all components in the interval [0, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4 NextInt4(int4 max)
        {
            CheckNextIntMax(max.x);
            CheckNextIntMax(max.y);
            CheckNextIntMax(max.z);
            CheckNextIntMax(max.w);
            return int4((int)(NextState() * (ulong)max.x >> 32),
                        (int)(NextState() * (ulong)max.y >> 32),
                        (int)(NextState() * (ulong)max.z >> 32),
                        (int)(NextState() * (ulong)max.w >> 32));
        }

        /// <summary>Returns a uniformly random int value in the interval [min, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int NextInt(int min, int max)
        {
            CheckNextIntMinMax(min, max);
            uint range = (uint)(max - min);
            return (int)(NextState() * (ulong)range >> 32) + min;
        }

        /// <summary>Returns a uniformly random int2 value with all components in the interval [min, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2 NextInt2(int2 min, int2 max)
        {
            CheckNextIntMinMax(min.x, max.x);
            CheckNextIntMinMax(min.y, max.y);
            uint2 range = (uint2)(max - min);
            return int2((int)(NextState() * (ulong)range.x >> 32),
                        (int)(NextState() * (ulong)range.y >> 32)) + min;
        }

        /// <summary>Returns a uniformly random int3 value with all components in the interval [min, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3 NextInt3(int3 min, int3 max)
        {
            CheckNextIntMinMax(min.x, max.x);
            CheckNextIntMinMax(min.y, max.y);
            CheckNextIntMinMax(min.z, max.z);
            uint3 range = (uint3)(max - min);
            return int3((int)(NextState() * (ulong)range.x >> 32),
                        (int)(NextState() * (ulong)range.y >> 32),
                        (int)(NextState() * (ulong)range.z >> 32)) + min;
        }

        /// <summary>Returns a uniformly random int4 value with all components in the interval [min, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4 NextInt4(int4 min, int4 max)
        {
            CheckNextIntMinMax(min.x, max.x);
            CheckNextIntMinMax(min.y, max.y);
            CheckNextIntMinMax(min.z, max.z);
            CheckNextIntMinMax(min.w, max.w);
            uint4 range = (uint4)(max - min);
            return int4((int)(NextState() * (ulong)range.x >> 32),
                        (int)(NextState() * (ulong)range.y >> 32),
                        (int)(NextState() * (ulong)range.z >> 32),
                        (int)(NextState() * (ulong)range.w >> 32)) + min;
        }

        /// <summary>Returns a uniformly random uint value in the interval [0, 4294967294].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint NextUInt()
        {
            return NextState() - 1u;
        }

        /// <summary>Returns a uniformly random uint2 value with all components in the interval [0, 4294967294].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2 NextUInt2()
        {
            return uint2(NextState(), NextState()) - 1u;
        }

        /// <summary>Returns a uniformly random uint3 value with all components in the interval [0, 4294967294].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3 NextUInt3()
        {
            return uint3(NextState(), NextState(), NextState()) - 1u;
        }

        /// <summary>Returns a uniformly random uint4 value with all components in the interval [0, 4294967294].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4 NextUInt4()
        {
            return uint4(NextState(), NextState(), NextState(), NextState()) - 1u;
        }


        /// <summary>Returns a uniformly random uint value in the interval [0, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint NextUInt(uint max)
        {
            return (uint)((NextState() * (ulong)max) >> 32);
        }

        /// <summary>Returns a uniformly random uint2 value with all components in the interval [0, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2 NextUInt2(uint2 max)
        {
            return uint2(   (uint)(NextState() * (ulong)max.x >> 32),
                            (uint)(NextState() * (ulong)max.y >> 32));
        }

        /// <summary>Returns a uniformly random uint3 value with all components in the interval [0, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3 NextUInt3(uint3 max)
        {
            return uint3(   (uint)(NextState() * (ulong)max.x >> 32),
                            (uint)(NextState() * (ulong)max.y >> 32),
                            (uint)(NextState() * (ulong)max.z >> 32));
        }

        /// <summary>Returns a uniformly random uint4 value with all components in the interval [0, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4 NextUInt4(uint4 max)
        {
            return uint4(   (uint)(NextState() * (ulong)max.x >> 32),
                    