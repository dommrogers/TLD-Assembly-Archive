using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class MecanimCheckFloat : ConditionTask<Animator>
{
	public BBParameter<string> parameter;

	public CompareMethod comparison;

	public BBParameter<float> value;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public MecanimCheckFloat()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
