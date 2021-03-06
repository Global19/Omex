﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Microsoft.Omex.Gating
{
	/// <summary>
	/// Release plan as a derivative of GatesAny.
	/// </summary>
	public class ReleasePlan : GatesAny
	{
		/// <summary>
		/// Constructor for ReleasePlan, intializes GatesAny with release gates of a release plan.
		/// </summary>
		/// <param name="gate">Gates</param>
		public ReleasePlan(IGate gate)
			: base(gate?.ReleasePlan ?? new IGate[] { })
		{
		}
	}
}