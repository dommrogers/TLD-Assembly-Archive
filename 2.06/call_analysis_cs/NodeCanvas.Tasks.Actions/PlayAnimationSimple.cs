using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class PlayAnimationSimple : ActionTask<Animation>
{
	public BBParameter<AnimationClip> animationClip;

	public float crossFadeTime;

	public WrapMode animationWrap;

	public bool waitActionFinish;

	private static Dictionary<Animation, AnimationClip> lastPlayedClips;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Animation), Member = "AddClip")]
	[CallsUnknownMethods(Count = 5)]
	protected override string OnInit()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Animation), Member = "CrossFade")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public PlayAnimationSimple()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
