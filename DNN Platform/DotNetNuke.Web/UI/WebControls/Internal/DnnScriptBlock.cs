﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

using System.IO;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetNuke.Framework;

namespace DotNetNuke.Web.UI.WebControls.Internal
{
    ///<remarks>
    /// This control is only for internal use, please don't reference it in any other place as it may be removed in future.
    /// </remarks>
    public class DnnScriptBlock : Control
    {
        protected override void Render(HtmlTextWriter writer)
        {
            if (!DesignMode)
            {
                ScriptManager scriptManager = AJAX.GetScriptManager(Page);
                if (scriptManager.IsInAsyncPostBack)
                {
                    StringBuilder scriBuilder = new StringBuilder();
                    base.Render(new HtmlTextWriter(new StringWriter(scriBuilder)));
                    ScriptManager.RegisterClientScriptBlock(Page, typeof (Page), this.UniqueID, scriBuilder.ToString(),
                        false);
                }
                else
                {
                    base.Render(writer);
                }
            }
            else
            {
                base.Render(writer);
            }
        }
    }
}
