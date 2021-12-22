// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using MessagePack;

namespace Microsoft.AspNetCore.Razor.Language;

[MessagePackObject]
public sealed class DefaultBoundAttributeDescriptor : BoundAttributeDescriptor
{
    [SerializationConstructor]
    public DefaultBoundAttributeDescriptor(
        string kind,
        string name,
        string typeName,
        bool isEnum,
        bool hasIndexer,
        string indexerNamePrefix,
        string indexerTypeName,
        string documentation,
        string displayName,
        bool caseSensitive,
        IReadOnlyList<BoundAttributeParameterDescriptor> parameterDescriptors,
        IReadOnlyDictionary<string, string> metadata,
        IReadOnlyList<RazorDiagnostic> diagnostics)
        : base(kind)
    {
        Name = name;
        TypeName = typeName;
        IsEnum = isEnum;
        HasIndexer = hasIndexer;
        IndexerNamePrefix = indexerNamePrefix;
        IndexerTypeName = indexerTypeName;
        Documentation = documentation;
        DisplayName = displayName;
        CaseSensitive = caseSensitive;
        BoundAttributeParameters = parameterDescriptors;

        Metadata = metadata;
        Diagnostics = diagnostics;

        IsIndexerStringProperty = indexerTypeName == typeof(string).FullName || indexerTypeName == "string";
        IsStringProperty = typeName == typeof(string).FullName || typeName == "string";

        IsIndexerBooleanProperty = indexerTypeName == typeof(bool).FullName || indexerTypeName == "bool";
        IsBooleanProperty = typeName == typeof(bool).FullName || typeName == "bool";
    }
}
