using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_PlayerHealth : ConditionTask
{
	public CompareMethod checkType;

	public BBParameter<float> compareValue;

	public float differenceThreshold;

	protected override string info
	{
		[CallsUnknownMethods(Count = 22)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsUnknownMethods(Count = 3)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Condition_PlayerHealth()
	{
	}
}
