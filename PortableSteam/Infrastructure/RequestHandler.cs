﻿namespace PortableSteam.Infrastructure
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    public sealed class RequestHandler
    {
        /// <summary>
        /// Send GET request.
        /// </summary>
        /// <param name="uri">Address of the endpoint.</param>
        /// <returns>Response string.</returns>
        public static string Request(Uri uri)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    return client.GetStringAsync(uri).Result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Send GET request asynchronously.
        /// </summary>
        /// <param name="uri">Address of the endpoint.</param>
        /// <returns>Response string.</returns>
        public static async Task<string> RequestAsync(Uri uri)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    return await client.GetStringAsync(uri);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
