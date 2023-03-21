using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CheckInvisibleEntityState : ConditionTask
{
	public InvisibleEntityManager.Behavior m_TargetBehavior;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Condition_CheckInvisibleEntityState()
	{
	}
}
