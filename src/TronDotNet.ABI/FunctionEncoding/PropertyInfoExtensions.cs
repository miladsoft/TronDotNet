﻿using System;
using System.Reflection;

namespace TronDotNet.ABI.FunctionEncoding
{
    public static class PropertyInfoExtensions
    {
#if DOTNET35
        public static bool IsHidingMember(this PropertyInfo self)
        {
            Type baseType = self.DeclaringType.GetTypeInfo().BaseType;
            PropertyInfo baseProperty = baseType.GetProperty(self.Name);

            if (baseProperty == null)
            {
                return false;
            }

            if (baseProperty.DeclaringType == self.DeclaringType)
            {
                return false;
            }

            var baseMethodDefinition = baseProperty.GetGetMethod().GetBaseDefinition();
            var thisMethodDefinition = self.GetGetMethod().GetBaseDefinition();


            return baseMethodDefinition.DeclaringType != thisMethodDefinition.DeclaringType;
        }
#else
        public static bool IsHidingMember(this PropertyInfo self)
        {
            Type baseType = self.DeclaringType.GetTypeInfo().BaseType;
            PropertyInfo baseProperty = baseType.GetRuntimeProperty(self.Name);

            if (baseProperty == null)
            {
                return false;
            }

            if (baseProperty.DeclaringType == self.DeclaringType)
            {
                return false;
            }

            var baseMethodDefinition = baseProperty.GetMethod.GetRuntimeBaseDefinition();
            var thisMethodDefinition = self.GetMethod.GetRuntimeBaseDefinition();

            return baseMethodDefinition.DeclaringType != thisMethodDefinition.DeclaringType;
        }
#endif
    }
 }

   