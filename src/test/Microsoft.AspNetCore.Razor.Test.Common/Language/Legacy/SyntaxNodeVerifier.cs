// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable disable

using Microsoft.AspNetCore.Razor.Language.Syntax;
using Roslyn.Test.Utilities;

namespace Microsoft.AspNetCore.Razor.Language.Legacy;

public static class SyntaxNodeVerifier
{
    internal static void Verify(SyntaxNode node, string baseline)
    {
        var actual = SyntaxNodeSerializer.Serialize(node);
        AssertEx.AssertEqualToleratingWhitespaceDifferences(baseline, actual);
    }
}
