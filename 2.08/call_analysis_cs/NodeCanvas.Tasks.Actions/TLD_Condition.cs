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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Task), Member = "get_agent")]
		[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
		[CalledBy(Type = typeof(Condition_BaseAiInState), Member = "OnCheck")]
		[CalledBy(Type = typeof(Condition_AnimatorInState), Member = "OnCheck")]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
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
