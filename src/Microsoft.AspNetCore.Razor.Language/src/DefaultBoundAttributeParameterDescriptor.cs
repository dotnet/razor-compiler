// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using MessagePack;

namespace Microsoft.AspNetCore.Razor.Language;

[MessagePackObject]
public class DefaultBoundAttributeParameterDescriptor : BoundAttributeParameterDescriptor
{
    [SerializationConstructor]
    public DefaultBoundAttributeParameterDescriptor(
        string kind,
        string name,
        string typeName,
        bool isEnum,
        string documentation,
        string displayName,
        bool caseSensitive,
        IReadOnlyDictionary<string, string> metadata,
        IReadOnlyList<RazorDiagnostic> diagnostics)
        : base(kind)
    {
        Name = name;
        TypeName = typeName;
        IsEnum = isEnum;
        Documentation = documentation;
        DisplayName = displayName;
        CaseSensitive = caseSensitive;

        Metadata = metadata;
        Diagnostics = diagnostics;

        IsStringProperty = typeName == typeof(string).FullName || typeName == "string";
        IsBooleanProperty = typeName == typeof(bool).FullName || typeName == "bool";
    }
}
