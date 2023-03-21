using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
	private PanelReference<Panel_Loading> m_Loading;

	public DamageSource m_DamageSource;

	public float m_OneTimeDamage;

	public float m_DamagePerSecond;

	public float m_PulseEffectIntensity;

	public float m_PulseEffectIntervalSeconds;

	public bool m_Active;

	public bool m_ApplyBurns;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	private void OnTriggerExit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerStay(Collider c)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DamageTrigger), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricStart")]
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	[Calls(Type = typeof(Condition), Member = "MaybeShowPainEffect")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void ApplyOneTimeDamage(GameObject go, float damage)
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(DamageTrigger), Member = "OnTriggerStay")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void ApplyContinuousDamage(GameObject go, float damage)
	{
	}

	[CallerCount(Count = 0)]
	public DamageTrigger()
	{
	}
}
