// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using MessagePack;

namespace Microsoft.AspNetCore.Razor.Language;

/// <summary>
/// A metadata class describing a tag helper attribute.
/// </summary>
[MessagePackObject]
[Union(0, typeof(DefaultBoundAttributeDescriptor))]
public abstract class BoundAttributeDescriptor : IEquatable<BoundAttributeDescriptor>
{
    protected BoundAttributeDescriptor(string kind)
    {
        Kind = kind;
    }

    [Key(0)]
    public string Kind { get; }

    [Key(1)]
    public string Name { get; protected set; }

    [Key(2)]
    public string TypeName { get; protected set; }

    [Key(3)]
    public bool IsEnum { get; protected set; }

    [Key(4)]
    public bool HasIndexer { get; protected set; }

    [Key(5)]
    public string IndexerNamePrefix { get; protected set; }

    [Key(6)]
    public string IndexerTypeName { get; protected set; }

    [Key(7)]
    public string Documentation { get; protected set; }

    [Key(8)]
    public string DisplayName { get; protected set; }

    [Key(9)]
    public bool CaseSensitive { get; protected set; }

    [Key(10)]
    public virtual IReadOnlyList<BoundAttributeParameterDescriptor> BoundAttributeParameters { get; protected set; }

    [Key(11)]
    public IReadOnlyDictionary<string, string> Metadata { get; protected set; }

    [Key(12)]
    public IReadOnlyList<RazorDiagnostic> Diagnostics { get; protected set; }

    [IgnoreMember]
    public bool IsIndexerStringProperty { get; protected set; }

    [IgnoreMember]
    public bool IsIndexerBooleanProperty { get; protected set; }

    [IgnoreMember]
    public bool IsStringProperty { get; protected set; }

    [IgnoreMember]
    public bool IsBooleanProperty { get; protected set; }

    [IgnoreMember]
    internal bool IsEditorRequired { get; set; }

    [IgnoreMember]
    public bool HasErrors
    {
        get
        {
            var errors = Diagnostics.Any(diagnostic => diagnostic.Severity == RazorDiagnosticSeverity.Error);

            return errors;
        }
    }

    public override string ToString()
    {
        return DisplayName ?? base.ToString();
    }

    public bool Equals(BoundAttributeDescriptor other)
    {
        return BoundAttributeDescriptorComparer.Default.Equals(this, other);
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as BoundAttributeDescriptor);
    }

    public override int GetHashCode()
    {
        return BoundAttributeDescriptorComparer.Default.GetHashCode(this);
    }
}
