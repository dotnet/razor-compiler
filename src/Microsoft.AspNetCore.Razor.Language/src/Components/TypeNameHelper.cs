// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Razor.Language;
internal class TypeNameHelper
{
    private static readonly string[] PredefinedTypeNames = new[] {"bool",
        "int",
        "uint",
        "nint",
        "byte",
        "char",
        "long",
        "ulong",
        "short",
        "nuint",
        "sbyte",
        "float",
        "object",
        "ushort",
        "double",
        "decimal"
    };

    public static string GloballyQualifiedTypeName(string typeName)
    {
        if (typeName == null)
        {
            throw new ArgumentNullException(nameof(typeName));
        }

        // Fast path, if the length doesn't fall within that of the
        // builtin c# types, then we can add global without further checks.
        if (typeName.Length < 3 || typeName.Length > 7)
        {
            return $"global::{typeName}";
        }

        for (var i = 0; i < PredefinedTypeNames.Length; i++)
        {
            if (string.Equals(typeName, PredefinedTypeNames[i], StringComparison.Ordinal))
            {
                return typeName;
            }
        }

        return $"global::{typeName}";
    }
}
