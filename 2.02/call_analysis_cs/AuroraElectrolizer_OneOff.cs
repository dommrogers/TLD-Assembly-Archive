using System;
using System.Collections.Generic;
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
			return 0f;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public float GetMax()
		{
			return 0f;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public float GetMiddle()
		{
			return 0f;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(AuroraElectrolizer_OneOff), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 45)]
	[CallsUnknownMethods(Count = 77)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraElectrolizer_OneOff), Member = "UpdateIntensity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AuroraElectrolizer_OneOff), Member = "UpdateLight")]
	[Calls(Type = typeof(AuroraElectrolizer_OneOff), Member = "UpdateFX")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer_OneOff), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraElectrolizer_OneOff), Member = "SetRandomType")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	private void UpdateIntensity()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateMaterial()
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer_OneOff), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateFX()
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer_OneOff), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateLight()
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer_OneOff), Member = "UpdateIntensity")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void SetRandomType()
	{
	}

	[CalledBy(Type = typeof(AuroraElectrolizer_OneOff), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	private void StopAll()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetLightIntensity()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	public AuroraElectrolizer_OneOff()
	{
	}
}
