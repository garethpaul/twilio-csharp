/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    /// <summary>
    /// FetchTaskOptions
    /// </summary>
    public class FetchTaskOptions : IOptions<TaskResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchTaskOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchTaskOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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
    /// UpdateTaskOptions
    /// </summary>
    public class UpdateTaskOptions : IOptions<TaskResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The user-defined JSON data describing the custom attributes of this task.
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// A 'pending' or 'reserved' Task may be canceled by posting AssignmentStatus='canceled'.
        /// </summary>
        public TaskResource.StatusEnum AssignmentStatus { get; set; }
        /// <summary>
        /// This is only required if the Task is canceled or completed.
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// Override priority for the Task.
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// The task_channel
        /// </summary>
        public string TaskChannel { get; set; }

        /// <summary>
        /// Construct a new UpdateTaskOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateTaskOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (AssignmentStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentStatus", AssignmentStatus.ToString()));
            }

            if (Reason != null)
            {
                p.Add(new KeyValuePair<string, string>("Reason", Reason));
            }

            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteTaskOptions
    /// </summary>
    public class DeleteTaskOptions : IOptions<TaskResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteTaskOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteTaskOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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
    /// ReadTaskOptions
    /// </summary>
    public class ReadTaskOptions : ReadOptions<TaskResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// Retrieve the list of all Tasks in the workspace with the specified priority.
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// Returns the list of all Tasks in the workspace with the specified AssignmentStatus.
        /// </summary>
        public List<string> AssignmentStatus { get; set; }
        /// <summary>
        /// Returns the list of Tasks that are being controlled by the Workflow with the specified Sid value.
        /// </summary>
        public string WorkflowSid { get; set; }
        /// <summary>
        /// Returns the list of Tasks that are being controlled by the Workflow with the specified FriendlyName value.
        /// </summary>
        public string WorkflowName { get; set; }
        /// <summary>
        /// Returns the list of Tasks that are currently waiting in the TaskQueue identified by the Sid specified.
        /// </summary>
        public string TaskQueueSid { get; set; }
        /// <summary>
        /// Returns the list of Tasks that are currently waiting in the TaskQueue identified by the FriendlyName specified.
        /// </summary>
        public string TaskQueueName { get; set; }
        /// <summary>
        /// Provide a task attributes expression, and this will return tasks which match the attributes.
        /// </summary>
        public string EvaluateTaskAttributes { get; set; }
        /// <summary>
        /// Use this parameter to control the order of the Tasks returned.
        /// </summary>
        public string Ordering { get; set; }
        /// <summary>
        /// The has_addons
        /// </summary>
        public bool? HasAddons { get; set; }

        /// <summary>
        /// Construct a new ReadTaskOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        public ReadTaskOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            AssignmentStatus = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }

            if (AssignmentStatus != null)
            {
                p.AddRange(AssignmentStatus.Select(prop => new KeyValuePair<string, string>("AssignmentStatus", prop)));
            }

            if (WorkflowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkflowSid", WorkflowSid.ToString()));
            }

            if (WorkflowName != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkflowName", WorkflowName));
            }

            if (TaskQueueSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskQueueSid", TaskQueueSid.ToString()));
            }

            if (TaskQueueName != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskQueueName", TaskQueueName));
            }

            if (EvaluateTaskAttributes != null)
            {
                p.Add(new KeyValuePair<string, string>("EvaluateTaskAttributes", EvaluateTaskAttributes));
            }

            if (Ordering != null)
            {
                p.Add(new KeyValuePair<string, string>("Ordering", Ordering));
            }

            if (HasAddons != null)
            {
                p.Add(new KeyValuePair<string, string>("HasAddons", HasAddons.Value.ToString().ToLower()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateTaskOptions
    /// </summary>
    public class CreateTaskOptions : IOptions<TaskResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The amount of time in seconds the task is allowed to live up to a maximum of 2 weeks.
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// Override priority for the Task.
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// When MultiTasking is enabled specify the type of the task by passing either TaskChannel Unique Name or Task Channel Sid.
        /// </summary>
        public string TaskChannel { get; set; }
        /// <summary>
        /// The WorkflowSid for the Workflow that you would like to handle routing for this Task.
        /// </summary>
        public string WorkflowSid { get; set; }
        /// <summary>
        /// Url-encoded JSON string describing the attributes of this task.
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// Construct a new CreateTaskOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        public CreateTaskOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.ToString()));
            }

            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            if (WorkflowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkflowSid", WorkflowSid.ToString()));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            return p;
        }
    }

}