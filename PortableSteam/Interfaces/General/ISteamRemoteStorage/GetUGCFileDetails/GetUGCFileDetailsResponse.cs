﻿namespace PortableSteam.Interfaces.General.ISteamRemoteStorage
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using System.Collections.Generic;

    public class GetUGCFileDetailsResponse : ResponseBase
    {
        /// <summary>
        /// Array containing the file information.
        /// </summary>
        [JsonProperty("data")]
        public List<GetUGCFileDetailsResponseData> Data { get; set; }
        /// <summary>
        /// Object returned on non-HTTP errors.
        /// </summary>
        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetUGCFileDetailsResponseData
    {
        /// <summary>
        /// Path to the file along with its name.
        /// </summary>
        [JsonProperty("filename")]
        public string FileName { get; set; }
        /// <summary>
        /// URL to the file.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        /// <summary>
        /// Size of the file.
        /// </summary>
        [JsonProperty("size")]
        public double Size { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class Status
    {
        /// <summary>
        /// Integer identifying error that occurred, currently 9 is the only known return value which means that the file with the given ID was not found.
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }
    }
}
