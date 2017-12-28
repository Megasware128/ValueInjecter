﻿using System;
using System.Reflection;

namespace Omu.ValueInjecter
{
    internal static class InternalUtils
    {
#if NETSTANDARD1_6
    internal static PropertyInfo GetProperty(this Type type, string name)
        {
            return type.GetTypeInfo().GetProperty(name);
        }

        internal static MethodInfo GetMethod(this Type type, string name)
        {
            return type.GetTypeInfo().GetMethod(name);
        }

        internal static PropertyInfo[] GetProperties(this Type type, BindingFlags flags)
        {
            return type.GetTypeInfo().GetProperties(flags);
        }
        internal static Type[] GetInterfaces(this Type type)
        {
            return type.GetTypeInfo().GetInterfaces();
        }
#endif

        internal static bool IsInterface(this Type type)
        {
#if NETSTANDARD1_6
            return type.GetTypeInfo().IsInterface;
#else
            return type.IsInterface;
#endif
        }
    }
}
