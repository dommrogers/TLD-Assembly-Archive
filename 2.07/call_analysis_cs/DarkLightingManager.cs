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

	[Calls(Type = typeof(DarkLightingManager), Member = "FindParticles")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateQualityValues")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindGimbleObjects")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindOtherLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindGlowObjects")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindColourizedLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindConstantLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindAmbientLighting")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindNightLights")]
	private void Start()
	{
	}

	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrengthDefault")]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void FindAmbientLighting()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void FindConstantLights()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallsUnknownMethods(Count = 9)]
	private void FindColourizedLights()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[CallsUnknownMethods(Count = 9)]
	private void FindNightLights()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 15)]
	private void FindOtherLights()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void FindParticles()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallsUnknownMethods(Count = 10)]
	private void FindGlowObjects()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void FindGimbleObjects()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	private void UpdateQualityValues()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateLightmaps")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateConstantLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateNightLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateNonTodLights")]
	[Calls(Type = typeof(InteriorWeatherController), Member = "SetInteriorWeather")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateParticles")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateColouredLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateGlowObjects")]
	[Calls(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateIntensities")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateQualityValues")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateGimbles")]
	private void Update()
	{
	}

	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
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

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateConstantLights()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightmapColorOverride), Member = "IsEnabled")]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrength")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateLightmaps()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	private void UpdateColouredLights()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private void UpdateNightLights()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateNonTodLights()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	private void UpdateGlowObjects()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateFX")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateLight")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateRotation")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateWeather")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateMaterial")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateGimbles()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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
		return default(float);
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	private float GetTimeOfDayIntensity()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float NormalizedTod()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float DistanceToPlayer(Vector3 localPos, Vector3 camPos)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InteriorWeatherController), Member = "SetInteriorWeather")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeSetInteriorWeather()
	{
	}

	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	public DarkLightingManager()
	{
	}
}
