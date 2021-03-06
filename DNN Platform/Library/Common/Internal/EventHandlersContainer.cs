﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

using DotNetNuke.ComponentModel;
using DotNetNuke.ExtensionPoints;
using DotNetNuke.Instrumentation;
// ReSharper disable ConvertPropertyToExpressionBody

namespace DotNetNuke.Common.Internal
{
    internal class EventHandlersContainer<T> : ComponentBase<IEventHandlersContainer<T>, EventHandlersContainer<T>>, IEventHandlersContainer<T>        
    {
        private static readonly ILog Logger = LoggerSource.Instance.GetLogger(typeof(EventHandlersContainer<T>));

        [ImportMany]
        private IEnumerable<Lazy<T>> _eventHandlers = new List<Lazy<T>>();

        public EventHandlersContainer()
        {
            try
            {
                if (GetCurrentStatus() != Globals.UpgradeStatus.None)
                {
                    return;
                }
                ExtensionPointManager.ComposeParts(this);             
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
        }

        public IEnumerable<Lazy<T>> EventHandlers
        {
            get
            {
                return _eventHandlers;
            }
        }

        private Globals.UpgradeStatus GetCurrentStatus()
        {
            try
            {
                return Globals.Status;
            }
            catch (NullReferenceException)
            {
                return Globals.UpgradeStatus.Unknown;
            }
        }
    }
}
