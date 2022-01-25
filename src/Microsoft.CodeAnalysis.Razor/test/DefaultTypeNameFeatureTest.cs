// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.CodeAnalysis.CSharp;

namespace Microsoft.CodeAnalysis.Razor.Test;
public class DefaultTypeNameFeatureTest
{
    [Theory]
    [InlineData("Hello.World", true, "Hello", "World")]
    [InlineData("IEnumerable<Something.Else>", true, "", "IEnumerable<Something.Else>")]
    [InlineData("System.IEquatable<System.Int32>", true, "System", "IEquatable<System.Int32>")]
    [InlineData("Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.MouseEventArgs>", true, "Microsoft.AspNetCore.Components", "EventCallback<Microsoft.AspNetCore.Components.MouseEventArgs>")]
    public void CanParseTypeNames(string candidate, bool expectedResult, string expectedNamespace, string expectedTypeName)
    {
        var feature = new DefaultTypeNameFeature();

        var result = feature.TryParseTypeName(candidate, out var actualNamespace, out var actualTypeName);
        Assert.Equal(expectedResult, result);
        Assert.Equal(expectedNamespace, actualNamespace);
        Assert.Equal(expectedTypeName, actualTypeName);
    }
}
