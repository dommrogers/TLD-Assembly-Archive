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
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "SetLookAtGameObject")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void OnAnimatorIK()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public MecanimSetLookAt()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
