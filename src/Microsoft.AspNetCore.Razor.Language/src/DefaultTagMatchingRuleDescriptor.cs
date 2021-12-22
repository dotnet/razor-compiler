// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using MessagePack;

namespace Microsoft.AspNetCore.Razor.Language;

[MessagePackObject]
public class DefaultTagMatchingRuleDescriptor : TagMatchingRuleDescriptor
{
    [SerializationConstructor]
    public DefaultTagMatchingRuleDescriptor(
        string tagName,
        string parentTag,
        TagStructure tagStructure,
        bool caseSensitive,
        IReadOnlyList<RequiredAttributeDescriptor> attributes,
        IReadOnlyList<RazorDiagnostic> diagnostics)
    {
        TagName = tagName;
        ParentTag = parentTag;
        TagStructure = tagStructure;
        CaseSensitive = caseSensitive;
        Attributes = attributes;
        Diagnostics = diagnostics;
    }
}
