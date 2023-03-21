using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

public class DownsampleFX : MonoBehaviour
{
	private enum Resolution
	{
		_1080p = 1080,
		_720p = 720,
		_480p = 480,
		_240p = 240,
		_135p = 135
	}

	private static Dictionary<Resolution, int> s_ShaderRenderTextureIds;

	private Resolution m_Resolution;

	private CameraEvent m_RenderOrder;

	private Shader m_EffectShader;

	private Shader m_BlitShader;

	private Shader m_BlurShader;

	private float m_Alpha;

	private int m_BlurIterations;

	private float m_BlurSize;

	private bool m_UseWeaponViewCamera;

	private List<Renderer> m_ParticleRenderers;

	private CommandBuffer m_CommandBuffer;

	private Camera m_Camera;

	private Material m_DefaultEffectMaterial;

	private Material m_DownsampledEffectMaterial;

	private Material m_BlitMaterial;

	private Material m_BlurMaterial;

	private bool m_Initialized;

	private CameraEvent m_LastRenderOrder;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownsampleFX), Member = "Initialize")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownsampleFX), Member = "ReattachCommandBuffer")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownsampleFX), Member = "DetachCommandBuffer")]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(DownsampleFX), Member = "ReattachCommandBuffer")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DownsampleFX), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void DetachCommandBuffer()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DownsampleFX), Member = "DetachCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DownsampleFX), Member = "OnEnable")]
	[CalledBy(Type = typeof(DownsampleFX), Member = "Initialize")]
	[CallsUnknownMethods(Count = 6)]
	private void ReattachCommandBuffer()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(DownsampleFX), Member = "RebuildCommandBuffer")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(DownsampleFX), Member = "ReattachCommandBuffer")]
	[CalledBy(Type = typeof(DownsampleFX), Member = "Start")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name")]
	private void Initialize()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DownsampleFX), Member = "Initialize")]
	[CallsUnknownMethods(Count = 30)]
	private void RebuildCommandBuffer()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void TryToFindParticleRenderers()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterParticleSystem(ParticleSystem particleSystem)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ClearParticleRenderers()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public DownsampleFX()
	{
	}
}
