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

	[Calls(Type = typeof(DarkLightingManager), Member = "FindGimbleObjects")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindParticles")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindGlowObjects")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindOtherLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateQualityValues")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindColourizedLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindConstantLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindAmbientLighting")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindNightLights")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrengthDefault")]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallsUnknownMethods(Count = 21)]
	private void FindConstantLights()
	{
	}

	[Calls(Type = typeof(Light), Member = "get_color")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void FindColourizedLights()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void FindNightLights()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Light), Member = "get_color")]
	private void FindOtherLights()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void FindParticles()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void FindGlowObjects()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void FindGimbleObjects()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallerCount(Count = 2)]
	private void UpdateQualityValues()
	{
	}

	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateColouredLights")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateLightmaps")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateConstantLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateNightLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateNonTodLights")]
	[Calls(Type = typeof(InteriorWeatherController), Member = "SetInteriorWeather")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateParticles")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateGlowObjects")]
	[Calls(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateIntensities")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateQualityValues")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateGimbles")]
	private void Update()
	{
	}

	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
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
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	private void UpdateConstantLights()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(LightmapColorOverride), Member = "IsEnabled")]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrength")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateLightmaps()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateColouredLights()
	{
	}

	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	private void UpdateNightLights()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	private void UpdateNonTodLights()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateGlowObjects()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateFX")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateWeather")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateRotation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightShaftGimble), Member = "UpdateLight")]
	private void UpdateGimbles()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateParticles()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[CallerCount(Count = 0)]
	private Color GetAuroraColours()
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	private float GetSunAverage(Color col, float lum)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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
	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	[CallerCount(Count = 0)]
	public DarkLightingManager()
	{
	}
}
