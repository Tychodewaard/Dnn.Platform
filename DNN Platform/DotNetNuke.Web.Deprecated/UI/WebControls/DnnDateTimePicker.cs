﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

#region Usings

using System;
using System.Data.SqlTypes;

using Telerik.Web.UI;

#endregion

namespace DotNetNuke.Web.UI.WebControls
{
    public class DnnDateTimePicker : RadDateTimePicker
    {
		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);
			base.EnableEmbeddedBaseStylesheet = true;
			Utilities.ApplySkin(this, string.Empty, "DatePicker");
			this.Calendar.ClientEvents.OnLoad = "$.dnnRadPickerHack";
			var specialDay = new RadCalendarDay();
			specialDay.Repeatable = Telerik.Web.UI.Calendar.RecurringEvents.Today;
			specialDay.ItemStyle.CssClass = "dnnCalendarToday";
			this.Calendar.SpecialDays.Add(specialDay);
            this.Calendar.RangeMinDate = (DateTime)SqlDateTime.MinValue;
            this.Calendar.RangeMaxDate = (DateTime)SqlDateTime.MaxValue;
            this.MinDate = (DateTime)SqlDateTime.MinValue;
            this.MaxDate = (DateTime)SqlDateTime.MaxValue;
        }
    }
}
