using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_PlayerStats : ConditionTask
{
	public enum Stat
	{
		Fatigue,
		Freezing,
		Health,
		Hunger,
		Thirst
	}

	public Stat stat;

	public CompareMethod checkType;

	public BBParameter<float> compareValue;

	public float differenceThreshold;

	protected override string info
	{
		[CallsUnknownMethods(Count = 17)]
		[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(Condition_PlayerStats), Member = "GetStatValue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Condition_PlayerStats), Member = "get_info")]
	[CalledBy(Type = typeof(Condition_PlayerStats), Member = "OnCheck")]
	[CallsUnknownMethods(Count = 5)]
	private float GetStatValue()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(Condition_PlayerStats), Member = "GetStatValue")]
	[CallsUnknownMethods(Count = 2)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Condition_PlayerStats()
	{
	}
}
