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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 46)]
		set
		{
		}
	}

	public TimelineClip OwningClip
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 19)]
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
	[Calls(Type = typeof(ScriptPlayable<>), Member = "Create")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetObject")]
	[Calls(Type = typeof(AkRTPCPlayable), Member = "InitializeBehavior")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[CalledBy(Type = typeof(AkRTPCPlayable), Member = "CreatePlayable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExposedReference<>), Member = "Resolve")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void InitializeBehavior(PlayableGraph graph, ref AkRTPCPlayableBehaviour b, GameObject owner)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AkRTPCPlayable()
	{
	}
}
