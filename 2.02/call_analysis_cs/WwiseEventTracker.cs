using Cpp2ILInjected.CallAnalysis;

public class WwiseEventTracker
{
	public float currentDuration;

	public float currentDurationProportion;

	public bool eventIsPlaying;

	public bool fadeoutTriggered;

	public uint playingID;

	public float previousEventStartTime;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void CallbackHandler(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
	{
	}

	[CallerCount(Count = 0)]
	public WwiseEventTracker()
	{
	}
}
