using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;

public class FogOfWar : MonoBehaviour
{
	public UITexture m_ZoomDetailsUITexture;

	private Shader m_Shader;

	private string m_AssetBundleFilename;

	private string m_MapBackgroundFilename;

	private string m_MapDetailsFilename;

	private string m_HeightmapFilename;

	private Vector2 m_DetailScale;

	private int m_FadeDistance;

	private Vector2 m_HeightmapOffset;

	private Vector2 m_HeightmapScale;

	private float m_TerrainPositionY;

	private float m_TerrainMaxHeight;

	private float m_VisibleHeightScalar;

	public Vector2 m_RangeBoostMinMaxHeight;

	public float m_RangeBoostMaxAmount;

	private Color m_RevealColor;

	private float m_RevealColorFadeTime;

	private bool m_RedrawEveryFrame;

	private bool m_ViewHeightmap;

	private Material m_Material;

	private RenderTexture m_RevealedMapTex;

	private RenderTargetIdentifier m_RevealedMapTargetId;

	private RenderTexture m_RevealedMapZoomDetailsTex;

	private RenderTargetIdentifier m_RevealedMapZoomDetailsTargetId;

	private AssetBundleRef m_AssetBundle;

	private Texture2D m_MapBackground;

	private Texture2D m_MapDetails;

	private Texture2D m_Heightmap;

	private Dictionary<string, Texture2D> m_VistaRevealMasks;

	private Camera m_Camera;

	private CommandBuffer m_CommandBuffer;

	private CommandBuffer m_CommandBufferZoomDetails;

	private int m_FrameIdForLastPositionAdded;

	private int m_FrameId;

	private bool m_Redraw;

	private List<DetailSurveyPosition> m_LastKnownSurveyPositions;

	private List<VistaLocationData> m_LastKnownVistaLocations;

	private float m_SceneRadius;

	private float m_MapRadius;

	public static readonly int s_HeightMapParamsID;

	public static readonly int s_VistaMaskID;

	public static readonly int s_VistaOffsetsID;

	public static readonly int s_RevealRatioID;

	private static readonly int s_DetailSurveyPositionID;

	private static readonly int s_HeightMapID;

	private static readonly int s_HeightMapScaleOffsetID;

	private static readonly int s_FadeDistanceID;

	private static readonly int s_RangeBoostParamsID;

	private static readonly int s_RevealColorID;

	private const int SURVEY_POSITION_PASS = 0;

	private const int VISTA_PASS = 1;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(FogOfWar), Member = "RefreshCommandBuffer")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 63)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(CommandBuffer), Member = "Dispose")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear")]
	[Calls(Type = typeof(FogOfWar), Member = "RefreshCommandBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTexture), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Map), Member = "GetDetailLevelAlpha")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ClearLastKnownPositionsList()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FogOfWar), Member = "RefreshCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void ProcessList(List<DetailSurveyPosition> dsps, List<VistaLocationData> vistaLocations, float sceneRadius, float mapRadius)
	{
	}

	[CalledBy(Type = typeof(FogOfWar), Member = "OnEnable")]
	[CalledBy(Type = typeof(FogOfWar), Member = "Update")]
	[CalledBy(Type = typeof(FogOfWar), Member = "ProcessList")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(FogOfWar), Member = "UpdateShaderConstants")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 17)]
	private void RefreshCommandBuffer(CommandBuffer commandBuffer, RenderTargetIdentifier renderTargetId, Texture2D map)
	{
	}

	[CalledBy(Type = typeof(FogOfWar), Member = "RefreshCommandBuffer")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateShaderConstants()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public FogOfWar()
	{
	}
}
