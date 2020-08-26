﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Microsoft.Omex.Extensions.Hosting.Services.Web.Middlewares
{
	internal interface ISaltProvider : IDisposable
	{
		Span<byte> GetSalt();
	}
}
