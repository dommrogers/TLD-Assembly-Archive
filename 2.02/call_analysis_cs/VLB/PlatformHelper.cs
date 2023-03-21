using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class PlatformHelper
{
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static string GetCurrentPlatformSuffix()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetPlatformSuffix(RuntimePlatform platform)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PlatformHelper()
	{
	}
}
