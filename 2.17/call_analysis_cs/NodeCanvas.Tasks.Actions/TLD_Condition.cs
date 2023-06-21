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
		[CalledBy(Type = typeof(Condition_BaseAiInState), Member = "OnCheck")]
		[CalledBy(Type = typeof(Condition_AnimatorInState), Member = "OnCheck")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(Task), Member = "get_agent")]
		[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
		[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
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
