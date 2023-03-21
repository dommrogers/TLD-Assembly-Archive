using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class CheckDistanceToGameObject : ConditionTask<Transform>
{
	public BBParameter<GameObject> checkTarget;

	public CompareMethod checkType;

	public BBParameter<float> distance;

	public float floatingPoint;

	protected override string info
	{
		[CallsUnknownMethods(Count = 21)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public CheckDistanceToGameObject()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
