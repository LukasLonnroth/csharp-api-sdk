﻿using Fortnox.SDK;
using Fortnox.SDK.Connectors;
using Fortnox.SDK.Entities;
using Fortnox.SDK.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FortnoxSDK.Tests
{
    [TestClass]
    public class TestErrorScenarios
    {
        [TestInitialize]
        public void Init()
        {
            //Set global credentials for SDK
            //--- Open 'TestCredentials.resx' to edit the values ---\\
            ConnectionCredentials.AccessToken = TestCredentials.Access_Token;
            ConnectionCredentials.ClientSecret = TestCredentials.Client_Secret;
        }

        [TestMethod]
        [ExpectedException(typeof(FortnoxApiException))]
        public void Test_FailedCreate_NoEntity()
        {
            var connector = new CustomerConnector();

            var createdCustomer = connector.Create(new Customer() {Name = "TestCustomer", CountryCode = "InvalidCountryCode"});
            Assert.IsNull(createdCustomer);
        }

        [TestMethod]
        [ExpectedException(typeof(FortnoxApiException))]
        public void Test_FailedUpdate_NoEntity()
        {
            var connector = new CustomerConnector();

            var createdCustomer = connector.Update(new Customer() { Name = "TestCustomer", CustomerNumber = "NotExistingCustomerNumber"});
            Assert.IsNull(createdCustomer);
        }
    }
}
