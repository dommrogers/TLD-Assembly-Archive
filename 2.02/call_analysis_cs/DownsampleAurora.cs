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

	[Calls(Type = typeof(DownsampleAurora), Member = "Initialize")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DownsampleAurora), Member = "RebuildCommandBuffer")]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[Calls(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[Calls(Type = typeof(DownsampleAurora), Member = "IsCommandBufferActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[Calls(Type = typeof(Material), Member = "set_shader")]
	[Calls(Type = typeof(DownsampleAurora), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallsUnknownMethods(Count = 17)]
	public void Debug_ToggleEnable()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(AuroraBand), Member = "Start")]
	[Calls(Type = typeof(Material), Member = "SetShaderPassEnabled")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial")]
	public void RegisterAurora(GameObject auroraGO)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	public void UnRegisterAurora(GameObject auroraGO)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "ReattachCommandBuffer")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "OnDisable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	private void DetachCommandBuffer()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DownsampleAurora), Member = "DetachCommandBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "OnEnable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CallsUnknownMethods(Count = 3)]
	private void ReattachCommandBuffer()
	{
	}

	[CalledBy(Type = typeof(DownsampleAurora), Member = "RebuildCommandBuffer")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private bool IsCommandBufferActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Debug_ToggleEnable")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Start")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DownsampleAurora), Member = "Update")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DownsampleAurora), Member = "IsCommandBufferActive")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	private void RebuildCommandBuffer()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public DownsampleAurora()
	{
	}
}
