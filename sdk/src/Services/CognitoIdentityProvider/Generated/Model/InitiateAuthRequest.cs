/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the InitiateAuth operation.
    /// Initiates the authentication flow.
    /// </summary>
    public partial class InitiateAuthRequest : AmazonCognitoIdentityProviderRequest
    {
        private AuthFlowType _authFlow;
        private Dictionary<string, string> _authParameters = new Dictionary<string, string>();
        private string _clientId;
        private Dictionary<string, string> _clientMetadata = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AuthFlow. 
        /// <para>
        /// The authentication flow for this call to execute. The API action will depend on this
        /// value. For example: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REFRESH_TOKEN_AUTH</code> will take in a valid refresh token and return new
        /// tokens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>USER_SRP_AUTH</code> will take in <code>USERNAME</code> and <code>SRP_A</code>
        /// and return the SRP variables to be used for next challenge execution.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>USER_SRP_AUTH</code>: Authentication flow for the Secure Remote Password (SRP)
        /// protocol.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REFRESH_TOKEN_AUTH</code>/<code>REFRESH_TOKEN</code>: Authentication flow for
        /// refreshing the access token and ID token by supplying a valid refresh token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CUSTOM_AUTH</code>: Custom authentication flow.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>ADMIN_NO_SRP_AUTH</code> is not a valid value.
        /// </para>
        /// </summary>
        public AuthFlowType AuthFlow
        {
            get { return this._authFlow; }
            set { this._authFlow = value; }
        }

        // Check to see if AuthFlow property is set
        internal bool IsSetAuthFlow()
        {
            return this._authFlow != null;
        }

        /// <summary>
        /// Gets and sets the property AuthParameters. 
        /// <para>
        /// The authentication parameters. These are inputs corresponding to the <code>AuthFlow</code>
        /// that you are invoking. The required values depend on the value of <code>AuthFlow</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <code>USER_SRP_AUTH</code>: <code>USERNAME</code> (required), <code>SRP_A</code>
        /// (required), <code>SECRET_HASH</code> (required if the app client is configured with
        /// a client secret), <code>DEVICE_KEY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>REFRESH_TOKEN_AUTH/REFRESH_TOKEN</code>: <code>USERNAME</code> (required),
        /// <code>SECRET_HASH</code> (required if the app client is configured with a client secret),
        /// <code>REFRESH_TOKEN</code> (required), <code>DEVICE_KEY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>CUSTOM_AUTH</code>: <code>USERNAME</code> (required), <code>SECRET_HASH</code>
        /// (if app client is configured with client secret), <code>DEVICE_KEY</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> AuthParameters
        {
            get { return this._authParameters; }
            set { this._authParameters = value; }
        }

        // Check to see if AuthParameters property is set
        internal bool IsSetAuthParameters()
        {
            return this._authParameters != null && this._authParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The app client ID.
        /// </para>
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientMetadata. 
        /// <para>
        /// This is a random key-value pair map which can contain any key and will be passed to
        /// your PreAuthentication Lambda trigger as-is. It can be used to implement additional
        /// validations around authentication.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ClientMetadata
        {
            get { return this._clientMetadata; }
            set { this._clientMetadata = value; }
        }

        // Check to see if ClientMetadata property is set
        internal bool IsSetClientMetadata()
        {
            return this._clientMetadata != null && this._clientMetadata.Count > 0; 
        }

    }
}