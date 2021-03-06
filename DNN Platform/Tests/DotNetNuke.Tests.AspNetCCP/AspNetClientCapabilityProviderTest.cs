﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

using System;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using DotNetNuke.ComponentModel;
using DotNetNuke.Providers.AspNetClientCapabilityProvider;
using DotNetNuke.Tests.Utilities.Mocks;

using NUnit.Framework;


namespace DotNetNuke.Tests.AspNetClientCapabilityProvider
{
    [TestFixture]
    public class AspNetClientCapabilityProviderTest
    {
        #region Private Variables
        private Providers.AspNetClientCapabilityProvider.AspNetClientCapabilityProvider _clientCapabilityProvider;

        #endregion

        #region UserAgent

        private const String iphoneUserAgent = "Mozilla/5.0 (iPod; U; CPU iPhone OS 4_0 like Mac OS X; en-us) AppleWebKit/532.9 (KHTML, like Gecko) Version/4.0.5 Mobile/8A293 Safari/6531.22.7";

        #endregion

        #region Setup & TearDown

        [SetUp]
        public void Setup()
        {
            _clientCapabilityProvider = new Providers.AspNetClientCapabilityProvider.AspNetClientCapabilityProvider();

			ComponentFactory.Container = new SimpleContainer();
			var dataProvider = MockComponentProvider.CreateDataProvider();
			dataProvider.Setup(d => d.GetProviderPath()).Returns("");
			MockComponentProvider.CreateDataCacheProvider();
			MockComponentProvider.CreateEventLogController();

            //create the bin folder
            var folderPath = HostingEnvironment.ApplicationPhysicalPath + "bin";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        [TearDown]
        public void TearDown()
        {

        }

        #endregion

        #region Testing Getting ClientCapabilities based on clientID

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void AspNetClientCapabilityProvider_GetClientCapabilityById_ThrowsException_For_Empty_ClientCapabilityId()
        {
            //Act
            string nullClientCapabilityId = String.Empty;         
            var clientCapabilitiesByNullId = _clientCapabilityProvider.GetClientCapabilityById(nullClientCapabilityId);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void AspNetClientCapabilityProvider_GetClientCapabilityById_ThrowsException_For_Null_ClientCapabilityId()
        {
            //Act
            string nullClientCapabilityId = null;
            var clientCapabilitiesByEmptyId = _clientCapabilityProvider.GetClientCapabilityById(nullClientCapabilityId);
        }

        #endregion
    }
}
