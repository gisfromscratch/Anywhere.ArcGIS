﻿using System.Runtime.Serialization;

namespace Anywhere.ArcGIS.Operation
{
    public static class Operations
    {
        public const string Query = "query";
        public const string QueryAttachments = "queryAttachments";
        public const string QueryDomains = "queryDomains";
        public const string Find = "find";
        public const string ApplyEdits = "applyEdits";
        public const string DeleteAttachments = "deleteAttachments";
        public const string DeleteFeatures = "deleteFeatures";
        public const string CreateReplica = "createReplica";
        public const string UnregisterReplica = "unRegisterReplica";
        public const string SingleInputGeocode = "find";
        public const string SingleInputCustomGeocode = "findAddressCandidates";
        public const string SuggestGeocode = "suggest";
        public const string ReverseGeocode = "reverseGeocode";
        public const string GenerateToken = "generateToken";
        public const string Simplify = "simplify";
        public const string Buffer = "buffer";
        public const string Project = "project";
        public const string PublicKey = "publicKey";
        public const string ServiceStatus = "services/{0}.{1}/status";
        public const string StartService = "services/{0}.{1}/start";
        public const string StopService = "services/{0}.{1}/stop";
        public const string ServiceReport = "services/{0}/report";
        public const string ArcGISOnlineSearch = "search";
        public const string ServerInfoRoute = "rest/info";
    }

    /// <summary>
    /// There are four parameters common to all API operations unless otherwise noted.
    /// </summary>
    [DataContract]
    public abstract class CommonParameters
    {
        protected CommonParameters(string format = "json", Token token = null)
        {
            Format = format;
            if (token != null)
            {
                Token = token.Value;
            }
        }

        /// <summary>
        /// The output format can either be html, json, or pjson
        /// </summary>
        [DataMember(Name = "f")]
        public string Format { get; set; }

        /// <summary>
        /// Generated by the generateToken call, an access token that identifies the authenticated user and controls access to restricted resources and operations.
        /// </summary>
        [DataMember(Name = "token")]
        public string Token { get; set; }

        /// <summary>
        /// Callback is used for JavaScript clients who need a response.
        /// </summary>
        [DataMember(Name = "callback")]
        public string Callback { get; set; }

        /// <summary>
        /// Callback.html wraps the response in html tags for the JavaScript client.
        /// </summary>
        [DataMember(Name = "callback.html")]
        public string CallbackHtml { get; set; }
    }
}
