//
// X509CertificateRecipientClientCredential_mobile.cs
//
// Author:
//   Alexander Köplinger (alexander.koeplinger@xamarin.com)
//
// (C) 2016 Xamarin, Inc.
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#if MOBILE || XAMMAC_4_5

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace System.ServiceModel.Security
{
	public sealed class X509CertificateRecipientClientCredential
	{
		[MonoTODO]
		public X509ServiceCertificateAuthentication Authentication
		{
			get
			{
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public X509Certificate2 DefaultCertificate
		{
			get
			{
				throw new NotImplementedException ();
			}
			set
			{
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public Dictionary<Uri, X509Certificate2> ScopedCertificates
		{
			get
			{
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public X509ServiceCertificateAuthentication SslCertificateAuthentication
		{
			get
			{
				throw new NotImplementedException ();
			}
			set
			{
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		internal X509CertificateRecipientClientCredential ()
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public void SetDefaultCertificate(StoreLocation storeLocation, StoreName storeName, X509FindType findType, object findValue)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public void SetDefaultCertificate(string subjectName, StoreLocation storeLocation, StoreName storeName)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public void SetScopedCertificate(StoreLocation storeLocation, StoreName storeName, X509FindType findType, object findValue, Uri targetService)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public void SetScopedCertificate(string subjectName, StoreLocation storeLocation, StoreName storeName, Uri targetService)
		{
			throw new NotImplementedException ();
		}
	}
}

#endif