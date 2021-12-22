// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using MessagePack;

namespace Microsoft.AspNetCore.Razor.Language;

[MessagePackObject]
[Union(0, typeof(DefaultRequiredAttributeDescriptor))]
public abstract class RequiredAttributeDescriptor : IEquatable<RequiredAttributeDescriptor>
{
    [Key(0)]
    public string Name { get; protected set; }

    [Key(1)]
    public NameComparisonMode NameComparison { get; protected set; }

    [Key(2)]
    public bool CaseSensitive { get; protected set; }

    [Key(3)]
    public string Value { get; protected set; }

    [Key(4)]
    public ValueComparisonMode ValueComparison { get; protected set; }

    [Key(5)]
    public string DisplayName { get; protected set; }

    [Key(6)]
    public IReadOnlyDictionary<string, string> Metadata { get; protected set; }

    [Key(7)]
    public IReadOnlyList<RazorDiagnostic> Diagnostics { get; protected set; }

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

    public bool Equals(RequiredAttributeDescriptor other)
    {
        return RequiredAttributeDescriptorComparer.Default.Equals(this, other);
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as RequiredAttributeDescriptor);
    }

    public override int GetHashCode()
    {
        return RequiredAttributeDescriptorComparer.Default.GetHashCode(this);
    }

    /// <summary>
    /// Acceptable <see cref="RequiredAttributeDescriptor.Name"/> comparison modes.
    /// </summary>
    public enum NameComparisonMode
    {
        /// <summary>
        /// HTML attribute name case insensitively matches <see cref="RequiredAttributeDescriptor.Name"/>.
        /// </summary>
        FullMatch,

        /// <summary>
        /// HTML attribute name case insensitively starts with <see cref="RequiredAttributeDescriptor.Name"/>.
        /// </summary>
        PrefixMatch,
    }

    /// <summary>
    /// Acceptable <see cref="RequiredAttributeDescriptor.Value"/> comparison modes.
    /// </summary>
    public enum ValueComparisonMode
    {
        /// <summary>
        /// HTML attribute value always matches <see cref="RequiredAttributeDescriptor.Value"/>.
        /// </summary>
        None,

        /// <summary>
        /// HTML attribute value case sensitively matches <see cref="RequiredAttributeDescriptor.Value"/>.
        /// </summary>
        FullMatch,

        /// <summary>
        /// HTML attribute value case sensitively starts with <see cref="RequiredAttributeDescriptor.Value"/>.
        /// </summary>
        PrefixMatch,

        /// <summary>
        /// HTML attribute value case sensitively ends with <see cref="RequiredAttributeDescriptor.Value"/>.
        /// </summary>
        SuffixMatch,
    }
}
