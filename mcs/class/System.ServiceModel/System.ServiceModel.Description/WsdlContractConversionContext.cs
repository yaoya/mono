//
// WsdlContractConversionContext.cs
//
// Author:
//	Atsushi Enomoto <atsushi@ximian.com>
//	Ankit Jain <jankit@novell.com>
//
// Copyright (C) 2005 Novell, Inc.  http://www.novell.com
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
using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.Web.Services.Description;
using System.Xml;

namespace System.ServiceModel.Description
{
	[MonoTODO]
	public class WsdlContractConversionContext
	{
		ContractDescription contract;
		PortType port_type;

		internal WsdlContractConversionContext (ContractDescription contract, PortType portType)
		{
			this.contract = contract;
			this.port_type = portType;
		}

		public ContractDescription Contract {
			get { return contract; }
		}

		public PortType WsdlPortType {
			get { return port_type; }
		}

		public MessageDescription GetMessageDescription (
			OperationMessage operationMessage)
		{
			throw new NotImplementedException ();
		}

		public Operation GetOperation (OperationDescription operation)
		{
			throw new NotImplementedException ();
		}

		public OperationDescription GetOperationDescription (
			Operation operation)
		{
			throw new NotImplementedException ();
		}

		public OperationMessage GetOperationMessage (
			MessageDescription message)
		{
			throw new NotImplementedException ();
		}
	}
}
