using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class AkMultiPosEvent
{
	public bool eventIsPlaying;

	public List<AkAmbient> list;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void FinishedPlaying(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CalledBy(Type = typeof(AkAmbient), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AkMultiPosEvent()
	{
	}
}
