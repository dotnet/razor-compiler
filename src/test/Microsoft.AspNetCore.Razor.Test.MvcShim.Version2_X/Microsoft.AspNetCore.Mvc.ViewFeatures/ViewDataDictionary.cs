﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures;

public class ViewDataDictionary : IDictionary<string, object>
{
    #region IDictionary properties
    public object this[string index]
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    public int Count { get; }

    public bool IsReadOnly { get; }

    public ICollection<string> Keys { get; }

    public ICollection<object> Values { get; }
    #endregion

    #region IDictionary methods
    public void Add(string key, object value)
    {
    }

    public bool ContainsKey(string key)
    {
        throw new NotImplementedException();
    }

    public bool Remove(string key)
    {
        throw new NotImplementedException();
    }

    public bool TryGetValue(string key, out object value)
    {
        throw new NotImplementedException();
    }

    public void Add(KeyValuePair<string, object> item)
    {
    }

    public void Clear()
    {
    }

    public bool Contains(KeyValuePair<string, object> item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
    {
    }

    public bool Remove(KeyValuePair<string, object> item)
    {
        throw new NotImplementedException();
    }

    IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
    #endregion
}
