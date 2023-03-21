using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityStandardAssets.ImageEffects;

public class CameraEffects : MonoBehaviour
{
	public enum GameColorScalar
	{
		LowHealthEffect,
		RopeFall,
		Max
	}

	public enum SSAOMode
	{
		ExteriorLowQuality,
		Exterior,
		ExteriorHighQuality,
		InteriorLowQuality,
		Interior,
		InteriorHighQuality,
		Off
	}

	public enum ImageFilterType
	{
		None,
		Heritage,
		Noir
	}

	[Serializable]
	public class SSAOParams
	{
		public string name;

		public float m_Radius;

		public float m_Intensity;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SSAOParams()
		{
		}
	}

	[Serializable]
	public class BloomOverride
	{
		[NonSerialized]
		public float m_BlendStrength;

		public bool m_OverrideIntensity;

		public bool m_OverrideThreshold;

		public bool m_OverrideSoftKnee;

		public bool m_OverrideDiffusion;

		public float m_Intensity;

		public float m_Threshold;

		public float m_SoftKnee;

		public float m_Diffusion;

		public Texture2D m_LensDirtTexture;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public BloomOverride()
		{
		}
	}

	private PostProcessLayer m_ImageEffectsPostProcessLayer;

	public SSAOParams[] m_SSAO_Configurations;

	public float m_InteriorContrastEnhanceIntensity;

	public float m_IndoorVignetteIntensity;

	public float m_IndoorChromaticAberration;

	public float m_DefaultMatteBlend;

	public PostProcessVolume m_FPSCameraPostProcessVolume;

	public PostProcessVolume m_EffectCameraPostProcessVolume;

	public PostProcessVolume m_WeaponCameraPostProcessVolume;

	public PostProcessVolume m_AuxPostProcessVolume;

	public ImageFilterType m_ActiveFilter;

	public PostProcessProfile m_HeritagePostProcessProfile;

	public PostProcessProfile m_NoirPostProcessProfile;

	public Color m_MeshPlacementValidColour;

	public Color m_MeshPlacementInvalidColour;

	public UnityEngine.Rendering.PostProcessing.Bloom m_Bloom;

	public float m_ColorScalar;

	public float m_CurrentSaturationUnscaled;

	public float m_CurrentContrastEnhanceIntensityUnscaled;

	public float m_SSAO_IntensityScalar;

	public static ImageFilterType s_SessionFilter;

	public static bool s_DisableSuffocationEffect;

	private int m_SSAO_QualityOffset;

	private int m_SSAO_QualityOffsetDefault;

	private SSAOParams m_CurrentSettings;

	private SSAOMode m_CurrentMode;

	private CameraStatusEffects m_CameraStatusEffects;

	private UnsharpMask m_UnsharpMask;

	private BlurOptimized m_Blur;

	private Antialiasing[] m_AntiAliasing;

	private Vignette m_Vignette;

	private ChromaticAberration m_ChromaticAberration;

	public UnityEngine.Rendering.PostProcessing.DepthOfField m_DepthOfField;

	private AmbientOcclusion m_AmbientOcclusion;

	private AmbientOcclusion m_AmbientOcclusionWeapon;

	private UnityEngine.Rendering.PostProcessing.ColorGrading m_NewColorGrading;

	private MaskedBlurEffect m_MaskedBlur;

	private SuffocationScreenEffect m_SuffocationScreenEffect;

	private bool m_DOFTurnedOnThisFrame;

	private bool m_DOFWaterOverridden;

	private float[] m_ColorScalars;

	private List<BloomOverride> m_BloomOverrides;

