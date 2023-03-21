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

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[CalledBy(Type = typeof(Action_ForceAIToAttackPlayer), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsUnknownMethods(Count = 6)]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_ForceAIToAttackPlayer()
	{
	}
}
