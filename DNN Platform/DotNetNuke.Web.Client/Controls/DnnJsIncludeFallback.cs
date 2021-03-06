﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

using System.Web.UI;
using System.Web.UI.WebControls;


namespace DotNetNuke.Web.Client.ClientResourceManagement
{
    /// <summary>
    ///     Emit a fallback block for a script in the same part of the page
    /// </summary>
    public class DnnJsIncludeFallback : WebControl
    {

        public DnnJsIncludeFallback(string objectName, string fileName)
        {
            ObjectName = objectName;
            FileName = fileName;
        }

        public string ObjectName { get; set; }
        public string FileName { get; set; }


        public override void RenderControl(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Type, "text/javascript");
            writer.RenderBeginTag(HtmlTextWriterTag.Script);

            if (ObjectName.Contains("."))
            {
                //generate function check
                writer.Write("if (typeof " + ObjectName + " != 'function') {");
            }
            else
            {
                //generate object check
                writer.Write("if (typeof " + ObjectName + " == 'undefined') {");
            }

            writer.Write("document.write('<script src=\"" + FileName + "\" type=\"text/javascript\"></' + 'script>');");
            writer.Write("}");
            writer.RenderEndTag();
        }
    }
}
