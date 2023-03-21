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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Animation), Member = "AddClip")]
	[CallsUnknownMethods(Count = 7)]
	protected override string OnInit()
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Animation), Member = "CrossFadeQueued")]
	[Calls(Type = typeof(Animation), Member = "CrossFade")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 31)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(PlayAnimationAdvanced), Member = "FindTransform")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Animation), Member = "AddClip")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayAnimationAdvanced), Member = "OnExecute")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	private Transform FindTransform(Transform parent, string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public PlayAnimationAdvanced()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
