﻿using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.Serialization;

#if NET_CORE
using System.Reflection;
#endif

namespace BitFlyer.Apis
{
    internal static class EnumExtensions
    {
        private static readonly ConcurrentDictionary<Enum, string> EnumMemberCache = new ConcurrentDictionary<Enum, string>();

        internal static string GetEnumMemberValue(this Enum value)
        {
            string returnValue;
            if (EnumMemberCache.TryGetValue(value, out returnValue))
            {
                return returnValue;
            }

#if NET_CORE
            var attributes = value.GetType().GetTypeInfo().GetField(value.ToString()).GetCustomAttributes<EnumMemberAttribute>(false);
#else
            var attributes = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(EnumMemberAttribute), false) as EnumMemberAttribute[];
#endif

            returnValue = attributes?.FirstOrDefault()?.Value;
            if (returnValue != null)
            {
                EnumMemberCache.TryAdd(value, returnValue);
            }

            return returnValue;
        }
    }
}
