/* 
 * Blockchain.com Exchange REST API
 *
 * ## Introduction Welcome to Blockchain.com's Exchange API and developer documentation. \\ These documents detail and give examples of various functionality offered by the API such as receiving real time market data, requesting balance information and performing trades. ## To Get Started Create or log into your existing Blockchain.com Exchange account \\ Select API from the drop down menu \\ Fill out form and click “Create New API Key Now” \\ Once generated you can view your keys under API Settings. \\ Please be aware that the API key can only be used once it was verified via email.  The API key must be set via the \\ `X-API-Token`\\ header.  The base URL to be used for all calls is \\ `https://api.blockchain.com/v3/exchange`  Autogenerated clients for this API can be found [here](https://github.com/blockchain/lib-exchange-client). 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.com.blockchain.exchange.rest.api;
using Org.OpenAPITools.com.blockchain.exchange.rest.model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing OrderSummary
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class OrderSummaryTests
    {
        // TODO uncomment below to declare an instance variable for OrderSummary
        //private OrderSummary instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of OrderSummary
            //instance = new OrderSummary();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderSummary
        /// </summary>
        [Test]
        public void OrderSummaryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" OrderSummary
            //Assert.IsInstanceOf(typeof(OrderSummary), instance);
        }


        /// <summary>
        /// Test the property 'ExOrdId'
        /// </summary>
        [Test]
        public void ExOrdIdTest()
        {
            // TODO unit test for the property 'ExOrdId'
        }
        /// <summary>
        /// Test the property 'ClOrdId'
        /// </summary>
        [Test]
        public void ClOrdIdTest()
        {
            // TODO unit test for the property 'ClOrdId'
        }
        /// <summary>
        /// Test the property 'OrdType'
        /// </summary>
        [Test]
        public void OrdTypeTest()
        {
            // TODO unit test for the property 'OrdType'
        }
        /// <summary>
        /// Test the property 'OrdStatus'
        /// </summary>
        [Test]
        public void OrdStatusTest()
        {
            // TODO unit test for the property 'OrdStatus'
        }
        /// <summary>
        /// Test the property 'Side'
        /// </summary>
        [Test]
        public void SideTest()
        {
            // TODO unit test for the property 'Side'
        }
        /// <summary>
        /// Test the property 'Price'
        /// </summary>
        [Test]
        public void PriceTest()
        {
            // TODO unit test for the property 'Price'
        }
        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Test]
        public void TextTest()
        {
            // TODO unit test for the property 'Text'
        }
        /// <summary>
        /// Test the property 'Symbol'
        /// </summary>
        [Test]
        public void SymbolTest()
        {
            // TODO unit test for the property 'Symbol'
        }
        /// <summary>
        /// Test the property 'LastShares'
        /// </summary>
        [Test]
        public void LastSharesTest()
        {
            // TODO unit test for the property 'LastShares'
        }
        /// <summary>
        /// Test the property 'LastPx'
        /// </summary>
        [Test]
        public void LastPxTest()
        {
            // TODO unit test for the property 'LastPx'
        }
        /// <summary>
        /// Test the property 'LeavesQty'
        /// </summary>
        [Test]
        public void LeavesQtyTest()
        {
            // TODO unit test for the property 'LeavesQty'
        }
        /// <summary>
        /// Test the property 'CumQty'
        /// </summary>
        [Test]
        public void CumQtyTest()
        {
            // TODO unit test for the property 'CumQty'
        }
        /// <summary>
        /// Test the property 'AvgPx'
        /// </summary>
        [Test]
        public void AvgPxTest()
        {
            // TODO unit test for the property 'AvgPx'
        }
        /// <summary>
        /// Test the property 'Timestamp'
        /// </summary>
        [Test]
        public void TimestampTest()
        {
            // TODO unit test for the property 'Timestamp'
        }

    }

}
