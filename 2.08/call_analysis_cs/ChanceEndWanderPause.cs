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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ChanceEndWanderPause), Member = "EndWanderPause")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(ChanceEndWanderPause), Member = "OnStateUpdate")]
	[CallsUnknownMethods(Count = 2)]
	private void EndWanderPause(Animator animator)
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ChanceEndWanderPause()
	{
	}
}
