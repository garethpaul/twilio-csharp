/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.TrustedComms.Business
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Fetch a specific a Brand.
    /// </summary>
    public class FetchBrandOptions : IOptions<BrandResource>
    {
        /// <summary>
        /// Business Sid.
        /// </summary>
        public string PathBusinessSid { get; }
        /// <summary>
        /// Brand Sid.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchBrandOptions
        /// </summary>
        /// <param name="pathBusinessSid"> Business Sid. </param>
        /// <param name="pathSid"> Brand Sid. </param>
        public FetchBrandOptions(string pathBusinessSid, string pathSid)
        {
            PathBusinessSid = pathBusinessSid;
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