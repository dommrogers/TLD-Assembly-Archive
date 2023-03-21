using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using SpecialEvents;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CheckN2HRealtimeHoursSurvived : ConditionTask
{
	public float m_Value;

	public CompareMethod m_CheckType;

	public float differenceThreshold;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(OperationTools), Member = "Compare")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Condition_CheckN2HRealtimeHoursSurvived()
	{
	}
}
