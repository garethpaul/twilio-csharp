using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Preview.Proxy.Service.Session 
{

    /// <summary>
    /// Fetch a specific Participant.
    /// </summary>
    public class FetchParticipantOptions : IOptions<ParticipantResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Participant.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchParticipantOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Participant. </param>
        public FetchParticipantOptions(string pathServiceSid, string pathSessionSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
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
    /// Retrieve a list of all Participants in this Session.
    /// </summary>
    public class ReadParticipantOptions : ReadOptions<ParticipantResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// The Participant's contact identifier, normally a phone number.
        /// </summary>
        public string Identifier { get; set; }
        /// <summary>
        /// The Type of this Participant
        /// </summary>
        public ParticipantResource.ParticipantTypeEnum ParticipantType { get; set; }

        /// <summary>
        /// Construct a new ReadParticipantOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        public ReadParticipantOptions(string pathServiceSid, string pathSessionSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identifier != null)
            {
                p.Add(new KeyValuePair<string, string>("Identifier", Identifier));
            }

            if (ParticipantType != null)
            {
                p.Add(new KeyValuePair<string, string>("ParticipantType", ParticipantType.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Create a new Participant in this Session.
    /// </summary>
    public class CreateParticipantOptions : IOptions<ParticipantResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// The Participant's contact identifier, normally a phone number.
        /// </summary>
        public string Identifier { get; }
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The Type of this Participant
        /// </summary>
        public ParticipantResource.ParticipantTypeEnum ParticipantType { get; set; }

        /// <summary>
        /// Construct a new CreateParticipantOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="identifier"> The Participant's contact identifier, normally a phone number. </param>
        public CreateParticipantOptions(string pathServiceSid, string pathSessionSid, string identifier)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            Identifier = identifier;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identifier != null)
            {
                p.Add(new KeyValuePair<string, string>("Identifier", Identifier));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (ParticipantType != null)
            {
                p.Add(new KeyValuePair<string, string>("ParticipantType", ParticipantType.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete a specific Participant.
    /// </summary>
    public class DeleteParticipantOptions : IOptions<ParticipantResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Participant.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteParticipantOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Participant. </param>
        public DeleteParticipantOptions(string pathServiceSid, string pathSessionSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
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
    /// Update an s access to a specific Sync List.
    /// </summary>
    public class UpdateParticipantOptions : IOptions<ParticipantResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Participant.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The Type of this Participant
        /// </summary>
        public ParticipantResource.ParticipantTypeEnum ParticipantType { get; set; }
        /// <summary>
        /// The Participant's contact identifier, normally a phone number.
        /// </summary>
        public string Identifier { get; set; }
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new UpdateParticipantOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Participant. </param>
        public UpdateParticipantOptions(string pathServiceSid, string pathSessionSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (ParticipantType != null)
            {
                p.Add(new KeyValuePair<string, string>("ParticipantType", ParticipantType.ToString()));
            }

            if (Identifier != null)
            {
                p.Add(new KeyValuePair<string, string>("Identifier", Identifier));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

}