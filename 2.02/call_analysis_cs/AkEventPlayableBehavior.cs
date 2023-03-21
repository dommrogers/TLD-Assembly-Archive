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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "fadeOutRequired")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "fadeOutRequired")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "ShouldPlay")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "ShouldPlay")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "getProportionalTime")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "fadeOutRequired")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "stopEvent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "stopEvent")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "triggerFadeOut")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "triggerFadeIn")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "seekToTime")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "playEvent")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "retriggerEvent")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 0)]
	private bool actionIsRequired(AkPlayableAction actionType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "PrepareFrame")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "OnBehaviourPlay")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	private bool ShouldPlay(Playable playable)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool fadeInRequired(float currentClipTime)
	{
		return default(bool);
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

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "PrepareFrame")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "PrepareFrame")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "checkForFadeOutImmediate")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "checkForFadeOut")]
	private bool fadeOutRequired(Playable playable)
	{
		return default(bool);
	}

	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "triggerFadeOut")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "fadeOutRequired")]
	private void checkForFadeOutImmediate(Playable playable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "fadeOutRequired")]
	private void checkForFadeOut(Playable playable)
	{
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "checkForFadeInImmediate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[CallsUnknownMethods(Count = 2)]
	protected void triggerFadeIn(float currentClipTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "checkForFadeOutImmediate")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	protected void triggerFadeOut(float fadeDuration)
	{
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "OnBehaviourPause")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	protected void stopEvent(int transition = 0)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	protected void playEvent()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "seekToTime")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[CallsUnknownMethods(Count = 13)]
	protected void retriggerEvent(Playable playable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "seekToTime")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "OnBehaviourPlay")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	protected float getProportionalTime(Playable playable)
	{
		return default(float);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "retriggerEvent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkEventPlayableBehavior), Member = "getProportionalTime")]
	[CallsUnknownMethods(Count = 2)]
	protected float seekToTime(Playable playable)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public AkEventPlayableBehavior()
	{
	}
}
