using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class CheckSpeed : ConditionTask<Rigidbody>
{
	public CompareMethod checkType;

	public BBParameter<float> value;

	public float differenceThreshold;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public CheckSpeed()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
