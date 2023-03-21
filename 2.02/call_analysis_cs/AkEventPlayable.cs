using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class AkEventPlayable : PlayableAsset, ITimelineClipAsset
{
	private readonly WwiseEventTracker eventTracker;

	public AK.Wwise.Event akEvent;

	private float blendInDuration;

	private float blendOutDuration;

	private float easeInDuration;

	private float easeOutDuration;

	public ExposedReference<GameObject> emitterObjectRef;

	private float eventDurationMax;

	private float eventDurationMin;

	public bool overrideTrackEmitterObject;

	private TimelineClip owningClip;

	public bool retriggerEvent;

	public TimelineClip OwningClip
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		set
		{
		}
	}

	public override double duration
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayableAsset), Member = "get_duration")]
		get
		{
			return default(double);
		}
	}

	public ClipCaps clipCaps
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(ClipCaps);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void setEaseInDuration(float d)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void setEaseOutDuration(float d)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void setBlendInDuration(float d)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void setBlendOutDuration(float d)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkEventPlayable), Member = "initializeBehaviour")]
	[CallsUnknownMethods(Count = 3)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(AkEventPlayable), Member = "CreatePlayable")]
	public void initializeBehaviour(PlayableGraph graph, AkEventPlayableBehavior b, GameObject owner)
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AkEventPlayable()
	{
	}
}