	private bool m_HasInitializedImageFilter;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PostProcessProfile), Member = "TryGetSettings")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "UpdateEffectParameters")]
	[CallsUnknownMethods(Count = 5)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetColorScalar(GameColorScalar source, float scalar)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CalledBy(Type = typeof(CameraEffects), Member = "Configure")]
	[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureForInterior")]
	[CalledBy(Type = typeof(CameraEffects), Member = "UpdateEffectParameters")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 5)]
	public void ConfigureContrastEnhance(float intensity)
	{
	}

	[CallerCount(Count = 45)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsUnknownMethods(Count = 2)]
	public void DepthOfFieldTurnOn(float focalPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	public void DepthOfFieldTurnOn()
	{
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsUnknownMethods(Count = 1)]
	public void DepthOfFieldTurnOff(bool forceOff = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsDepthOfFieldEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CalledBy(Type = typeof(CinematicManager), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Start")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "End")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateBlurEffect")]
	[CalledBy(Type = typeof(PlayableBehaviourCameraEffects), Member = "ProcessFrame")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void BlurSetSize(float blurSize)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void BlurTurnOff()
	{
	}

	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetPostFx")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsUnknownMethods(Count = 1)]
	public void BloomEnable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool GetContrastEnhanceEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetPostFx")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsUnknownMethods(Count = 1)]
	public void ContrastEnhanceEnable(bool enable)
	{
	}

	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetPostFx")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsUnknownMethods(Count = 1)]
	public void VignettingEnable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AntiAliasingEnable(bool enable)
	{
	}

	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetPostFx")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetAntiAliasingMode(AAMode aaMode, bool disableAA = false)
	{
	}

	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[CalledBy(Type = typeof(FallDamage), Member = "MaybeSprainWrist")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void PainPulse(float amount)
	{
	}

	[CalledBy(Type = typeof(EmergencyStim), Member = "MaybeUpdateEmergencyStimEffects")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void StimPulse(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void BoostEffectPulse(float amount)
	{
	}

	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybeStartHealing")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void HeadachePulse(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SuffocationPulse(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void ElectrocutionPulse(float amount)
	{
	}

	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void WaterPulse(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SprainPulse(float amount)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vignette Vignette()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ChromaticAberration ChromaticAberration()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UnityEngine.Rendering.PostProcessing.ColorGrading ColorGrading()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	[CallsUnknownMethods(Count = 1)]
	public void Configure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	public void ConfigureForInterior()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	public void ConfigureForExterior()
	{
	}

	[CallerCount(Count = 0)]
	public void SetSSAOQualityOffset(int offset)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(CameraEffects), Member = "EnableCameraWeaponPostEffects")]
	public void DisableSSAO()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsSSAOEnabled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "EnableCameraWeaponPostEffects")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	public void EnableSSAO()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	public void RefreshSSAOSettings()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddBloomOverride(BloomOverride bloomOverride)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveBloomOverride(BloomOverride bloomOverride)
	{
	}

	[CalledBy(Type = typeof(CameraEffects), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ParameterOverride<>), Member = "Override")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(CameraEffects), Member = "AdaptSSAOByViewAngle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateEffectParameters()
	{
	}

	[CalledBy(Type = typeof(CameraEffects), Member = "UpdateEffectParameters")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void AdaptSSAOByViewAngle()
	{
	}

	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleLightingOnly")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CalledBy(Type = typeof(CameraEffects), Member = "Configure")]
	[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureForInterior")]
	[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureForExterior")]
	[CalledBy(Type = typeof(CameraEffects), Member = "DisableSSAO")]
	[CalledBy(Type = typeof(CameraEffects), Member = "EnableSSAO")]
	[CalledBy(Type = typeof(CameraEffects), Member = "RefreshSSAOSettings")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetSSAO")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ParameterOverride<>), Member = "Override")]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessManager), Member = "EnableAO")]
	[CallsUnknownMethods(Count = 5)]
	public void ConfigureSSAO(SSAOMode mode)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SSAOMode GetCurrentSSAOMode()
	{
		return default(SSAOMode);
	}

	[CalledBy(Type = typeof(CameraEffects), Member = "DisableSSAO")]
	[CalledBy(Type = typeof(CameraEffects), Member = "EnableSSAO")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetSSAO")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void EnableCameraWeaponPostEffects(bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(CameraEffects), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmImageFilter")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_image_filter")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "InitializePropertyBlocks")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public void SwitchImageFilter(ImageFilterType filter)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public CameraEffects()
	{
	}
}
