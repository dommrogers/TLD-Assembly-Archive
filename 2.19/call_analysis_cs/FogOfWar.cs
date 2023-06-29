using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering;

public class FogOfWar : MonoBehaviour
{
	private Panel_Map m_Map;

	public UITexture m_ZoomDetailsUITexture;

	private Shader m_Shader;

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

	[DeduplicatedMethod]
	[CallerCount(Count = 86)]
	public void SetOwner(Panel_Map map)
	{
	}

	[CalledBy(Type = typeof(FogOfWar), Member = "OnEnable")]
	[CalledBy(Type = typeof(FogOfWar), Member = "ProcessList")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	private bool MaybeLoadTextureAsset(string filename, ref Texture2D texture)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FogOfWar), Member = "MaybeLoadTextureAsset")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(FogOfWar), Member = "RefreshCommandBuffer")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 8)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(CommandBuffer), Member = "Dispose")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear")]
	[Calls(Type = typeof(FogOfWar), Member = "RefreshCommandBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTexture), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "GetDetailLevelAlpha")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void ClearLastKnownPositionsList()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(FogOfWar), Member = "MaybeLoadTextureAsset")]
	[Calls(Type = typeof(FogOfWar), Member = "RefreshCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void ProcessList(List<DetailSurveyPosition> dsps, List<VistaLocationData> vistaLocations, float sceneRadius, float mapRadius)
	{
	}

	[CalledBy(Type = typeof(FogOfWar), Member = "OnEnable")]
	[CalledBy(Type = typeof(FogOfWar), Member = "Update")]
	[CalledBy(Type = typeof(FogOfWar), Member = "ProcessList")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(FogOfWar), Member = "UpdateShaderConstants")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	private void RefreshCommandBuffer(CommandBuffer commandBuffer, RenderTargetIdentifier renderTargetId, Texture2D map)
	{
	}

	[CalledBy(Type = typeof(FogOfWar), Member = "RefreshCommandBuffer")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateShaderConstants()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public FogOfWar()
	{
	}
}
