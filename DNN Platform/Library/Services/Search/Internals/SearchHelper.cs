﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

#region Usings

using System;

using DotNetNuke.Framework;

#endregion

namespace DotNetNuke.Services.Search.Internals
{
    /// <summary>
	/// Internal Search Controller. This is an Internal class and should not be used outside of Core
	/// </summary>
    public class SearchHelper : ServiceLocator<ISearchHelper, SearchHelper>
    {
        protected override Func<ISearchHelper> GetFactory()
        {
            return () => new SearchHelperImpl();
        }
    }
}
