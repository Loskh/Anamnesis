﻿// © Anamnesis.
// Licensed under the MIT license.

namespace Anamnesis
{
	using System;

	public static class VersionInfo
	{
		/// <summary>
		/// The time this version was published.
		/// </summary>
		// TODO: This should get filled in by a build server.
		public static readonly DateTime Date = new DateTime(2021, 08, 11, 23, 30, 00);

		/// <summary>
		/// The latest gamve version that the tool has been validated for.
		/// </summary>
		public static readonly string ValidatedGameVersion = "2021.07.31.0000.0000";
	}
}
