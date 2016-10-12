using Twilio.Base;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Rest.Api.V2010.Account {

    public class QueueUpdater : Updater<QueueResource> {
        private string accountSid;
        private string sid;
        private string friendlyName;
        private int? maxSize;
    
        /// <summary>
        /// Construct a new QueueUpdater.
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public QueueUpdater(string sid) {
            this.sid = sid;
        }
    
        /// <summary>
        /// Construct a new QueueUpdater
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="sid"> The sid </param>
        public QueueUpdater(string accountSid, string sid) {
            this.accountSid = accountSid;
            this.sid = sid;
        }
    
        /// <summary>
        /// A human readable description of the queue
        /// </summary>
        ///
        /// <param name="friendlyName"> A human readable description of the queue </param>
        /// <returns> this </returns> 
        public QueueUpdater setFriendlyName(string friendlyName) {
            this.friendlyName = friendlyName;
            return this;
        }
    
        /// <summary>
        /// The maximum number of members that can be in the queue at a time
        /// </summary>
        ///
        /// <param name="maxSize"> The max number of members allowed in the queue </param>
        /// <returns> this </returns> 
        public QueueUpdater setMaxSize(int? maxSize) {
            this.maxSize = maxSize;
            return this;
        }
    
        #if NET40
        /// <summary>
        /// Make the request to the Twilio API to perform the update
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Updated QueueResource </returns> 
        public override async Task<QueueResource> UpdateAsync(ITwilioRestClient client) {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.API,
                "/2010-04-01/Accounts/" + (accountSid ?? client.GetAccountSid()) + "/Queues/" + this.sid + ".json"
            );
            addPostParams(request);
            
            var response = await client.RequestAsync(request);
            if (response == null)
            {
                throw new ApiConnectionException("QueueResource update failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to update record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return QueueResource.FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Make the request to the Twilio API to perform the update
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Updated QueueResource </returns> 
        public override QueueResource Update(ITwilioRestClient client) {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.API,
                "/2010-04-01/Accounts/" + (accountSid ?? client.GetAccountSid()) + "/Queues/" + this.sid + ".json"
            );
            addPostParams(request);
            
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("QueueResource update failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to update record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return QueueResource.FromJson(response.Content);
        }
    
        /// <summary>
        /// Add the requested post parameters to the Request
        /// </summary>
        ///
        /// <param name="request"> Request to add post params to </param>
        private void addPostParams(Request request) {
            if (friendlyName != null) {
                request.AddPostParam("FriendlyName", friendlyName);
            }
            
            if (maxSize != null) {
                request.AddPostParam("MaxSize", maxSize.ToString());
            }
        }
    }
}