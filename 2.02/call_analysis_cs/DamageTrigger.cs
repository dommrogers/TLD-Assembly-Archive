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
	[CallerCount(Count = 7)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTriggerExit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerStay(Collider c)
	{
	}

	[CalledBy(Type = typeof(DamageTrigger), Member = "OnTriggerEnter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Condition), Member = "MaybeShowPainEffect")]
	[Calls(Type = typeof(Burns), Member = "BurnsStart")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricStart")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void ApplyOneTimeDamage(GameObject go, float damage)
	{
	}

	[CalledBy(Type = typeof(DamageTrigger), Member = "OnTriggerStay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "ElectrocutionPulse")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 33)]
	private void ApplyContinuousDamage(GameObject go, float damage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DamageTrigger()
	{
	}
}
