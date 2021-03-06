﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

using System;
using PetaPoco;

namespace DotNetNuke.Data.PetaPoco
{
    [CLSCompliant(false)]
    public class FluentColumnMap
    {
        public ColumnInfo ColumnInfo { get; set; }
        public Func<object, object> FromDbConverter { get; set; }
        public Func<object, object> ToDbConverter { get; set; }

        public FluentColumnMap() { }
        public FluentColumnMap(ColumnInfo columnInfo) : this(columnInfo, null) { }
        public FluentColumnMap(ColumnInfo columnInfo, Func<object, object> fromDbConverter) : this(columnInfo, fromDbConverter, null) { }
        public FluentColumnMap(ColumnInfo columnInfo, Func<object, object> fromDbConverter, Func<object, object> toDbConverter)
        {
            ColumnInfo = columnInfo;
            FromDbConverter = fromDbConverter;
            ToDbConverter = toDbConverter;
        }
    }
}
