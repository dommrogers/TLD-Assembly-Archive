using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.AI;

public class AiBaseWolf : BaseAi
{
	public float m_HowlResponseMinSeconds;

	public float m_HowlResponseMaxSeconds;

	private float m_HowlStartDelay;

	protected AiMode m_PostHowlState;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ClearHowlStartDelay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetRemainingHowlDelay()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnAnimationEvent_HowlComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	public float SetHowlStartDelay(float baseTime)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	public void EnterHowl()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ExitHowl()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "get_Timberwolf")]
	[Calls(Type = typeof(AiBaseWolf), Member = "AdvanceToNextBehavior")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void ProcessHowl()
	{
	}

	[CalledBy(Type = typeof(AiBaseWolf), Member = "ProcessHowl")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void AdvanceToNextBehavior()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = ".ctor")]
	public AiBaseWolf()
	{
	}
}
