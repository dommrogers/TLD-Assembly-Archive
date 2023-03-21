using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using Unity.Mathematics;
using UnityEngine;

public class AuroraElectrolizer : MonoBehaviour
{
	[Serializable]
	public struct LightFlareInfo
	{
		public LensFlare m_LightFlare;

		public Color m_FlareInitialColour;
	}

	public MinMax m_AuroraThresholdActivate;

	public MinMax m_AuroraThresholdStable;

	public Light[] m_LocalLights;

	public GameObject[] m_EmissiveObjects;

	public Shader m_EmissiveShader;

	public float m_EmissiveMultiplier;

	public ParticleSystem[] m_LocalFX;

	public string m_Audio;

	public AuroraLightFlickerType m_LightFlickerType;

	private float[] m_LocalLightsIntensity;

	public bool m_RelativeIntensity;

	public bool m_FlaresUseLightColour;

	public float m_UpdateThresholdPercent;

	public MinMax m_FlickerChangeTime;

	public MinMax m_LightPrimaryIntensity;

	public MinMax m_LightSecondaryIntensity;

	public MinMax m_LightPrimaryFrequency;

	public MinMax m_LightSecondaryFrequency;

	public MinMax m_LightNoiseFrequency;

	public float m_LightMainlyPercentage;

	public float m_MainlyUpdateSpeed;

	public ScaledCurve m_LightCustomCurve;

	public bool m_LightRandomizePerEvent;

	public bool m_LightFadeWithAurora;

	public float m_LightIntensityMultiplier;

	public bool m_RandomAuroraColor;

	public bool m_OverrideEmissiveColor;

	public Color m_OverrideColor;

	public bool m_LightExludeSteady;

	public bool m_LightExludeSingle;

	public bool m_LightExludeDouble;

	public bool m_LightExludeCustom;

	public bool m_LightExludeRandomLerp;

	public bool m_LightExludeRandomSharp;

	public bool m_LightExludeMainlyOn;

	public bool m_LightExludeMainlyOff;

	public bool m_RequiresAuroraField;

	public bool m_ExternalPowerActive;

	private AuroraField m_ActiveAuroraField;

	public bool m_ParticlesScaleEmission;

	public float m_MaximumDistanceFromCamera;

	public float m_MaxConsoleDistanceFromCamera;

	public float m_SwitchIndoorPercent;

	public float m_XboxPs4IndoorPercent;

	public float m_PcIndoorPercent;

	public float m_FadeDistancePercent;

	public bool m_ForceRefresh;

	private float m_CurLowThreshold;

	private float m_CurStableThreshold;

	private float m_AuroraLightFade;

	private float m_AuroraFXFade;

	private float m_MainlyTimer;

	private float m_MainlyRndVal;

	private float m_NormalizedTimer;

	private float m_NoiseTimer;

	private float m_PhiTimer;

	private float m_CurPriFreq;

	private float m_CurSecFreq;

	private float m_CurNoiFreq;

	private float m_PriPeriod;

	private float m_SecPeriod;

	private float m_PhiPri;

	private float m_PhiSec;

	private float m_CurIntensity;

	private float m_NewIntensity;

	private float m_PrvIntensity;

	private float m_StaticIntensity;

	private float[] m_FxInitialRate;

	private uint m_AudioInstanceID;

	private bool m_IsInitialized;

	private List<LightFlareInfo> m_LightFlares;

	private bool m_HasStopped;

	private bool m_SetDistances;

	private float m_MaximumSqrDistanceFromCamera;

	private float m_MaximumSqrFadeFromCamera;

	private float m_IntensitySentToWise;

	private float m_FadeIntensity;

	private float m_FlickerTime;

	private float m_FlickerChangeTimer;

	private Color m_Color;

	private HashSet<Renderer> m_Renderers;

	private MaterialPropertyBlock m_EmissivePropertyBlock;

	private static readonly int s_EmissiveStrengthPropertyID;

	private static readonly int s_EmissiveTintPropertyID;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraElectrolizer")]
	[CallsUnknownMethods(Count = 12)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "Initialize")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "OnAuroraElectrolizerEnableChanged")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "OnDisable")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(LensFlare), Member = "get_color")]
	[CallsUnknownMethods(Count = 104)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AuroraManager), Member = "GetRandomElectricalColor")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(AuroraManager), Member = "OnAuroraElectrolizerEnableChanged")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "Initialize")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	public void SetLocationDistances(bool useOutdoorValues)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsElectrolized()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetAuroraField(AuroraField auroraField)
	{
	}

	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "JobUpdate")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateElectrolyzerWithFarOptimization")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateElectrolyzerWithFarOptimization")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateFX")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "Initialize")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateIntensity")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "SetRandomType")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "SetRandomFlickerTime")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateLight")]
	public void ManualUpdate(float camDistSqr, float fadeIntensity, float auroraIntensity, float deltaTime, bool useLocalTimers)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	public void JobUpdate(float camDistSqr, float fadeIntensity, float auroraIntensity, float deltaTime, float4 timings, float priTimer)
	{
	}

	[CallerCount(Count = 0)]
	private void UpdateTimers(float4 timers, float primaryTimer)
	{
	}

	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "SetRandomType")]
	private void UpdateIntensity(float deltaTime, bool useLocalTimers)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateEmissiveObjects(bool allOff = false)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isStopped")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isStopped")]
	private void UpdateFX(bool allOff = false)
	{
	}

	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	private void UpdateLight(bool allOff = false)
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "UpdateIntensity")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void SetRandomType()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void SetRandomFlickerTime()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "Start")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateVisibility")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "OnDisable")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateFX")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateLight")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	public void StopAll()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCurrentLowThreshold()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetCurrentStableThreshold()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "UpdateAudio")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	public float GetIntensityNormalized()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetLightIntensity()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void SetExternalPowerState(bool isActive)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "GetIntensityNormalized")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	private void StopAudio()
	{
	}

	[CallsUnknownMethods(Count = 43)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public AuroraElectrolizer()
	{
	}
}
