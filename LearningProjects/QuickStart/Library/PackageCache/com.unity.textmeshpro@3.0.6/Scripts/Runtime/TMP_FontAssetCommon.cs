//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct uint2x2 : System.IEquatable<uint2x2>, IFormattable
    {
        public uint2 c0;
        public uint2 c1;

        /// <summary>uint2x2 identity transform.</summary>
        public static readonly uint2x2 identity = new uint2x2(1u, 0u,   0u, 1u);

        /// <summary>uint2x2 zero value.</summary>
        public static readonly uint2x2 zero;

        /// <summary>Constructs a uint2x2 matrix from two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(uint2 c0, uint2 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a uint2x2 matrix from 4 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(uint m00, uint m01,
                       uint m10, uint m11)
        { 
            this.c0 = new uint2(m00, m10);
            this.c1 = new uint2(m01, m11);
        }

        /// <summary>Constructs a uint2x2 matrix from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(uint v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a uint2x2 matrix from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(bool v)
        {
            this.c0 = math.select(new uint2(0u), new uint2(1u), v);
            this.c1 = math.select(new uint2(0u), new uint2(1u), v);
        }

        /// <summary>Constructs a uint2x2 matrix from a bool2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(bool2x2 v)
        {
            this.c0 = math.select(new uint2(0u), new uint2(1u), v.c0);
            this.c1 = math.select(new uint2(0u), new uint2(1u), v.c1);
        }

        /// <summary>Constructs a uint2x2 matrix from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(int v)
        {
            this.c0 = (uint2)v;
            this.c1 = (uint2)v;
        }

        /// <summary>Constructs a uint2x2 matrix from a int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(int2x2 v)
        {
            this.c0 = (uint2)v.c0;
            this.c1 = (uint2)v.c1;
        }

        /// <summary>Constructs a uint2x2 matrix from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(float v)
        {
            this.c0 = (uint2)v;
            this.c1 = (uint2)v;
        }

        /// <summary>Constructs a uint2x2 matrix from a float2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(float2x2 v)
        {
            this.c0 = (uint2)v.c0;
            this.c1 = (uint2)v.c1;
        }

        /// <summary>Constructs a uint2x2 matrix from a single double value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(double v)
        {
            this.c0 = (uint2)v;
            this.c1 = (uint2)v;
        }

        /// <summary>Constructs a uint2x2 matrix from a double2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(double2x2 v)
        {
            this.c0 = (uint2)v.c0;
            this.c1 = (uint2)v.c1;
        }


        /// <summary>Implicitly converts a single uint value to a uint2x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2x2(uint v) { return new uint2x2(v); }

        /// <summary>Explicitly converts a single bool value to a uint2x2 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(bool v) { return new uint2x2(v); }

        /// <summary>Explicitly converts a bool2x2 matrix to a uint2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(bool2x2 v) { return new uint2x2(v); }

        /// <summary>Explicitly converts a single int value to a uint2x2 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(int v) { return new uint2x2(v); }

        /// <summary>Explicitly converts a int2x2 matrix to a uint2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(int2x2 v) { return new uint2x2(v); }

        /// <summary>Explicitly converts a single float value to a uint2x2 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(float v) { return new uint2x2(v); }

        /// <summary>Explicitly converts a float2x2 matrix to a uint2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(float2x2 v) { return new uint2x2(v); }

        /// <summary>Explicitly converts a single double value to a uint2x2 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(double v) { return new uint2x2(v); }

        /// <summary>Explicitly converts a double2x2 matrix to a uint2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(double2x2 v) { return new uint2x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator * (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator * (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator * (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator + (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator + (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator + (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator - (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator - (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator - (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator / (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator / (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator / (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator % (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator % (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator % (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise increment operation on a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator ++ (uint2x2 val) { return new uint2x2 (++val.c0, ++val.c1); }


        /// <summary>Returns the result of a componentwise decrement operation on a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator -- (uint2x2 val) { return new uint2x2 (--val.c0, --val.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (uint2x2 lhs, uint2x2 rhs) { return new bool2x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (uint2x2 lhs, uint rhs) { return new bool2x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (uint lhs, uint2x2 rhs) { return new bool2x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (uint2x2 lhs, uint2x2 rhs) { return new bool2x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (uint2x2 lhs, uint rhs) { return new bool2x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (uint lhs, uint2x2 rhs) { return new bool2x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two uint2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (uint2x2 lhs, uint2x2 rhs) { return new bool2x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (uint2x2 lhs, uint rhs) { return new bool2x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a uint2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (uint lhs, uint2x2 rhs) { return new bool2x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns t