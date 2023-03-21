using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraElectrolizer_OneOff : MonoBehaviour
{
	public enum AuroraLightFlickerType_OneOff
	{
		None,
		SteadyOn,
		SingleFlicker,
		DoubleFlicker,
		CustomFlicker,
		RandomLerp,
		RandomSharp
	}

	[Serializable]
	public class ScaledCurve_OneOff
	{
		public AnimationCurve curve;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AnimationCurve), Member = "Linear")]
		public ScaledCurve_OneOff()
		{
		}
	}

	[Serializable]
	public class MinMax_OneOff
	{
		public float m_Min;

		public float m_Max;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public MinMax_OneOff()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public MinMax_OneOff(float min, float max)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public float GetMin()
		{
			return default(float);
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public float GetMax()
		{
			return default(float);
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public float GetMiddle()
		{
			return default(float);
		}
	}

	public float m_AuroraThreshold;

	public string m_Audio;

	public AuroraLightFlickerType_OneOff m_LightFlickerType;

	public Light m_LocalLight;

	public MinMax_OneOff m_LightPrimaryIntensity;

	public MinMax_OneOff m_LightSecondaryIntensity;

	public MinMax_OneOff m_LightPrimaryFrequency;

	public MinMax_OneOff m_LightSecondaryFrequency;

	public MinMax_OneOff m_LightNoiseFrequency;

	public ScaledCurve_OneOff m_LightCustomCurve;

	public bool m_LightRandomizePerEvent;

	public bool m_LightFadeWithAurora;

	public bool m_LightExludeSteady;

	public bool m_LightExludeSingle;

	public bool m_LightExludeDouble;

	public bool m_LightExludeCustom;

	public bool m_LightExludeRandomLerp;

	public bool m_LightExludeRandomSharp;

	public ParticleSystem m_LocalFX;

	public bool m_ParticlesScaleEmission;

	public Shader m_EmissiveShader;

	public float m_EmissiveBoost;

	private float m_AuroraLightFade;

	private float m_AuroraFXFade;

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

	private float m_FxInitialRate;

	private Material m_LocalMaterial;

	private uint m_AudioInstanceID;

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AuroraElectrolizer_OneOff), Member = "StopAll")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 77)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 55)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(AuroraElectrolizer_OneOff), Member = "UpdateFX")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AuroraElectrolizer_OneOff), Member = "UpdateLight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AuroraElectrolizer_OneOff), Member = "UpdateIntensity")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Update()
	{
	}

	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(AuroraElectrolizer_OneOff), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(AuroraElectrolizer_OneOff), Member = "SetRandomType")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	private void UpdateIntensity()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateMaterial()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(AuroraElectrolizer_OneOff), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	private void UpdateFX()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(AuroraElectrolizer_OneOff), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateLight()
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer_OneOff), Member = "UpdateIntensity")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	private void SetRandomType()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(AuroraElectrolizer_OneOff), Member = "Start")]
	[CallsUnknownMethods(Count = 14)]
	private void StopAll()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetLightIntensity()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraElectrolizer_OneOff()
	{
	}
}
