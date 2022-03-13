/* 
 * Eco Game API
 *
 * First API draft for Eco. Heavy work in progress and subject to changes.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using EcoServerAPI.Client;
using EcoServerAPI.Api;
using EcoServerAPI.Model;

namespace EcoServerAPI.Test
{
    /// <summary>
    ///  Class for testing PluginsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PluginsApiTests
    {
        private PluginsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PluginsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PluginsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PluginsApi
            //Assert.IsInstanceOfType(typeof(PluginsApi), instance, "instance is a PluginsApi");
        }

        
        /// <summary>
        /// Test PluginsGetPluginConfig
        /// </summary>
        [Test]
        public void PluginsGetPluginConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string authtoken = null;
            //string authtokentype = null;
            //instance.PluginsGetPluginConfig(name, authtoken, authtokentype);
            
        }
        
        /// <summary>
        /// Test PluginsGetPlugins
        /// </summary>
        [Test]
        public void PluginsGetPluginsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PluginsGetPlugins();
            //Assert.IsInstanceOf<List<EcoWebServerDataTransferObjectsPluginInfo>> (response, "response is List<EcoWebServerDataTransferObjectsPluginInfo>");
        }
        
        /// <summary>
        /// Test PluginsPostPluginConfig
        /// </summary>
        [Test]
        public void PluginsPostPluginConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string authtoken = null;
            //string authtokentype = null;
            //Object body = null;
            //instance.PluginsPostPluginConfig(name, authtoken, authtokentype, body);
            
        }
        
    }

}