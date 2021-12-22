// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using MessagePack;

namespace Microsoft.AspNetCore.Razor.Language;

[MessagePackObject]
[Union(0, typeof(DefaultBoundAttributeParameterDescriptor))]
public abstract class BoundAttributeParameterDescriptor : IEquatable<BoundAttributeParameterDescriptor>
{
    protected BoundAttributeParameterDescriptor(string kind)
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
    public string Documentation { get; protected set; }

    [Key(5)]
    public string DisplayName { get; protected set; }

    [Key(6)]
    public bool CaseSensitive { get; protected set; }

    [Key(7)]
    public IReadOnlyDictionary<string, string> Metadata { get; protected set; }

    [Key(8)]
    public IReadOnlyList<RazorDiagnostic> Diagnostics { get; protected set; }

    [IgnoreMember]
    public bool IsStringProperty { get; protected set; }

    [IgnoreMember]
    public bool IsBooleanProperty { get; protected set; }

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

    public bool Equals(BoundAttributeParameterDescriptor other)
    {
        return BoundAttributeParameterDescriptorComparer.Default.Equals(this, other);
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as BoundAttributeParameterDescriptor);
    }

    public override int GetHashCode()
    {
        return BoundAttributeParameterDescriptorComparer.Default.GetHashCode(this);
    }
}
