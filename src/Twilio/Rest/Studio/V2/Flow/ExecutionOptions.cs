/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Studio.V2.Flow
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// ReadExecutionOptions
    /// </summary>
    public class ReadExecutionOptions : ReadOptions<ExecutionResource>
    {
        /// <summary>
        /// The flow_sid
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// The date_created_from
        /// </summary>
        public DateTime? DateCreatedFrom { get; set; }
        /// <summary>
        /// The date_created_to
        /// </summary>
        public DateTime? DateCreatedTo { get; set; }

        /// <summary>
        /// Construct a new ReadExecutionOptions
        /// </summary>
        /// <param name="pathFlowSid"> The flow_sid </param>
        public ReadExecutionOptions(string pathFlowSid)
        {
            PathFlowSid = pathFlowSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DateCreatedFrom != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedFrom", Serializers.DateTimeIso8601(DateCreatedFrom)));
            }

            if (DateCreatedTo != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedTo", Serializers.DateTimeIso8601(DateCreatedTo)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// FetchExecutionOptions
    /// </summary>
    public class FetchExecutionOptions : IOptions<ExecutionResource>
    {
        /// <summary>
        /// The flow_sid
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchExecutionOptions
        /// </summary>
        /// <param name="pathFlowSid"> The flow_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchExecutionOptions(string pathFlowSid, string pathSid)
        {
            PathFlowSid = pathFlowSid;
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// CreateExecutionOptions
    /// </summary>
    public class CreateExecutionOptions : IOptions<ExecutionResource>
    {
        /// <summary>
        /// The flow_sid
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// The to
        /// </summary>
        public Types.PhoneNumber To { get; }
        /// <summary>
        /// The from
        /// </summary>
        public Types.PhoneNumber From { get; }
        /// <summary>
        /// The parameters
        /// </summary>
        public object Parameters { get; set; }

        /// <summary>
        /// Construct a new CreateExecutionOptions
        /// </summary>
        /// <param name="pathFlowSid"> The flow_sid </param>
        /// <param name="to"> The to </param>
        /// <param name="from"> The from </param>
        public CreateExecutionOptions(string pathFlowSid, Types.PhoneNumber to, Types.PhoneNumber from)
        {
            PathFlowSid = pathFlowSid;
            To = to;
            From = from;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }

            if (Parameters != null)
            {
                p.Add(new KeyValuePair<string, string>("Parameters", Serializers.JsonObject(Parameters)));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// DeleteExecutionOptions
    /// </summary>
    public class DeleteExecutionOptions : IOptions<ExecutionResource>
    {
        /// <summary>
        /// The flow_sid
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteExecutionOptions
        /// </summary>
        /// <param name="pathFlowSid"> The flow_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteExecutionOptions(string pathFlowSid, string pathSid)
        {
            PathFlowSid = pathFlowSid;
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