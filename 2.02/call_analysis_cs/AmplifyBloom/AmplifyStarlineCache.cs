using System;
using Cpp2ILInjected.CallAnalysis;

namespace AmplifyBloom;

[Serializable]
public class AmplifyStarlineCache
{
	internal AmplifyPassCache[] Passes;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(AmplifyGlareCache), Member = ".ctor")]
	[CallsUnknownMethods(Count = 13)]
	public AmplifyStarlineCache()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void Destroy()
	{
	}
}
