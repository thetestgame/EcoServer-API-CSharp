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
    ///  Class for testing ElectionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ElectionApiTests
    {
        private ElectionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ElectionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ElectionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ElectionApi
            //Assert.IsInstanceOfType(typeof(ElectionApi), instance, "instance is a ElectionApi");
        }

        
        /// <summary>
        /// Test ElectionAddComment
        /// </summary>
        [Test]
        public void ElectionAddCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authtoken = null;
            //string authtokentype = null;
            //int? electionId = null;
            //EcoWebServerDataTransferObjectsElectionCommentDTO body = null;
            //instance.ElectionAddComment(authtoken, authtokentype, electionId, body);
            
        }
        
        /// <summary>
        /// Test ElectionFinishElection
        /// </summary>
        [Test]
        public void ElectionFinishElectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authtoken = null;
            //string authtokentype = null;
            //instance.ElectionFinishElection(authtoken, authtokentype);
            
        }
        
        /// <summary>
        /// Test ElectionForceElectionEnd
        /// </summary>
        [Test]
        public void ElectionForceElectionEndTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authtoken = null;
            //string authtokentype = null;
            //int? electionId = null;
            //instance.ElectionForceElectionEnd(authtoken, authtokentype, electionId);
            
        }
        
        /// <summary>
        /// Test ElectionGenerateTestData
        /// </summary>
        [Test]
        public void ElectionGenerateTestDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authtoken = null;
            //string authtokentype = null;
            //instance.ElectionGenerateTestData(authtoken, authtokentype);
            
        }
        
        /// <summary>
        /// Test ElectionGetComments
        /// </summary>
        [Test]
        public void ElectionGetCommentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authtoken = null;
            //string authtokentype = null;
            //int? electionId = null;
            //var response = instance.ElectionGetComments(authtoken, authtokentype, electionId);
            //Assert.IsInstanceOf<List<EcoWebServerDataTransferObjectsElectionCommentDTO>> (response, "response is List<EcoWebServerDataTransferObjectsElectionCommentDTO>");
        }
        
        /// <summary>
        /// Test ElectionGetElectedTitleById
        /// </summary>
        [Test]
        public void ElectionGetElectedTitleByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string authtoken = null;
            //string authtokentype = null;
            //instance.ElectionGetElectedTitleById(id, authtoken, authtokentype);
            
        }
        
        /// <summary>
        /// Test ElectionGetElectionById
        /// </summary>
        [Test]
        public void ElectionGetElectionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string authtoken = null;
            //string authtokentype = null;
            //instance.ElectionGetElectionById(id, authtoken, authtokentype);
            
        }
        
        /// <summary>
        /// Test ElectionListElectedTitles
        /// </summary>
        [Test]
        public void ElectionListElectedTitlesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authtoken = null;
            //string authtokentype = null;
            //Object state = null;
            //var response = instance.ElectionListElectedTitles(authtoken, authtokentype, state);
            //Assert.IsInstanceOf<List<EcoWebServerDataTransferObjectsElectedTitleDTO>> (response, "response is List<EcoWebServerDataTransferObjectsElectedTitleDTO>");
        }
        
        /// <summary>
        /// Test ElectionListElections
        /// </summary>
        [Test]
        public void ElectionListElectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authtoken = null;
            //string authtokentype = null;
            //bool? returnActive = null;
            //var response = instance.ElectionListElections(authtoken, authtokentype, returnActive);
            //Assert.IsInstanceOf<List<EcoWebServerDataTransferObjectsElectionDTO>> (response, "response is List<EcoWebServerDataTransferObjectsElectionDTO>");
        }
        
        /// <summary>
        /// Test ElectionVote
        /// </summary>
        [Test]
        public void ElectionVoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authtoken = null;
            //string authtokentype = null;
            //bool? forceVote = null;
            //EcoWebServerDataTransferObjectsRunoffVoteDTO body = null;
            //instance.ElectionVote(authtoken, authtokentype, forceVote, body);
            
        }
        
        /// <summary>
        /// Test ElectionVotes
        /// </summary>
        [Test]
        public void ElectionVotesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authtoken = null;
            //string authtokentype = null;
            //int? id = null;
            //var response = instance.ElectionVotes(authtoken, authtokentype, id);
            //Assert.IsInstanceOf<List<EcoWebServerDataTransferObjectsRunoffVoteDTO>> (response, "response is List<EcoWebServerDataTransferObjectsRunoffVoteDTO>");
        }
        
    }

}
