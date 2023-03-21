using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class TLDSetOtherBlackboardVariable : ActionTask
{
	public string missionObjectIdentifier;

	public BBParameter<string> targetVariableName;

	public BBObjectParameter newValue;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TLDSetOtherBlackboardVariable), Member = "GetBlackboard")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(TLDSetOtherBlackboardVariable), Member = "OnExecute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	private Blackboard GetBlackboard()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TLDSetOtherBlackboardVariable()
	{
	}
}
