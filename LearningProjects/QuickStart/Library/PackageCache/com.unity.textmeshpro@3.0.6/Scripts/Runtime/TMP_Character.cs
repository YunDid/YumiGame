using System;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;
using System.Diagnostics;

namespace Unity.Mathematics
{
    /// <summary>
    /// Random Number Generator based on xorshift.
    /// Designed for minimal state (32bits) to be easily embeddable into components.
    /// Core functionality is integer multiplication free to improve vectorization
    /// on less capable SIMD instruction sets.
    /// </summary>
    [Serializable]
    public partial struct Random
    {
        public uint state;

        /// <summary>
        /// Constructs a Random instance with a given seed value. The seed must be non-zero.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Random(uint seed)
        {
            state = seed;
            CheckInitState();
            NextState();
        }

        /// <summary>
        /// Initialized the state of the Random instance with a given seed value. The seed must be non-zero.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InitState(uint seed = 0x6E624EB7u)
        {
            state = seed;
            NextState();
        }

        /// <summary>Returns a uniformly random bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool NextBool()
        {
            return (NextState() & 1) == 1;
        }

        /// <summary>Returns a uniformly random bool2 value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2 NextBool2()
        {
            uint v = NextState();
            return (uint2(v) & uint2(1, 2)) == 0;
        }

        /// <summary>Returns a uniformly random bool3 value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3 NextBool3()
        {
            uint v = NextState();
            return (uint3(v) & uint3(1, 2, 4)) == 0;
        }

        /// <summary>Returns a uniformly random bool4 value.</summary>
        [MethodImpl(MethodI