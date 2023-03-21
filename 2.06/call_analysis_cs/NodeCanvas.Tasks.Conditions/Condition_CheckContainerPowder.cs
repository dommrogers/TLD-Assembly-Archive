using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CheckContainerPowder : ConditionTask
{
	public BBParameter<string> m_ContainerId;

	public GearPowderType m_Powder;

	public float m_RequiredAmount;

	protected override string info
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 3)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Condition_CheckContainerPowder()
	{
	}
}
