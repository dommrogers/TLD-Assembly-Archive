using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_HoursWithinRangeOfFire : ConditionTask
{
	public CompareMethod checkType;

	public BBParameter<float> compareValue;

	public float differenceThreshold;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(Condition_HoursWithinRangeOfFire), Member = "GetHoursWithinRangeOfFire")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Condition_HoursWithinRangeOfFire), Member = "get_info")]
	[CalledBy(Type = typeof(Condition_HoursWithinRangeOfFire), Member = "OnCheck")]
	protected float GetHoursWithinRangeOfFire()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition_HoursWithinRangeOfFire), Member = "GetHoursWithinRangeOfFire")]
	[CallsUnknownMethods(Count = 2)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_HoursWithinRangeOfFire()
	{
	}
}
