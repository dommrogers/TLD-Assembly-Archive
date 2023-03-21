using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class PlatformHelper
{
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetCurrentPlatformSuffix()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	private static string GetPlatformSuffix(RuntimePlatform platform)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlatformHelper()
	{
	}
}
