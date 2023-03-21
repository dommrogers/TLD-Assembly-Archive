using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

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
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[CallsUnknownMethods(Count = 19)]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(Condition_PlayerStats), Member = "GetStatValue")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Condition_PlayerStats), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_PlayerStats), Member = "get_info")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private float GetStatValue()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Condition_PlayerStats), Member = "GetStatValue")]
	[Calls(Type = typeof(OperationTools), Member = "Compare")]
	[CallsUnknownMethods(Count = 3)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_PlayerStats()
	{
	}
}
