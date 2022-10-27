/*
 * Ory Hydra API
 *
 * Documentation for all of Ory Hydra's APIs. 
 *
 * The version of the OpenAPI document: v2.0.1
 * Contact: hi@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Ory.Hydra.Client.Client;
using Ory.Hydra.Client.Api;
// uncomment below to import models
//using Ory.Hydra.Client.Model;

namespace Ory.Hydra.Client.Test.Api
{
    /// <summary>
    ///  Class for testing WellknownApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WellknownApiTests : IDisposable
    {
        private WellknownApi instance;

        public WellknownApiTests()
        {
            instance = new WellknownApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WellknownApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WellknownApi
            //Assert.IsType<WellknownApi>(instance);
        }

        /// <summary>
        /// Test DiscoverJsonWebKeys
        /// </summary>
        [Fact]
        public void DiscoverJsonWebKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DiscoverJsonWebKeys();
            //Assert.IsType<HydraJsonWebKeySet>(response);
        }
    }
}
