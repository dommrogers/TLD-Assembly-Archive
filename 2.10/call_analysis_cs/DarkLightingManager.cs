using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DarkLightingManager : MonoBehaviour
{
	public enum UpdatePhase
	{
		Constant,
		Coloured,
		Night,
		NonTOD,
		Other
	}

	[Serializable]
	public struct LightDef
	{
		public Light m_Light;

		public float m_OrgIntensity;

		public Color m_OrgColour;

		public Vector3 m_Position;
	}

	[Serializable]
	public struct ParticleDef
	{
		public ParticleSystem m_Fx;

		public float m_OrgRate;
	}

	[Serializable]
	public struct GlowObjectDef
	{
		public Renderer m_Renderer;

		public Color m_OrgColour;
	}

	public bool m_ForceClearWeather;

	public bool m_ManualLighting;

	public float m_TimeOfDay;

	public GameObject m_ConstantLights;

	public GameObject m_ColourizedLights;

	public GameObject m_NightLights;

	public GameObject m_Particles;

	public GameObject m_Lightshafts;

	public List<MeshRenderer> m_GlowObjects;

	public MeshRenderer m_FakeSky;

	public InteriorWeatherController m_InteriorWeatherController;

	public float m_GlowColorization;

	public float m_LightColorization;

	public float m_AuroraColorization;

	public float m_AuroraRed;

	public float m_AuroraGreen;

	public float m_AuroraBlue;

	public float m_SunIntensityCorrection;

	public bool m_CorrectSunIntensity;

	public Color m_LightmapDayColorMultiplier;

	public Color m_LightmapNightColorMultiplier;

	private LightmapColorOverride[] m_LightmapColorOverrides;

	public bool m_UseDistanceFade;

	public List<Light> m_NonTodLights;

	public float m_UltraDistance;

	public float m_HighDistance;

	public float m_MediumDistance;

	public float m_LowDistance;

	public float m_FadePercentage;

	private TodAmbientLight m_AmbientLight;

	private List<LightDef> m_ConstantLightList;

	private List<LightDef> m_ColouredLightList;

	private List<LightDef> m_NightLightList;

	private List<LightDef> m_NonTodLightList;

	private List<ParticleDef> m_ParticleList;

	private List<GlowObjectDef> m_GlowObjectList;

	private List<LightShaftGimble> m_LightShaftList;

	private GlowObjectDef m_FakeSkyMat;

	private MaterialPropertyBlock m_GlowObjectPropertyBlock;

	private MaterialPropertyBlock m_FakeSkyPropertyBlock;

	private Color m_SunColour;

	private float m_SunIntensity;

	private float m_SunAverage;

	private float m_TodIntensity;

	private float m_AuroraFade;

	private float m_StarAlpha;

	private float m_MaxDistSqr;

	private float m_FadeDistSqr;

	private ScaledCurve m_DawnMorning;

	private ScaledCurve m_MorningMidday;

	private ScaledCurve m_MiddayAfternoon;

	private ScaledCurve m_AfternoonDusk;

	private UpdatePhase m_CurPhase;

	private QualityLodBias m_CachedQuality;

	private bool m_Initialized;

	private static readonly int s_ColorPropertyID;

	private static readonly int s_EmissiveStrengthPropertyID;

	private static readonly int s_SkyEmissivePropertyID;

	private static readonly int s_StarsEmissivePropertyID;

	private static readonly int s_TodBlendPropertyID;

	private static readonly float oneThird;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindAmbientLighting")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindConstantLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindColourizedLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindNightLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindOtherLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindGlowObjects")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindGimbleObjects")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindParticles")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateQualityValues")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrengthDefault")]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[CallsUnknownMethods(Count = 2)]
	private void FindAmbientLighting()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void FindConstantLights()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void FindColourizedLights()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void FindNightLights()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	private void FindOtherLights()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void FindParticles()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void FindGlowObjects()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void FindGimbleObjects()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallerCount(Count = 2)]
	private void UpdateQualityValues()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateQualityValues")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateIntensities")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateGlowObjects")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateGimbles")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateParticles")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InteriorWeatherController), Member = "SetInteriorWeather")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateNonTodLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateNightLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateConstantLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateLightmaps")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateColouredLights")]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateIntensities()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAmbient()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateConstantLights()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightmapColorOverride), Member = "IsEnabled")]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrength")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateLightmaps()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateColouredLights()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateNightLights()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateNonTodLights()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateGlowObjects()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateWeather")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateRotation")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateLight")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateFX")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateGimbles()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateParticles()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[CallsUnknownMethods(Count = 1)]
	private Color GetAuroraColours()
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	private float GetSunAverage(Color col, float lum)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 1)]
	private float GetTimeOfDayIntensity()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float NormalizedTod()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float DistanceToPlayer(Vector3 localPos, Vector3 camPos)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InteriorWeatherController), Member = "SetInteriorWeather")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeSetInteriorWeather()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	public DarkLightingManager()
	{
	}
}
