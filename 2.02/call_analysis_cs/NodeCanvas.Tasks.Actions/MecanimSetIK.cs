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
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 17)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Animator), Member = "SetIKPositionWeight")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	public void OnAnimatorIK()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MecanimSetIK()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
