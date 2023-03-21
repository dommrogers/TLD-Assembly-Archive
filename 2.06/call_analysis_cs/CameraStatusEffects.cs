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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	public void PainPulse(float newPain)
	{
	}

	[CallerCount(Count = 0)]
	public void StimPulse(float newStim)
	{
	}

	[CallerCount(Count = 0)]
	public void BoostEffectPulse(float newBoostEffect)
	{
	}

	[CallerCount(Count = 0)]
	public void HeadachePulse(float newHeadache)
	{
	}

	[CallerCount(Count = 0)]
	public void SuffocationPulse(float newSuffocation)
	{
	}

	[CallerCount(Count = 0)]
	public void ElectrocutionPulse(float newElectrocution)
	{
	}

	[CallerCount(Count = 0)]
	public void WaterPulse(float newWater)
	{
	}

	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "UpdateImage")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 17)]
	private void Update()
	{
	}

	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallerCount(Count = 1)]
	private void UpdateImage()
	{
	}

	[CallerCount(Count = 0)]
	private void ResetEffects()
	{
	}

	[CallerCount(Count = 0)]
	public CameraStatusEffects()
	{
	}
}
