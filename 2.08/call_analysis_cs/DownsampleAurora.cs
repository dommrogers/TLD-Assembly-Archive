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

	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[Calls(Type = typeof(DownsampleAurora), Member = "RebuildCommandBuffer")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(DownsampleAurora), Member = "IsCommandBufferActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[Calls(Type = typeof(DownsampleAurora), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	public void Debug_ToggleEnable()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AuroraBand), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public void RegisterAurora(GameObject auroraGO)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(AuroraBand), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 2)]
	public void UnRegisterAurora(GameObject auroraGO)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "OnDisable")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	private void DetachCommandBuffer()
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "OnEnable")]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	private void ReattachCommandBuffer()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "RebuildCommandBuffer")]
	private bool IsCommandBufferActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "set_color")]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer")]
	[Calls(Type = typeof(DownsampleAurora), Member = "IsCommandBufferActive")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 1)]
	private void RebuildCommandBuffer()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public DownsampleAurora()
	{
	}
}
