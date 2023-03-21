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

	[Calls(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	[Calls(Type = typeof(DownsampleAurora), Member = "Initialize")]
	[Conditional("__DEBUG")]
	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public void Debug_ToggleEnable()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(AuroraBand), Member = "Start")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void RegisterAurora(GameObject auroraGO)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public void UnRegisterAurora(GameObject auroraGO)
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "OnDisable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	private void DetachCommandBuffer()
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	private void ReattachCommandBuffer()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "RebuildCommandBuffer")]
	private bool IsCommandBufferActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Material), Member = "set_color")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(DownsampleAurora), Member = "IsCommandBufferActive")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	private void RebuildCommandBuffer()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DownsampleAurora()
	{
	}
}
