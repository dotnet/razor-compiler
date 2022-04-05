﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable disable

namespace Microsoft.AspNetCore.Razor.Language;

public abstract class RazorSourceLineCollection
{
    public abstract int Count { get; }

    public abstract int GetLineLength(int index);

    internal abstract SourceLocation GetLocation(int position);
}
