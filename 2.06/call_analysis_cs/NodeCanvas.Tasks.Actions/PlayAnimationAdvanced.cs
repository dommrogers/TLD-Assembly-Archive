using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class PlayAnimationAdvanced : ActionTask<Animation>
{
	public BBParameter<AnimationClip> animationClip;

	public WrapMode animationWrap;

	public AnimationBlendMode blendMode;

	public float playbackSpeed;

	public float crossFadeTime;

	public PlayDirections playDirection;

	public BBParameter<string> mixTransformName;

	public BBParameter<int> animationLayer;

	public bool queueAnimation;

	public bool waitActionFinish;

	private string animationToPlay;

	private int dir;

	private Transform mixTransform;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Animation), Member = "AddClip")]
	[CallsUnknownMethods(Count = 5)]
	protected override string OnInit()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Animation), Member = "CrossFadeQueued")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Animation), Member = "CrossFade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Animation), Member = "AddClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	private Transform FindTransform(Transform parent, string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public PlayAnimationAdvanced()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
