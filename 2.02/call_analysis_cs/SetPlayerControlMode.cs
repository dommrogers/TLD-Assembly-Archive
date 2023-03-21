using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SetPlayerControlMode : StateMachineBehaviour
{
	public bool m_SetModeOnEnter;

	public bool m_SetModeOnExit;

	public bool m_RestoreModeOnExit;

	public PlayerControlMode m_ModeOnEnter;

	public PlayerControlMode m_ModeOnExit;

	private PlayerControlMode m_RestoreMode;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public SetPlayerControlMode()
	{
	}
}
