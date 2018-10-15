/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NUnit.Framework;
using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;

namespace Twilio.Tests.TwiML 
{

    [TestFixture]
    public class PayTest : TwilioTest 
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Pay();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Pay></Pay>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new Pay(
                Pay.InputEnum.Dtmf,
                new Uri("https://example.com"),
                new Uri("https://example.com"),
                Pay.StatusCallbackMethodEnum.Get,
                1,
                1,
                true,
                "postal_code",
                "payment_connector",
                Pay.TokenTypeEnum.OneTime,
                "charge_amount",
                Pay.CurrencyEnum.Usd,
                "credential_sid",
                "description",
                Promoter.ListOfOne(Pay.ValidCardTypesEnum.Visa),
                Pay.LanguageEnum.DeDe
            );
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Pay input=\"dtmf\" action=\"https://example.com\" statusCallback=\"https://example.com\" statusCallbackMethod=\"GET\" timeout=\"1\" maxAttempts=\"1\" securityCode=\"true\" postalCode=\"postal_code\" paymentConnector=\"payment_connector\" tokenType=\"one-time\" chargeAmount=\"charge_amount\" currency=\"usd\" credentialSid=\"credential_sid\" description=\"description\" validCardTypes=\"visa\" language=\"de-DE\"></Pay>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Pay();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Pay newParam1=\"value\" newParam2=\"1\"></Pay>",
                elem.ToString()
            );
        }

        [Test]
        public void TestNestElement()
        {
            var elem = new Pay();
            var child = new Prompt();
            elem.Nest(child).Say();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Pay>" + Environment.NewLine +
                "  <Prompt>" + Environment.NewLine +
                "    <Say></Say>" + Environment.NewLine +
                "  </Prompt>" + Environment.NewLine +
                "</Pay>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithChildren()
        {
            var elem = new Pay();

            elem.Prompt(
                Prompt.ForEnum.PaymentCardNumber,
                Promoter.ListOfOne(Prompt.ErrorTypeEnum.Timeout),
                Promoter.ListOfOne(Prompt.CardTypeEnum.Visa),
                Promoter.ListOfOne(1)
            );

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Pay>" + Environment.NewLine +
                "  <Prompt for=\"payment-card-number\" errorType=\"timeout\" cardType=\"visa\" attempt=\"1\"></Prompt>" + Environment.NewLine +
                "</Pay>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new Pay();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Pay>Here is the content</Pay>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Pay();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Pay>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Pay>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildrenOfChildNodes()
        {
            var elem = new Pay();
            var child = new Prompt();
            elem.Nest(child).AddChild("generic-tag").SetOption("tag", true).AddText("Content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Pay>" + Environment.NewLine +
                "  <Prompt>" + Environment.NewLine +
                "    <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "  </Prompt>" + Environment.NewLine +
                "</Pay>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new Pay();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Pay>before<Child>content</Child>after</Pay>",
                elem.ToString()
            );
        }
    }

}