using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DamageEventTable : ScriptableObject
{
	public enum ApplyAttackOpts
	{
		None,
		FadeoutEventUi,
		ResetEvents
	}

	private BloodLossEvent m_BloodLossEvent;

	private SprainedAnkleEvent m_SprainedAnkleEvent;

	private SprainedWristEvent m_SprainedWristEvent;

	private LacerationEvent m_LacerationEvent;

	private MinorBruisingEvent m_MinorBruisingEvent;

	private MajorBruisingEvent m_MajorBruisingEvent;

	private ClothingDamageEvent m_ClothingDamageEvent;

	[NonSerialized]
	private RiskOfInfectionEvent m_RiskOfInfectionEvent;

	private float m_SecondsBeforeFadeout;

	private float m_FadeoutSeconds;

	private StruggleDamageEvent[] m_DamageEvents;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsInitialized()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 29)]
	public void Initialize()
	{
	}

	[CalledBy(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void FadeOutEventUi(float withDelay)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "GetChance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public StruggleDamageEvent GetWeightedRandomAttack()
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ReceiveAIAttack")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(DamageEventTable), Member = "GetWeightedRandomAttack")]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "Execute")]
	[Calls(Type = typeof(DamageEventTable), Member = "FadeOutEventUi")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public StruggleDamageEvent MaybeApplyAttack(ApplyAttackOpts opts)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public DamageEventTable()
	{
	}
}
