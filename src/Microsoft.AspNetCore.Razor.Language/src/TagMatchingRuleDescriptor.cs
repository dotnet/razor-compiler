// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using MessagePack;

namespace Microsoft.AspNetCore.Razor.Language;

[MessagePackObject]
[Union(0, typeof(DefaultTagMatchingRuleDescriptor))]
public abstract class TagMatchingRuleDescriptor : IEquatable<TagMatchingRuleDescriptor>
{
    private int? _hashCode;
    private IEnumerable<RazorDiagnostic> _allDiagnostics;

    [Key(0)]
    public string TagName { get; protected set; }

    [Key(1)]
    public string ParentTag { get; protected set; }

    [Key(2)]
    public TagStructure TagStructure { get; protected set; }

    [Key(3)]
    public bool CaseSensitive { get; protected set; }

    [Key(4)]
    public IReadOnlyList<RequiredAttributeDescriptor> Attributes { get; protected set; }

    [Key(5)]
    public IReadOnlyList<RazorDiagnostic> Diagnostics { get; protected set; }

    [IgnoreMember]
    public bool HasErrors
    {
        get
        {
            var allDiagnostics = GetAllDiagnostics();
            var errors = allDiagnostics.Any(diagnostic => diagnostic.Severity == RazorDiagnosticSeverity.Error);

            return errors;
        }
    }

    public virtual IEnumerable<RazorDiagnostic> GetAllDiagnostics()
    {
        if (_allDiagnostics == null)
        {
            var attributeDiagnostics = Attributes.SelectMany(attribute => attribute.Diagnostics);
            var combinedDiagnostics = Diagnostics.Concat(attributeDiagnostics);
            _allDiagnostics = combinedDiagnostics.ToArray();
        }

        return _allDiagnostics;
    }

    public bool Equals(TagMatchingRuleDescriptor other)
    {
        return TagMatchingRuleDescriptorComparer.Default.Equals(this, other);
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as TagMatchingRuleDescriptor);
    }

    public override int GetHashCode()
    {
        _hashCode ??= TagMatchingRuleDescriptorComparer.Default.GetHashCode(this);
        return _hashCode.Value;
    }
}
