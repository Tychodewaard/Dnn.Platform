﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNuke.Web.UI.WebControls
{
    public class DnnFormPanel : WebControl 
    {

        public bool Expanded { get; set; }

        public string Text { get; set; }

        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, CssClass);
            writer.RenderBeginTag(HtmlTextWriterTag.H2);

            if (Expanded)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "dnnSectionExpanded");
            }
            writer.RenderBeginTag(HtmlTextWriterTag.A);
            writer.Write(Text);
            writer.RenderEndTag();

            writer.RenderEndTag();

            writer.RenderBeginTag(HtmlTextWriterTag.Fieldset);

            RenderChildren(writer);

            writer.RenderEndTag();
        }
    }
}
