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
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(DamageEventTable), Member = "Awake")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 29)]
	public void Initialize()
	{
	}

	[CalledBy(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "GetChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public StruggleDamageEvent GetWeightedRandomAttack()
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ReceiveAIAttack")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DamageEventTable), Member = "GetWeightedRandomAttack")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(DamageEventTable), Member = "FadeOutEventUi")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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
