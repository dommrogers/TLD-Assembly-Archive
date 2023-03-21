using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using TLD.Stats;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CheckStat : ConditionTask
{
	public StatID Stat;

	public CompareMethod checkType;

	public float Value;

	public float differenceThreshold;

	protected override string info
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Condition_CheckStat()
	{
	}
}
