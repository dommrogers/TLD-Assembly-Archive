using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class PlatformHelper
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetCurrentPlatformSuffix()
	{
		return null;
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
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
