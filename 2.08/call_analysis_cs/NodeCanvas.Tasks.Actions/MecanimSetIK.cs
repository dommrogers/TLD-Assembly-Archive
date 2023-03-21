using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class MecanimSetIK : ActionTask<Animator>
{
	public AvatarIKGoal IKGoal;

	public BBParameter<GameObject> goal;

	public BBParameter<float> weight;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "SetIKPositionWeight")]
	public void OnAnimatorIK()
	{
	}

	[CallerCount(Count = 0)]
	public MecanimSetIK()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
