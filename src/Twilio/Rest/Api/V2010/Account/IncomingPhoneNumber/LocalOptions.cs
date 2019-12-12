/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.IncomingPhoneNumber
{

    /// <summary>
    /// ReadLocalOptions
    /// </summary>
    public class ReadLocalOptions : ReadOptions<LocalResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to read
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Whether to include new phone numbers
        /// </summary>
        public bool? Beta { get; set; }
        /// <summary>
        /// A string that identifies the resources to read
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The phone numbers of the resources to read
        /// </summary>
        public Types.PhoneNumber PhoneNumber { get; set; }
        /// <summary>
        /// Include phone numbers based on their origin. By default, phone numbers of all origin are included.
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Beta != null)
            {
                p.Add(new KeyValuePair<string, string>("Beta", Beta.Value.ToString().ToLower()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (PhoneNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumber", PhoneNumber.ToString()));
            }

            if (Origin != null)
            {
                p.Add(new KeyValuePair<string, string>("Origin", Origin));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateLocalOptions
    /// </summary>
    public class CreateLocalOptions : IOptions<LocalResource>
    {
        /// <summary>
        /// The SID of the Account that will create the resource
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The phone number to purchase in E.164 format
        /// </summary>
        public Types.PhoneNumber PhoneNumber { get; }
        /// <summary>
        /// The API version to use for incoming calls made to the new phone number
        /// </summary>
        public string ApiVersion { get; set; }
        /// <summary>
        /// A string to describe the new phone number
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The SID of the application to handle SMS messages
        /// </summary>
        public string SmsApplicationSid { get; set; }
        /// <summary>
        /// The HTTP method we use to call status_callback
        /// </summary>
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; set; }
        /// <summary>
        /// The URL we call when an error occurs while executing TwiML
        /// </summary>
        public Uri SmsFallbackUrl { get; set; }
        /// <summary>
        /// The HTTP method to use with sms url
        /// </summary>
        public Twilio.Http.HttpMethod SmsMethod { get; set; }
        /// <summary>
        /// The URL we should call when the new phone number receives an incoming SMS message
        /// </summary>
        public Uri SmsUrl { get; set; }
        /// <summary>
        /// The URL we should call to send status information to your application
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// HTTP method we should use to call status_callback
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// The SID of the application to handle the new phone number
        /// </summary>
        public string VoiceApplicationSid { get; set; }
        /// <summary>
        /// Whether to lookup the caller's name
        /// </summary>
        public bool? VoiceCallerIdLookup { get; set; }
        /// <summary>
        /// The HTTP method used with voice_fallback_url
        /// </summary>
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }
        /// <summary>
        /// The URL we will call when an error occurs in TwiML
        /// </summary>
        public Uri VoiceFallbackUrl { get; set; }
        /// <summary>
        /// The HTTP method used with the voice_url
        /// </summary>
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }
        /// <summary>
        /// The URL we should call when the phone number receives a call
        /// </summary>
        public Uri VoiceUrl { get; set; }
        /// <summary>
        /// The SID of the Identity resource to associate with the new phone number
        /// </summary>
        public string IdentitySid { get; set; }
        /// <summary>
        /// The SID of the Address resource associated with the phone number
        /// </summary>
        public string AddressSid { get; set; }
        /// <summary>
        /// Status determining whether the new phone number is enabled for emergency calling
        /// </summary>
        public LocalResource.EmergencyStatusEnum EmergencyStatus { get; set; }
        /// <summary>
        /// The emergency address configuration to use for emergency calling
        /// </summary>
        public string EmergencyAddressSid { get; set; }
        /// <summary>
        /// SID of the trunk to handle calls to the new phone number
        /// </summary>
        public string TrunkSid { get; set; }
        /// <summary>
        /// Incoming call type: fax or voice
        /// </summary>
        public LocalResource.VoiceReceiveModeEnum VoiceReceiveMode { get; set; }
        /// <summary>
        /// The SID of the Bundle resource associated with number
        /// </summary>
        public string BundleSid { get; set; }

        /// <summary>
        /// Construct a new CreateLocalOptions
        /// </summary>
        /// <param name="phoneNumber"> The phone number to purchase in E.164 format </param>
        public CreateLocalOptions(Types.PhoneNumber phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PhoneNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumber", PhoneNumber.ToString()));
            }

            if (ApiVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("ApiVersion", ApiVersion));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (SmsApplicationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsApplicationSid", SmsApplicationSid.ToString()));
            }

            if (SmsFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackMethod", SmsFallbackMethod.ToString()));
            }

            if (SmsFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackUrl", Serializers.Url(SmsFallbackUrl)));
            }

            if (SmsMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsMethod", SmsMethod.ToString()));
            }

            if (SmsUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsUrl", Serializers.Url(SmsUrl)));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (VoiceApplicationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceApplicationSid", VoiceApplicationSid.ToString()));
            }

            if (VoiceCallerIdLookup != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceCallerIdLookup", VoiceCallerIdLookup.Value.ToString().ToLower()));
            }

            if (VoiceFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackMethod", VoiceFallbackMethod.ToString()));
            }

            if (VoiceFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackUrl", Serializers.Url(VoiceFallbackUrl)));
            }

            if (VoiceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceMethod", VoiceMethod.ToString()));
            }

            if (VoiceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceUrl", Serializers.Url(VoiceUrl)));
            }

            if (IdentitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("IdentitySid", IdentitySid.ToString()));
            }

            if (AddressSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressSid", AddressSid.ToString()));
            }

            if (EmergencyStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyStatus", EmergencyStatus.ToString()));
            }

            if (EmergencyAddressSid != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyAddressSid", EmergencyAddressSid.ToString()));
            }

            if (TrunkSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TrunkSid", TrunkSid.ToString()));
            }

            if (VoiceReceiveMode != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceReceiveMode", VoiceReceiveMode.ToString()));
            }

            if (BundleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("BundleSid", BundleSid.ToString()));
            }

            return p;
        }
    }

}