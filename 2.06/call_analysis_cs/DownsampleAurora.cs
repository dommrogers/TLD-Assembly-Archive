using System;
using System.Collections.Generic;
using System.Diagnostics;
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
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownsampleAurora), Member = "Initialize")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[Calls(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	public void Debug_ToggleEnable()
	{
	}

	[CalledBy(Type = typeof(AuroraBand), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial")]
	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public void RegisterAurora(GameObject auroraGO)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void UnRegisterAurora(GameObject auroraGO)
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "OnDisable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[CallsUnknownMethods(Count = 1)]
	private void DetachCommandBuffer()
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "OnEnable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CallsUnknownMethods(Count = 2)]
	private void ReattachCommandBuffer()
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "RebuildCommandBuffer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private bool IsCommandBufferActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "Start")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DownsampleAurora), Member = "IsCommandBufferActive")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 26)]
	private void RebuildCommandBuffer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public DownsampleAurora()
	{
	}
}
