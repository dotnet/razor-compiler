﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.AspNetCore.Razor.Language.Syntax;

internal static class SyntaxListBuilderExtensions
{
    public static SyntaxList<SyntaxNode> ToList(this SyntaxListBuilder builder)
    {
        if (builder == null || builder.Count == 0)
        {
            return default(SyntaxList<SyntaxNode>);
        }

        return new SyntaxList<SyntaxNode>(builder.ToListNode().CreateRed());
    }

    public static SyntaxList<TNode> ToList<TNode>(this SyntaxListBuilder builder)
        where TNode : SyntaxNode
    {
        if (builder == null || builder.Count == 0)
        {
            return new SyntaxList<TNode>();
        }

        return new SyntaxList<TNode>(builder.ToListNode().CreateRed());
    }
}
