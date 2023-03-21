using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
	public DamageSource m_DamageSource;

	public float m_OneTimeDamage;

	public float m_DamagePerSecond;

	public float m_PulseEffectIntensity;

	public float m_PulseEffectIntervalSeconds;

	public bool m_Active;

	public bool m_ApplyBurns;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTriggerExit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerStay(Collider c)
	{
	}

	[Calls(Type = typeof(Condition), Member = "MaybeShowPainEffect")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricStart")]
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void ApplyOneTimeDamage(GameObject go, float damage)
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(DamageTrigger), Member = "OnTriggerStay")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "ElectrocutionPulse")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	private void ApplyContinuousDamage(GameObject go, float damage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DamageTrigger()
	{
	}
}
