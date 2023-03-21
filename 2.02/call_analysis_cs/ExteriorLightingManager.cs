using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;

public class ExteriorLightingManager : MonoBehaviour
{
	[Serializable]
	public struct LightmapRendererDefinition
	{
		public Renderer m_Renderer;

		public Texture2D m_Lightmap;
	}

	[Serializable]
	public class LightGroup
	{
		public string m_Name;

		public Transform m_GroupParent;

		public TODBlendState m_StartTODTransition;

		public TODBlendState m_EndTODTransition;

		public float m_AmbientColorBlend;

		public float m_AmbientColorAdd;

		public Transform m_LightmappedMeshParent;

		public bool m_UseBakedAmbientColor;

		public Color m_BakedAmbientColor;

		public Color m_LightmapColor;

		public Color m_MinLightmapColor;

		public DarkLightingManager.LightDef[] m_Lights;

		public DarkLightingManager.ParticleDef[] m_Particles;

		public DarkLightingManager.GlowObjectDef[] m_GlowCards;

		public LightmapRendererDefinition[] m_LightmappedRenderers;

		public Texture2D[] m_Lightmaps;

		public float[] m_ProbeData;

		[NonSerialized]
		public Dictionary<Texture2D, HashSet<Renderer>> m_LightmapToRenderers;

		[CallerCount(Count = 0)]
		public LightGroup()
		{
		}
	}

	public bool m_IsInLightmapMode;

	private LightGroup[] m_LightGroups;

	private LightProbeGroup[] m_ExteriorProbeGroups;

	private Transform m_AmbientProbeAnchor;

	private Transform[] m_UnlitStaticGeoRoots;

	private LightDistanceCull m_LightCullComponent;

	private ParticleDistanceCull m_ParticleCullComponent;

	public static bool s_DebugProbeUpdatesDisabled;

	private const int SH_BANDS = 3;

	private const int SH_COEFFICIENTS = 9;

	private const float PROBE_UPDATE_PER_FRAME_MS = 0.2f;

	private const float LIGHTMAP_INTENSITY_UPDATE_THRESHOLD = 0.005f;

	private const string BAKE_DIALOG_TITLE = "Baking Lightmaps";

	private static readonly int s_LightingStrengthPropertyID;

	private static readonly int s_TintColorPropertyID;

	private MaterialPropertyBlock m_PropertyBlock;

	private Dictionary<Texture2D, int> m_LightmapIndices;

	private LightGroup m_LastLightmapGroup;

	private float m_LastLightmapIntensity;

	private static ExteriorLightingManager s_ProbeManager;

	private LightGroup m_ProbeGroup;

	private float m_ProbeIntensity;

	private SphericalHarmonicsL2[] m_Probes;

	private bool m_ShouldAssignAmbientProbeAnchor;

	private int m_LastProbeUpdateIndex;

	private Stopwatch m_ProbeUpdateStopWatch;

	private bool m_UpdateAllProbes;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetLightGroupCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	public static void MarkProbesDirty()
	{
	}

	[CallsUnknownMethods(Count = 66)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(ExteriorLightingManager), Member = "BlendGlowCardProperties")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(ExteriorLightingManager), Member = "BlendLightmaps")]
	[Calls(Type = typeof(ExteriorLightingManager), Member = "BlendParticleProperties")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ExteriorLightingManager), Member = "UpdateLightProbes")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExteriorLightingManager), Member = "BlendLightProperties")]
	[Calls(Type = typeof(ExteriorLightingManager), Member = "MaybeAssignAmbientProbeAnchor")]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(Renderer), Member = "set_probeAnchor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void MaybeAssignAmbientProbeAnchor()
	{
	}

	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "set_Item")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(LightmapSettings), Member = "get_lightProbes")]
	[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RenderSettings), Member = "get_ambientProbe")]
	[Calls(Type = typeof(LightmapSettings), Member = "get_lightProbes")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void UpdateLightProbes()
	{
	}

	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(Renderer), Member = "set_lightmapIndex")]
	[Calls(Type = typeof(Renderer), Member = "get_lightmapIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(LightmapSettings), Member = "set_lightmaps")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(LightmapSettings), Member = "get_lightmaps")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	private void BlendLightmaps(Dictionary<Texture2D, HashSet<Renderer>> lightmapsToRenderers, float intensity, Color lightmapColor, Color minLightmapColor)
	{
	}

	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void BlendLightProperties(DarkLightingManager.LightDef[] lightDefinitions, float intensity, Color ambientColor, float ambientColorBlend, float ambientColorAdd)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	private void BlendParticleProperties(DarkLightingManager.ParticleDef[] particleDefinitions, float intensity)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Renderer), Member = "get_enabled")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void BlendGlowCardProperties(DarkLightingManager.GlowObjectDef[] glowCardDefinitions, float intensity, Color ambientColor, float ambientColorBlend, float ambientColorAdd)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public ExteriorLightingManager()
	{
	}
}
