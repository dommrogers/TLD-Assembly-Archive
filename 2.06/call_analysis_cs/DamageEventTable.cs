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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsInitialized()
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(DamageEventTable), Member = "Awake")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[CallsUnknownMethods(Count = 29)]
	public void Initialize()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	public void FadeOutEventUi(float withDelay)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetDamageEvents")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "GetChance")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "GetChance")]
	public StruggleDamageEvent GetWeightedRandomAttack()
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DamageEventTable), Member = "GetWeightedRandomAttack")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(DamageEventTable), Member = "FadeOutEventUi")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ReceiveAIAttack")]
	[CallsUnknownMethods(Count = 2)]
	public StruggleDamageEvent MaybeApplyAttack(ApplyAttackOpts opts)
	{
		return null;
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public DamageEventTable()
	{
	}
}
