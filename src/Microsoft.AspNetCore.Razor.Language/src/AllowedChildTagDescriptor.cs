// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using MessagePack;

namespace Microsoft.AspNetCore.Razor.Language;

[MessagePackObject]
[Union(0, typeof(DefaultAllowedChildTagDescriptor))]
public abstract class AllowedChildTagDescriptor : IEquatable<AllowedChildTagDescriptor>
{
    [Key(0)]
    public string Name { get; protected set; }

    [Key(1)]
    public string DisplayName { get; protected set; }

    [Key(2)]
    public IReadOnlyList<RazorDiagnostic> Diagnostics { get; protected set; }

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

    public bool Equals(AllowedChildTagDescriptor other)
    {
        return AllowedChildTagDescriptorComparer.Default.Equals(this, other);
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as AllowedChildTagDescriptor);
    }

    public override int GetHashCode()
    {
        return AllowedChildTagDescriptorComparer.Default.GetHashCode(this);
    }
}
