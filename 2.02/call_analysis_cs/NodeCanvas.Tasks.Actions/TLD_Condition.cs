using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class TLD_Condition : ConditionTask
{
	public BBParameter<bool> agentIsMissionObject;

	public BBParameter<string> agentMissionObjectIdentifier;

	protected new Component agent
	{
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(Condition_BaseAiInState), Member = "OnCheck")]
		[CalledBy(Type = typeof(Condition_AnimatorInState), Member = "OnCheck")]
		[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Task), Member = "get_agent")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected string GetAgentMissionObjectIdentifierValue()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TLD_Condition()
	{
	}
}
