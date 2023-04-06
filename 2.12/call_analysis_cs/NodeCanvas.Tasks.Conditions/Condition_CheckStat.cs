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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(float), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public Condition_CheckStat()
	{
	}
}
