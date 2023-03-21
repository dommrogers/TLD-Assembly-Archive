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
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 31)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(CameraEffects), Member = "UpdateEffectParameters")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsUnknownMethods(Count = 12)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void SetColorScalar(GameColorScalar source, float scalar)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureForInterior")]
	[CalledBy(Type = typeof(CameraEffects), Member = "Configure")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(CameraEffects), Member = "UpdateEffectParameters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsDeduplicatedMethods(Count = 5)]
	public void ConfigureContrastEnhance(float intensity)
	{
	}

	[CallerCount(Count = 53)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	public void DepthOfFieldTurnOn(float focalPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	public void DepthOfFieldTurnOn()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	public void DepthOfFieldTurnOff(bool forceOff = false)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsDepthOfFieldEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayableBehaviourCameraEffects), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "End")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateBlurEffect")]
	[CalledBy(Type = typeof(CinematicManager), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Start")]
	public void BlurSetSize(float blurSize)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void BlurTurnOff()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CallsUnknownMethods(Count = 1)]
	public void BloomEnable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool GetContrastEnhanceEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public void ContrastEnhanceEnable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public void VignettingEnable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void AntiAliasingEnable(bool enable)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetPostFx")]
	[CallsUnknownMethods(Count = 7)]
	public void SetAntiAliasingMode(AAMode aaMode, bool disableAA = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CallsUnknownMethods(Count = 1)]
	public void PainPulse(float amount)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "StimPulse")]
	[CallerCount(Count = 0)]
	public void StimPulse(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "BoostEffectPulse")]
	[CallsUnknownMethods(Count = 1)]
	public void BoostEffectPulse(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "HeadachePulse")]
	[CallsUnknownMethods(Count = 1)]
	public void HeadachePulse(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "SuffocationPulse")]
	[CallsUnknownMethods(Count = 1)]
	public void SuffocationPulse(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "ElectrocutionPulse")]
	[CallsUnknownMethods(Count = 1)]
	public void ElectrocutionPulse(float amount)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "WaterPulse")]
	[CallerCount(Count = 0)]
	public void WaterPulse(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraStatusEffects), Member = "SprainPulse")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	[CallsUnknownMethods(Count = 2)]
	public void Configure()
	{
	}

	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "EnableCameraWeaponPostEffects")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	public void EnableSSAO()
	{
	}

	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[CallerCount(Count = 0)]
	public void RefreshSSAOSettings()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void AddBloomOverride(BloomOverride bloomOverride)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveBloomOverride(BloomOverride bloomOverride)
	{
	}

	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Max")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(CameraEffects), Member = "AdaptSSAOByViewAngle")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CalledBy(Type = typeof(CameraEffects), Member = "Update")]
	[CallsUnknownMethods(Count = 109)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 28)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[Calls(Type = typeof(Mathf), Member = "Max")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void UpdateEffectParameters()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(CameraEffects), Member = "UpdateEffectParameters")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	public void AdaptSSAOByViewAngle()
	{
	}

	[CalledBy(Type = typeof(CameraEffects), Member = "Configure")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetSSAO")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetSSAO")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CalledBy(Type = typeof(CameraEffects), Member = "RefreshSSAOSettings")]
	[CalledBy(Type = typeof(CameraEffects), Member = "EnableSSAO")]
	[CalledBy(Type = typeof(CameraEffects), Member = "DisableSSAO")]
	[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureForInterior")]
	[CalledBy(Type = typeof(CameraEffects), Member = "Configure")]
	[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureForExterior")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleLightingOnly")]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[Calls(Type = typeof(PostProcessManager), Member = "EnableAO")]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 14)]
	public void ConfigureSSAO(SSAOMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SSAOMode GetCurrentSSAOMode()
	{
		return default(SSAOMode);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CameraEffects), Member = "DisableSSAO")]
	[CalledBy(Type = typeof(CameraEffects), Member = "EnableSSAO")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetSSAO")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetSSAO")]
	[CallsUnknownMethods(Count = 4)]
	private void EnableCameraWeaponPostEffects(bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(CameraEffects), Member = "Start")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_image_filter")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmImageFilter")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "SetPlacementColors")]
	[Calls(Type = typeof(PlayerManager), Member = "InitializePropertyBlocks")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void SwitchImageFilter(ImageFilterType filter)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public CameraEffects()
	{
	}
}
