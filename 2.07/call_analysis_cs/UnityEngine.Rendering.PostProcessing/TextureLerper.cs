using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal class TextureLerper
{
	private static TextureLerper m_Instance;

	private CommandBuffer m_Command;

	private PropertySheetFactory m_PropertySheets;

	private PostProcessResources m_Resources;

	private List<RenderTexture> m_Recycled;

	private List<RenderTexture> m_Actives;

	internal static TextureLerper instance
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
		[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
		[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
		[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private TextureLerper()
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 1)]
	internal void BeginFrame(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	internal void EndFrame()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RenderTexture), Member = "set_enableRandomWrite")]
	[Calls(Type = typeof(RenderTexture), Member = "set_volumeDepth")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(RenderTexture), Member = "get_enableRandomWrite")]
	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel")]
	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = false, bool force3D = false)
	{
		return null;
	}

	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "GetUncompressedRenderTextureFormat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[Calls(Type = typeof(Texture3D), Member = "get_depth")]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	internal Texture Lerp(Texture from, Texture to, float t)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "GetUncompressedRenderTextureFormat")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[Calls(Type = typeof(Texture3D), Member = "get_depth")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	internal Texture Lerp(Texture from, Color to, float t)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 1)]
	internal void Clear()
	{
	}
}
