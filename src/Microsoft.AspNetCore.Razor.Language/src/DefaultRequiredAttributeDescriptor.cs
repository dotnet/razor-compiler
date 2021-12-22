// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using MessagePack;

namespace Microsoft.AspNetCore.Razor.Language;

[MessagePackObject]
public class DefaultRequiredAttributeDescriptor : RequiredAttributeDescriptor
{
    [SerializationConstructor]
    public DefaultRequiredAttributeDescriptor(
        string name,
        NameComparisonMode nameComparison,
        bool caseSensitive,
        string value,
        ValueComparisonMode valueComparison,
        string displayName,
        IReadOnlyDictionary<string, string> metadata,
        IReadOnlyList<RazorDiagnostic> diagnostics)
    {
        Name = name;
        NameComparison = nameComparison;
        CaseSensitive = caseSensitive;
        Value = value;
        ValueComparison = valueComparison;
        DisplayName = displayName;
        Diagnostics = diagnostics;
        Metadata = metadata;
    }
}
