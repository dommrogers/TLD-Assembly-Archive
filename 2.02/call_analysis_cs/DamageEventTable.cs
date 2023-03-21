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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsInitialized()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[CallsUnknownMethods(Count = 29)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Initialize()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CallsUnknownMethods(Count = 1)]
	public void FadeOutEventUi(float withDelay)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "GetChance")]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "GetChance")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public StruggleDamageEvent GetWeightedRandomAttack()
	{
		return null;
	}

	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(DamageEventTable), Member = "FadeOutEventUi")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "Execute")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ReceiveAIAttack")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(DamageEventTable), Member = "GetWeightedRandomAttack")]
	public StruggleDamageEvent MaybeApplyAttack(ApplyAttackOpts opts)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public DamageEventTable()
	{
	}
}
