﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

#region Usings

using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web;

#endregion

namespace DotNetNuke.UI.WebControls
{
    /// -----------------------------------------------------------------------------
    /// Project:    DotNetNuke
    /// Namespace:  DotNetNuke.UI.WebControls
    /// Class:      CaptchaHandler
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The CaptchaHandler control provides a validator to validate a CAPTCHA Challenge
    /// </summary>
    /// -----------------------------------------------------------------------------
    public class CaptchaHandler : IHttpHandler
    {
        private const int MAX_IMAGE_WIDTH = 600;
        private const int MAX_IMAGE_HEIGHT = 600;

        #region IHttpHandler Members

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            NameValueCollection queryString = context.Request.QueryString;
            string text = queryString[CaptchaControl.KEY];
            HttpResponse response = context.Response;
            Bitmap bmp = CaptchaControl.GenerateImage(text);
            if (bmp != null)
            {
                bmp.Save(response.OutputStream, ImageFormat.Jpeg);
            }
        }

        #endregion
    }
}
