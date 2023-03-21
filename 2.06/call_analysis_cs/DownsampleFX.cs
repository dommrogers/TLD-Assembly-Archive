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

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(DownsampleFX), Member = "ReattachCommandBuffer")]
	[CalledBy(Type = typeof(DownsampleFX), Member = "OnDisable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	private void DetachCommandBuffer()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DownsampleFX), Member = "OnEnable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(DownsampleFX), Member = "Initialize")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(DownsampleFX), Member = "DetachCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void ReattachCommandBuffer()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(DownsampleFX), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(DownsampleFX), Member = "RebuildCommandBuffer")]
	[Calls(Type = typeof(DownsampleFX), Member = "ReattachCommandBuffer")]
	[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "set_color")]
	private void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(DownsampleFX), Member = "Initialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	private void RebuildCommandBuffer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
	private void TryToFindParticleRenderers()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Breath), Member = "Update")]
	public void RegisterParticleSystem(ParticleSystem particleSystem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearParticleRenderers()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public DownsampleFX()
	{
	}
}
