using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ChanceEndWanderPause : StateMachineBehaviour
{
	public float m_DelayStartSeconds;

	public float m_MaxSecondsBeforeEnd;

	public float m_TestFrequencySeconds;

	public float m_PercentChance;

	private float m_NextTestTime;

	private float m_MaxEndTime;

	private bool m_Update;

	public int m_AnimParameter_AiState;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(ChanceEndWanderPause), Member = "EndWanderPause")]
	[CallsUnknownMethods(Count = 2)]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(ChanceEndWanderPause), Member = "OnStateUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void EndWanderPause(Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public ChanceEndWanderPause()
	{
	}
}
