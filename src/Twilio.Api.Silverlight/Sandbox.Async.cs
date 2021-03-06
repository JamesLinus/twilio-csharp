﻿using System;
using RestSharp;
using RestSharp.Extensions;
using RestSharp.Validation;

namespace Twilio
{
	public partial class TwilioRestClient
	{
		/// <summary>
		/// Returns the Sandbox resource associated with the account identified by {YourAccountSid}. Twilio accounts upgraded prior to February 2010 may not have a Sandbox resource, and in this case you will receive a 404 (Not Found) response.
		/// </summary>
		/// <param name="callback">Method to call upon successful completion</param>
        public virtual void GetSandbox(Action<Sandbox> callback)
		{
			var request = new RestRequest();
			request.Resource = "Accounts/{AccountSid}/Sandbox.json";

			ExecuteAsync<Sandbox>(request, callback);
		}

		/// <summary>
		/// Update the TwiML voice and SMS URLs associated with the sandbox number
		/// </summary>
		/// <param name="voiceUrl">The URL to use for incoming calls to your sandbox number.</param>
		/// <param name="voiceMethod">The HTTP method to use for incoming calls to your sandbox number.</param>
		/// <param name="smsUrl">The URL to use for incoming SMS text messages sent to your sandbox number.</param>
		/// <param name="smsMethod">The HTTP method to use for incoming text messages sent to your sandbox number.</param>
		/// <param name="callback">Method to call upon successful completion</param>
        public virtual void UpdateSandbox(string voiceUrl, string voiceMethod, string smsUrl, string smsMethod, Action<Sandbox> callback)
		{
			var request = new RestRequest(Method.POST);
			request.Resource = "Accounts/{AccountSid}/Sandbox.json";

			request.AddParameter("VoiceUrl", voiceUrl);
			request.AddParameter("VoiceMethod", voiceMethod);
			request.AddParameter("SmsUrl", smsUrl);
			request.AddParameter("SmsMethod", smsMethod);

			ExecuteAsync<Sandbox>(request, callback);
		}
	}
}