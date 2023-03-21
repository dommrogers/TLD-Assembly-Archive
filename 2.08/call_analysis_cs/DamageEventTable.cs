using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
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

	private float m_SecondsBeforeFadeout;

	private float m_FadeoutSeconds;

	private PanelReference<Panel_HUD> m_HUD;

	private StruggleDamageEvent[] m_DamageEvents;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsInitialized()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(DamageEventTable), Member = "Awake")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[CallsUnknownMethods(Count = 29)]
	public void Initialize()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	public void FadeOutEventUi(float withDelay)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetDamageEvents")]
	public void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "GetChance")]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "GetChance")]
	[CalledBy(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[CallsUnknownMethods(Count = 5)]
	public StruggleDamageEvent GetWeightedRandomAttack()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(DamageEventTable), Member = "FadeOutEventUi")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ReceiveAIAttack")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DamageEventTable), Member = "GetWeightedRandomAttack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallerCount(Count = 4)]
	public StruggleDamageEvent MaybeApplyAttack(ApplyAttackOpts opts)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public DamageEventTable()
	{
	}
}
