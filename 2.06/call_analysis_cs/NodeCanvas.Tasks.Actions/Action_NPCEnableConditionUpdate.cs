using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_NPCEnableConditionUpdate : ActionTask
{
	public BBParameter<bool> enableUpdates;

	public BBParameter<string> npcIdentifier;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(NPC), Member = "UpdateTODHours")]
	[Calls(Type = typeof(NPC), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Action_NPCEnableConditionUpdate()
	{
	}
}
