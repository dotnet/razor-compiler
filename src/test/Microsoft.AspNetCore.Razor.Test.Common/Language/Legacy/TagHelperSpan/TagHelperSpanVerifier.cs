// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable disable

using Roslyn.Test.Utilities;

namespace Microsoft.AspNetCore.Razor.Language.Legacy;

internal class TagHelperSpanVerifier
{
    internal static void Verify(RazorSyntaxTree syntaxTree, string baseline)
    {
        var actual = TagHelperSpanSerializer.Serialize(syntaxTree);
        AssertEx.AssertEqualToleratingWhitespaceDifferences(baseline, actual);
    }
}
