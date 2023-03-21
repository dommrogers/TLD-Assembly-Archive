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
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateQualityValues")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindParticles")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindGlowObjects")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindColourizedLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindNightLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindConstantLights")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DarkLightingManager), Member = "FindOtherLights")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrengthDefault")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void FindAmbientLighting()
	{
	}

	[CallsUnknownMethods(Count = 49)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void FindConstantLights()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	private void FindColourizedLights()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 53)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput")]
	private void FindNightLights()
	{
	}

	[CallsUnknownMethods(Count = 45)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void FindOtherLights()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void FindParticles()
	{
	}

	[CallsUnknownMethods(Count = 48)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void FindGlowObjects()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	private void FindGimbleObjects()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Start")]
	private void UpdateQualityValues()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateColouredLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateLightmaps")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateConstantLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateNightLights")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateNonTodLights")]
	[Calls(Type = typeof(InteriorWeatherController), Member = "SetInteriorWeather")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateParticles")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateGimbles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateIntensities")]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateQualityValues")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DarkLightingManager), Member = "UpdateGlowObjects")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(DarkLightingManager), Member = "GetTimeOfDayIntensity")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void UpdateIntensities()
	{
	}

	[Calls(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateAmbient()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private void UpdateConstantLights()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrength")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightmapColorOverride), Member = "IsEnabled")]
	private void UpdateLightmaps()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void UpdateColouredLights()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void UpdateNightLights()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	private void UpdateNonTodLights()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	private void UpdateGlowObjects()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightShaftGimble), Member = "ManualUpdate")]
	private void UpdateGimbles()
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateParticles()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private Color GetAuroraColours()
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetSunAverage(Color col, float lum)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateIntensities")]
	[CallsUnknownMethods(Count = 10)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InteriorWeatherController), Member = "SetInteriorWeather")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeSetInteriorWeather()
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(ScaledCurve), Member = ".ctor")]
	[Calls(Type = typeof(ScaledCurve), Member = ".ctor")]
	[Calls(Type = typeof(ScaledCurve), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScaledCurve), Member = ".ctor")]
	public DarkLightingManager()
	{
	}
}
