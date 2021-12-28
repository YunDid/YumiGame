                 v.c1 * uint2(0xA895B9CDu, 0x9D23B201u) + 
                        v.c2 * uint2(0x4B01D3E1u, 0x7461CA0Du)) + 0x79725379u;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a uint2x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(uint2x3 v)
        {
            return (v.c0 * uint2(0xD6258E5Bu, 0xEE390C97u) + 
                    v.c1 * uint2(0x9C8A2F05u, 0x4DDC6509u) + 
                    v.c2 * uint2(0x7CF083CBu, 0x5C4D6CEDu)) + 0xF9137117u;
        }

    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        