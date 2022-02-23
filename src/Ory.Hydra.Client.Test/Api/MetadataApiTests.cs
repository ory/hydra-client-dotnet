/*
 * Ory Oathkeeper API
 *
 * Documentation for all of Ory Oathkeeper's APIs. 
 *
 * The version of the OpenAPI document: v1.11.7
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
    ///  Class for testing MetadataApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MetadataApiTests : IDisposable
    {
        private MetadataApi instance;

        public MetadataApiTests()
        {
            instance = new MetadataApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MetadataApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MetadataApi
            //Assert.IsType<MetadataApi>(instance);
        }

        /// <summary>
        /// Test GetVersion
        /// </summary>
        [Fact]
        public void GetVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetVersion();
            //Assert.IsType<HydraInlineResponse2001>(response);
        }

        /// <summary>
        /// Test IsAlive
        /// </summary>
        [Fact]
        public void IsAliveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.IsAlive();
            //Assert.IsType<HydraInlineResponse200>(response);
        }

        /// <summary>
        /// Test IsReady
        /// </summary>
        [Fact]
        public void IsReadyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.IsReady();
            //Assert.IsType<HydraInlineResponse200>(response);
        }
    }
}
