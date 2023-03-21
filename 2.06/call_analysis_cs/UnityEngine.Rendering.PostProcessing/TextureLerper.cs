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
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
		[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
		[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
		[Calls(Type = typeof(TextureLerper), Member = ".ctor")]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(TextureLerper), Member = "get_instance")]
	[CallsUnknownMethods(Count = 11)]
	private TextureLerper()
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	internal void BeginFrame(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 12)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	internal void EndFrame()
	{
	}

	[Calls(Type = typeof(RenderTexture), Member = "set_volumeDepth")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RenderTexture), Member = "set_enableRandomWrite")]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel")]
	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RenderTexture), Member = "get_enableRandomWrite")]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = false, bool force3D = false)
	{
		return null;
	}

	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "GetUncompressedRenderTextureFormat")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Texture3D), Member = "get_depth")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	internal Texture Lerp(Texture from, Texture to, float t)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "GetUncompressedRenderTextureFormat")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[Calls(Type = typeof(Texture3D), Member = "get_depth")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	internal Texture Lerp(Texture from, Color to, float t)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 7)]
	internal void Clear()
	{
	}
}
