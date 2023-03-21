using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CameraStatusEffects : MonoBehaviour
{
	public bool m_LowConditionBlurOverride;

	public float m_LowConditionBlurValue;

	public float m_LowConditionVignetteScalar;

	public float m_LowConditionChromaticAberrationScalar;

	public float m_PainAmount;

	public float m_PainColorGradingBlend;

	public bool m_TriggerPainPulse;

	private float m_PainTarget;

	public float m_StimAmount;

	public float m_StimChromaticAberration;

	public float m_StimColorGradingBlend;

	public bool m_TriggerStimPulse;

	private float m_StimTarget;

	public float m_BoostEffectAmount;

	public float m_BoostEffectChromaticAberration;

	public float m_BoostEffectVignetteIntensity;

	public Color m_BoostEffectVignetteColor;

	public float m_BoostEffectColorGradingBlend;

	public bool m_TriggerBoostEffectPulse;

	private float m_BoostEffectTarget;

	public float m_HeadacheAmount;

	public float m_HeadacheAmountSin;

	public float m_HeadacheSinSpeed;

	public float m_HeadacheChromaticAberration;

	public float m_HeadacheVignetteIntensity;

	public Color m_HeadacheVignetteColor;

	public float m_HeadacheColorGradingBlend;

	public bool m_TriggerHeadachePulse;

	private float m_HeadacheTarget;

	public float m_SuffocationAmount;

	public float m_SuffocationChromaticAberration;

	public float m_SuffocationVignetteIntensity;

	public Color m_SuffocationVignetteColor;

	public float m_SuffocationColorGradingBlend;

	public bool m_TriggerSuffocationPulse;

	private float m_SuffocationTarget;

	public float m_SprainAmount;

	public float m_SprainAmountSin;

	public float m_SprainSinSpeed;

	public float m_SprainVignetteIntensity;

	public Color m_SprainVignetteColor;

	public bool m_TriggerSprainPulse;

	private float m_SprainTarget;

	public float m_ElectrocutionAmount;

	public float m_ElectrocutionColorGradingBlend;

	public Light m_ElectrocutionLight;

	public float m_ElectrocutionChromaticAberration;

	private float m_ElectrocutionTarget;

	public bool m_TriggerElectrocutionPulse;

	private float m_FlickeringElectrocutionAmount;

	public float m_WaterAmount;

	public bool m_TriggerWaterPulse;

	private float m_WaterTarget;

	public float m_AimingAmount;

	public bool m_IsAiming;

	private float m_AimingTarget;

	private UnityEngine.Rendering.PostProcessing.ColorGrading m_NewColorGrading;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(FallDamage), Member = "MaybeSprainAnkle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_pulse_pain")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainAnkle")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWrist")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CalledBy(Type = typeof(FallDamage), Member = "MaybeBloodLoss")]
	[CalledBy(Type = typeof(FallDamage), Member = "MaybeSprainWrist")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[CalledBy(Type = typeof(RiskOfInfectionEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition), Member = "MaybeShowPainEffect")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[CalledBy(Type = typeof(SprainedAnkleEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(SprainedWristEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(CameraEffects), Member = "PainPulse")]
	[CalledBy(Type = typeof(Condition), Member = "ShowPainEffect")]
	public void PainPulse(float newPain)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_pulse_stim")]
	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_god")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(EmergencyStim), Member = "MaybeUpdateEmergencyStimEffects")]
	[CalledBy(Type = typeof(CameraEffects), Member = "StimPulse")]
	public void StimPulse(float newStim)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(EnergyBoost), Member = "MaybeUpdateEnergyBoostEffects")]
	[CalledBy(Type = typeof(CameraEffects), Member = "BoostEffectPulse")]
	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	public void BoostEffectPulse(float newBoostEffect)
	{
	}

	[CalledBy(Type = typeof(ToxicFog), Member = "StopAffliction")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CalledBy(Type = typeof(ToxicFog), Member = "Update")]
	[CalledBy(Type = typeof(ToxicFog), Member = "ToxicFogHeadachePulse")]
	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	[CalledBy(Type = typeof(Headache), Member = "MaybeUpdateHeadacheEffects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(CameraEffects), Member = "HeadachePulse")]
	public void HeadachePulse(float newHeadache)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Suffocating), Member = "ApplySuffocatingVisualEffect")]
	[CalledBy(Type = typeof(CameraEffects), Member = "SuffocationPulse")]
	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	public void SuffocationPulse(float newSuffocation)
	{
	}

	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_pulse_electrocution")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_god")]
	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	[CalledBy(Type = typeof(CameraEffects), Member = "ElectrocutionPulse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Condition), Member = "ShowElectricalEffect")]
	public void ElectrocutionPulse(float newElectrocution)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraEffects), Member = "WaterPulse")]
	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_image_filter")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "Update")]
	public void WaterPulse(float newWater)
	{
	}

	[CalledBy(Type = typeof(SprainPain), Member = "Update")]
	[CalledBy(Type = typeof(CameraEffects), Member = "SprainPulse")]
	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SprainPulse(float newSprain)
	{
	}

	[CallerCount(Count = 0)]
	public void StartAiming()
	{
	}

	[CallerCount(Count = 0)]
	public void StopAiming()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "UpdateImage")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "SprainPulse")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "WaterPulse")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "ElectrocutionPulse")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "SuffocationPulse")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "HeadachePulse")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "BoostEffectPulse")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "StimPulse")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void Update()
	{
	}

	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsDeduplicatedMethods(Count = 25)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	private void UpdateImage()
	{
	}

	[CallerCount(Count = 0)]
	private void ResetEffects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CameraStatusEffects()
	{
	}
}
