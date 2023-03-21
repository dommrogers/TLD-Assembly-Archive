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

		public AnimationCurve m_TODIntensityCurve;

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

		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetLightGroupCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void MarkProbesDirty()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(ExteriorLightingManager), Member = "BlendGlowCardProperties")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ExteriorLightingManager), Member = "UpdateLightProbes")]
	[Calls(Type = typeof(ExteriorLightingManager), Member = "BlendLightmaps")]
	[Calls(Type = typeof(ExteriorLightingManager), Member = "BlendParticleProperties")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(ExteriorLightingManager), Member = "MaybeAssignAmbientProbeAnchor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExteriorLightingManager), Member = "BlendLightProperties")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[Calls(Type = typeof(Renderer), Member = "set_probeAnchor")]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeAssignAmbientProbeAnchor()
	{
	}

	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "set_Item")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(LightmapSettings), Member = "get_lightProbes")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(LightmapSettings), Member = "get_lightProbes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed")]
	private void UpdateLightProbes()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(LightmapSettings), Member = "get_lightmaps")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(LightmapSettings), Member = "set_lightmaps")]
	[Calls(Type = typeof(Renderer), Member = "get_lightmapIndex")]
	[Calls(Type = typeof(Renderer), Member = "set_lightmapIndex")]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 20)]
	private void BlendLightmaps(Dictionary<Texture2D, HashSet<Renderer>> lightmapsToRenderers, float intensity, Color lightmapColor, Color minLightmapColor)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void BlendLightProperties(DarkLightingManager.LightDef[] lightDefinitions, float intensity, Color ambientColor, float ambientColorBlend, float ambientColorAdd)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	private void BlendParticleProperties(DarkLightingManager.ParticleDef[] particleDefinitions, float intensity)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ExteriorLightingManager), Member = "Update")]
	[Calls(Type = typeof(Renderer), Member = "get_enabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	private void BlendGlowCardProperties(DarkLightingManager.GlowObjectDef[] glowCardDefinitions, float intensity, Color ambientColor, float ambientColorBlend, float ambientColorAdd)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ExteriorLightingManager()
	{
	}
}
