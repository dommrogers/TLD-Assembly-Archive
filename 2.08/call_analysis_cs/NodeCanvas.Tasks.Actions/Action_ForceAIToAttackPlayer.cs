using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_ForceAIToAttackPlayer : TLD_Action
{
	public bool stopAiBeforeAttack;

	public bool playAttackStartAnimation;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_ForceAIToAttackPlayer), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_ForceAIToAttackPlayer), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ForceAIToAttackPlayer()
	{
	}
}
