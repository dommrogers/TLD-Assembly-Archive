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
	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraElectrolizer")]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "OnAuroraElectrolizerEnableChanged")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "Start")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "OnDisable")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AuroraManager), Member = "GetRandomElectricalColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LensFlare), Member = "get_color")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 104)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "Initialize")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(AuroraManager), Member = "OnAuroraElectrolizerEnableChanged")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallerCount(Count = 2)]
	public void SetLocationDistances(bool useOutdoorValues)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsElectrolized()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetAuroraField(AuroraField auroraField)
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "JobUpdate")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateElectrolyzerWithFarOptimization")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "SetRandomFlickerTime")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "SetRandomType")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateIntensity")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateLight")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateFX")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "SetRandomType")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateIntensity(float deltaTime, bool useLocalTimers)
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HashSet<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateEmissiveObjects(bool allOff = false)
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isStopped")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private void UpdateFX(bool allOff = false)
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "StopAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 41)]
	private void UpdateLight(bool allOff = false)
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "UpdateIntensity")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void SetRandomType()
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	private void SetRandomFlickerTime()
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "Start")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "OnDisable")]
	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateVisibility")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateLight")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateFX")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StopAll()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCurrentLowThreshold()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetCurrentStableThreshold()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "UpdateAudio")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public float GetIntensityNormalized()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetLightIntensity()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void SetExternalPowerState(bool isActive)
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer), Member = "ManualUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(AuroraElectrolizer), Member = "GetIntensityNormalized")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StopAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 43)]
	public AuroraElectrolizer()
	{
	}
}
