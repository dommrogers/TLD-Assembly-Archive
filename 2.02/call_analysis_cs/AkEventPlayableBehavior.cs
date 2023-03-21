using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class AkEventPlayableBehavior : PlayableBehaviour
{
	public enum AkPlayableAction
	{
		None = 0,
		Playback = 1,
		Retrigger = 2,
		Stop = 4,
		DelayedStop = 8,
		Seek = 0x10,
		FadeIn = 0x20,
		FadeOut = 0x40
	}

	public static int scrubPlaybackLengthMs;

	public AK.Wwise.Event akEvent;

	public float akEventMaxDuration;

	public float akEventMinDuration;

	public float blendInDuration;

	public float blendOutDuration;

	public float easeInDuration;

	public float easeOutDuration;

	public GameObject eventObject;

	public bool eventShouldRetrigger;

	public WwiseEventTracker eventTracker;

	public float lastEffectiveWeight;

	public bool overrideTrackEmittorObject;

	public AkPlayableAction requiredActions;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "ShouldPlay")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "fadeOutRequired")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "ShouldPlay")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "getProportionalTime")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "fadeOutRequired")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "stopEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "playEvent")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "retriggerEvent")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "stopEvent")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "seekToTime")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "triggerFadeIn")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "triggerFadeOut")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 0)]
	private bool actionIsRequired(AkPlayableAction actionType)
	{
		return false;
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "PrepareFrame")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "OnBehaviourPlay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldPlay(Playable playable)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private bool fadeInRequired(float currentClipTime)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private void checkForFadeIn(float currentClipTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "triggerFadeIn")]
	private void checkForFadeInImmediate(float currentClipTime)
	{
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "PrepareFrame")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "checkForFadeOutImmediate")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "checkForFadeOut")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool fadeOutRequired(Playable playable)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "fadeOutRequired")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "triggerFadeOut")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void checkForFadeOutImmediate(Playable playable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "fadeOutRequired")]
	private void checkForFadeOut(Playable playable)
	{
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "checkForFadeInImmediate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void triggerFadeIn(float currentClipTime)
	{
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "checkForFadeOutImmediate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void triggerFadeOut(float fadeDuration)
	{
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "OnBehaviourPause")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void stopEvent(int transition = 0)
	{
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	protected void playEvent()
	{
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "seekToTime")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	protected void retriggerEvent(Playable playable)
	{
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "seekToTime")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected float getProportionalTime(Playable playable)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "retriggerEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "getProportionalTime")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	protected float seekToTime(Playable playable)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public AkEventPlayableBehavior()
	{
	}
}
