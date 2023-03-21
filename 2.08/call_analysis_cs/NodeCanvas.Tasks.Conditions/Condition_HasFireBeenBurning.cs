using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_HasFireBeenBurning : ConditionTask
{
	public BBParameter<string> collisionVolumeMissionObjectIdentifier;

	public BBParameter<float> burnTimeHours;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_HasFireBeenBurning()
	{
	}
}
