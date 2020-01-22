/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Studio.V2.Flow;

namespace Twilio.Tests.Rest.Studio.V2.Flow
{

    [TestFixture]
    public class FlowRevisionTest : TwilioTest
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Studio,
                "/v2/Flows/FWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Revisions",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FlowRevisionResource.Read("FWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"previous_page_url\": null,\"next_page_url\": null,\"url\": \"https://studio.twilio.com/v2/Flows/FWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Revisions?PageSize=50&Page=0\",\"page\": 0,\"first_page_url\": \"https://studio.twilio.com/v2/Flows/FWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Revisions?PageSize=50&Page=0\",\"page_size\": 50,\"key\": \"revisions\"},\"revisions\": [{\"sid\": \"FWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"Test Flow\",\"status\": \"published\",\"revision\": 1,\"definition\": null,\"commit_message\": null,\"valid\": null,\"errors\": null,\"date_created\": \"2017-11-06T12:00:00Z\",\"date_updated\": \"2017-11-06T12:00:00Z\",\"url\": \"https://studio.twilio.com/v2/Flows/FWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Revisions/1\"}]}"
                                     ));

            var response = FlowRevisionResource.Read("FWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Studio,
                "/v2/Flows/FWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Revisions/revision",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FlowRevisionResource.Fetch("FWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "revision", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"FWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"definition\": {\"initial_state\": \"Trigger\"},\"friendly_name\": \"Test Flow\",\"status\": \"published\",\"revision\": 1,\"commit_message\": null,\"valid\": true,\"errors\": [],\"date_created\": \"2017-11-06T12:00:00Z\",\"date_updated\": null,\"url\": \"https://studio.twilio.com/v2/Flows/FWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Revisions/1\"}"
                                     ));

            var response = FlowRevisionResource.Fetch("FWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "revision", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}