using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class MecanimSetLookAt : ActionTask<Animator>
{
	public BBParameter<GameObject> targetPosition;

	public BBParameter<float> targetWeight;

	public BBParameter<float> targetkWeightBody;

	public BBParameter<float> targetWeightHead;

	public BBParameter<float> targetWeightEyes;

	public BBParameter<float> targetWeightClamp;

	private BipedMoveAgent bma;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "SetSetLookAtWeight")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "SetLookAtGameObject")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	public void OnAnimatorIK()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public MecanimSetLookAt()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
