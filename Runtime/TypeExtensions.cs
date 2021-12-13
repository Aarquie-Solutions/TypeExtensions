using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AarquieSolutions.Extensions.Type
{
    public static class TypeExtensions
    {
        public static object GetDefaultValue(this System.Type type)
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
