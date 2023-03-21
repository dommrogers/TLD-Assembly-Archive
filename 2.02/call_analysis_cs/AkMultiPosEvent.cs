using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class AkMultiPosEvent
{
	public bool eventIsPlaying;

	public List<AkAmbient> list;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void FinishedPlaying(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CalledBy(Type = typeof(AkAmbient), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkMultiPosEvent()
	{
	}
}
