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
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
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
			return 0.0;
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void setBlendInDuration(float d)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void setBlendOutDuration(float d)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptPlayable<>), Member = "Create")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetObject")]
	[Calls(Type = typeof(AkEventPlayable), Member = "initializeBehaviour")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[CalledBy(Type = typeof(AkEventPlayable), Member = "CreatePlayable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExposedReference<>), Member = "Resolve")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void initializeBehaviour(PlayableGraph graph, AkEventPlayableBehavior b, GameObject owner)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AkEventPlayable()
	{
	}
}
