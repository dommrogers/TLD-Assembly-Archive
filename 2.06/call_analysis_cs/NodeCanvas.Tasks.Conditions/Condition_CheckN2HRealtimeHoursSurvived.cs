using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CheckN2HRealtimeHoursSurvived : ConditionTask
{
	public float m_Value;

	public CompareMethod m_CheckType;

	public float differenceThreshold;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Condition_CheckN2HRealtimeHoursSurvived()
	{
	}
}
