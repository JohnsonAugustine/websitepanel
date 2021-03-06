// Copyright (c) 2011, SMB SAAS Systems Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  SMB SAAS Systems Inc.  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;

namespace WebsitePanel.Setup.Web
{
	/// <summary>
	/// Summary description for ServerBinding.
	/// </summary>
	[Serializable]
	public sealed class ServerBinding
	{
		private string ip;
		private string port;
		private string host;

		/// <summary>
		/// Initializes a new instance of the class.
		/// </summary>
		public ServerBinding()
		{
		}

		/// <summary>
		/// Initializes a new instance of the class.
		/// </summary>
		/// <param name="ip">IP address.</param>
		/// <param name="port">TCP port.</param>
		/// <param name="host">Host header value.</param>
		public ServerBinding(string ip, string port, string host)
		{
			this.ip = ip;
			this.port = port;
			this.host = host;
		}

		/// <summary>
		/// IP address.
		/// </summary>
		public string IP
		{
			get { return ip; }
			set { ip = value; }
		}

		/// <summary>
		/// TCP port.
		/// </summary>
		public string Port
		{
			get { return port; }
			set { port = value; }
		}

		/// <summary>
		/// Host header value.
		/// </summary>
		public string Host
		{
			get { return host; }
			set { host = value; }
		}
	}
}
