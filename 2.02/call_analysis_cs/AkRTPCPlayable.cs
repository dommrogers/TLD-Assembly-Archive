using System;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class AkRTPCPlayable : PlayableAsset, ITimelineClipAsset
{
	public bool overrideTrackObject;

	public ExposedReference<GameObject> RTPCObject;

	public bool setRTPCGlobally;

	public AkRTPCPlayableBehaviour template;

	private RTPC _003CParameter_003Ek__BackingField;

	private TimelineClip _003COwningClip_003Ek__BackingField;

	public RTPC Parameter
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	public TimelineClip OwningClip
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public ClipCaps clipCaps
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(ClipCaps);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkRTPCPlayable), Member = "InitializeBehavior")]
	[CallsUnknownMethods(Count = 2)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(AkRTPCPlayable), Member = "CreatePlayable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void InitializeBehavior(PlayableGraph graph, ref AkRTPCPlayableBehaviour b, GameObject owner)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public AkRTPCPlayable()
	{
	}
}
