using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

public class DownsampleAurora : MonoBehaviour
{
	private enum Resolution
	{
		_1080p = 1080,
		_720p = 720,
		_480p = 480,
		_240p = 240,
		_135p = 135
	}

	private Resolution m_Resolution;

	private CameraEvent m_RenderOrder;

	private Shader m_EffectShader;

	private Shader m_DefaultShader;

	private Shader m_BlitShader;

	private Shader m_BlurShader;

	private float m_Alpha;

	private int m_BlurIterations;

	private float m_BlurSize;

	private List<SkinnedMeshRenderer> m_SkinnedMeshRenderers;

	private CommandBuffer m_CommandBuffer;

	private Camera m_Camera;

	private Material m_BlitMaterial;

	private Material m_BlurMaterial;

	private bool m_Initialized;

	private bool m_CommandBufferNeedsUpdate;

	private CameraEvent m_LastRenderOrder;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownsampleAurora), Member = "Initialize")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownsampleAurora), Member = "IsCommandBufferActive")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[Calls(Type = typeof(DownsampleAurora), Member = "RebuildCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownsampleAurora), Member = "Initialize")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[Calls(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 17)]
	public void Debug_ToggleEnable()
	{
	}

	[CalledBy(Type = typeof(AuroraBand), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial")]
	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	public void RegisterAurora(GameObject auroraGO)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void UnRegisterAurora(GameObject auroraGO)
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "OnDisable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DetachCommandBuffer()
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "OnEnable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ReattachCommandBuffer()
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "RebuildCommandBuffer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsCommandBufferActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "Start")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 25)]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DownsampleAurora), Member = "IsCommandBufferActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 39)]
	private void RebuildCommandBuffer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public DownsampleAurora()
	{
	}
}
