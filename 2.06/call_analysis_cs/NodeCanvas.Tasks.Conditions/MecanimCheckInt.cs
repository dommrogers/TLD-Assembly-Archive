using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class MecanimCheckInt : ConditionTask<Animator>
{
	public BBParameter<string> parameter;

	public CompareMethod comparison;

	public BBParameter<int> value;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public MecanimCheckInt()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
