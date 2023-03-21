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
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(TLDSetOtherBlackboardVariable), Member = "GetBlackboard")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CalledBy(Type = typeof(TLDSetOtherBlackboardVariable), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
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
