 result of rotating a vector by a unit quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 rotate(quaternion q, float3 v)
        {
            float3 t = 2 * cross(q.value.xyz, v);
            return v + q.value.w * t + cross(q.value.xyz, t);
        }

        /// <summary>Returns the result of a normalized linear interpolation between two quaternions q1 and a2 using an interpolation parameter t.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion nlerp(quaternion q1, quaternion q2, float t)
        {
            float dt = dot(q1, q2);
            if(dt < 0.0f)
            {
                q2.value = -q2.value;
            }

            return normalize(quaternion(lerp(q1.value, q2.value, t)));
        }

        /// <summary>Returns the result of a spherical interpolation between two quaternions q1 and a2 using an interpolation parameter t.