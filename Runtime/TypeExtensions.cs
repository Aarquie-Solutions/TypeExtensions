using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AarquieSolutions.TypeExtensions
{
    public static class TypeExtensions
    {
        public static object GetDefaultValue(this Type type)
        {
            if (type.IsValueType)
            {
                return Activator.CreateInstance(type);
            }
            else
            {
                return null;
            }
        }
    }
}
