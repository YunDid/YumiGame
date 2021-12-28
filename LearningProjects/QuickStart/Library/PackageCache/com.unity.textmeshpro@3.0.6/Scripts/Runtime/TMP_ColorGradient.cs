max)
        {
            CheckNextUIntMinMax(min.x, max.x);
            CheckNextUIntMinMax(min.y, max.y);
            CheckNextUIntMinMax(min.z, max.z);
            CheckNextUIntMinMax(min.w, max.w);
            uint4 range = (uint4)(max - min);
            return uint4((uint)(NextState() * (ulong)range.x >> 32),
                         (uint)(NextState() * (ulong)range.y >> 32),
                         (uint)(NextState() * (ulong)range.z >> 32),
                         (uint)(NextState() * (ulong)range.w >> 32)) + min;
        }

        /// <summary>Returns a uniformly random float value in the interval [0, 1).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float NextFloat()
        {
            return asfloat(0x3f800000 | (NextState() >> 9)) - 1.0f;
        }

        /// <summary>Returns a uniformly random float2 value with all components in the interval [0, 1).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2 NextFloat2()
        {
            return asfloat(0x3f800000 | (uint2(NextState(), NextState()) >> 9)) - 1.0f;
        }

        /// <summary>Returns a uniformly random float3 value with all components in the interval [0, 1).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 NextFloat3()
        {
            return asfloat(0x3f800000 | (uint3(NextState(), NextState(), NextState()) >> 9)) - 1.0f;
        }

        /// <summary>Returns a uniformly random float4 value with all components in the interval [0, 1).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4 NextFloat4()
        {
            return asfloat(0x3f800000 | (uint4(NextState(), NextState(), NextState(), NextState()) >> 9)) - 1.0f;
        }


        /// <summary>Returns a uniformly random float value in the interval [0, max).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float NextFloat(float max) { return NextFloat() * max; }

        /// <summary>Returns a uniformly rando