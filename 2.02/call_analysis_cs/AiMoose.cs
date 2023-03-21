using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiMoose : MonoBehaviour
{
	public float m_StunnedDuration;

	public float m_HoldBeforeAttackDelaySeconds;

	public float m_StompAttackChance;

	public float m_StumpDetectionRadius;

	public float m_StumpScratchingDelayHoursMin;

	public float m_StumpScratchingDelayHoursMax;

	public float m_SteepSlopeFleeOnAttackThresholdDegrees;

	public float m_StumpScratchingChance;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool CanScratch()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Random), Member = "Range")]
	[CallerCount(Count = 0)]
	public float GetRolledStumpScratchingDelay()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AiMoose()
	{
	}
}
