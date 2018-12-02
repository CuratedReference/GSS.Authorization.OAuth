﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace GSS.Authorization.OAuth2
{
    public class AuthorizerOptions
    {
        [Required]
        public Uri AccessTokenEndpoint { get; set; }

        [Required]
        public string ClientId { get; set; }

        [Required]
        public string ClientSecret { get; set; }

        public IEnumerable<string> Scopes { get; set; }

        /// <summary>
        /// Resource Owner Credentials
        /// </summary>
        public NetworkCredential Credentials { get; set; }

        /// <summary>
        /// HttpClient request error handler
        /// </summary>
        public Action<HttpStatusCode, string> OnError { get; set; }
    }
}
