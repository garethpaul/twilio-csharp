/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.Wireless 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// ReadRatePlanOptions
    /// </summary>
    public class ReadRatePlanOptions : ReadOptions<RatePlanResource> 
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchRatePlanOptions
    /// </summary>
    public class FetchRatePlanOptions : IOptions<RatePlanResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchRatePlanOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public FetchRatePlanOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// CreateRatePlanOptions
    /// </summary>
    public class CreateRatePlanOptions : IOptions<RatePlanResource> 
    {
        /// <summary>
        /// The unique_name
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The data_enabled
        /// </summary>
        public bool? DataEnabled { get; set; }
        /// <summary>
        /// The data_limit
        /// </summary>
        public int? DataLimit { get; set; }
        /// <summary>
        /// The data_metering
        /// </summary>
        public string DataMetering { get; set; }
        /// <summary>
        /// The messaging_enabled
        /// </summary>
        public bool? MessagingEnabled { get; set; }
        /// <summary>
        /// The voice_enabled
        /// </summary>
        public bool? VoiceEnabled { get; set; }
        /// <summary>
        /// The commands_enabled
        /// </summary>
        public bool? CommandsEnabled { get; set; }
        /// <summary>
        /// The national_roaming_enabled
        /// </summary>
        public bool? NationalRoamingEnabled { get; set; }
        /// <summary>
        /// The international_roaming
        /// </summary>
        public List<string> InternationalRoaming { get; set; }

        /// <summary>
        /// Construct a new CreateRatePlanOptions
        /// </summary>
        public CreateRatePlanOptions()
        {
            InternationalRoaming = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (DataEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("DataEnabled", DataEnabled.Value.ToString().ToLower()));
            }

            if (DataLimit != null)
            {
                p.Add(new KeyValuePair<string, string>("DataLimit", DataLimit.ToString()));
            }

            if (DataMetering != null)
            {
                p.Add(new KeyValuePair<string, string>("DataMetering", DataMetering));
            }

            if (MessagingEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingEnabled", MessagingEnabled.Value.ToString().ToLower()));
            }

            if (VoiceEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceEnabled", VoiceEnabled.Value.ToString().ToLower()));
            }

            if (CommandsEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandsEnabled", CommandsEnabled.Value.ToString().ToLower()));
            }

            if (NationalRoamingEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("NationalRoamingEnabled", NationalRoamingEnabled.Value.ToString().ToLower()));
            }

            if (InternationalRoaming != null)
            {
                p.AddRange(InternationalRoaming.Select(prop => new KeyValuePair<string, string>("InternationalRoaming", prop)));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// UpdateRatePlanOptions
    /// </summary>
    public class UpdateRatePlanOptions : IOptions<RatePlanResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The unique_name
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new UpdateRatePlanOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public UpdateRatePlanOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// DeleteRatePlanOptions
    /// </summary>
    public class DeleteRatePlanOptions : IOptions<RatePlanResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteRatePlanOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public DeleteRatePlanOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}