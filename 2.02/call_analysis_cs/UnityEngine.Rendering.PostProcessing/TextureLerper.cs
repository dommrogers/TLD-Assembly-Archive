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
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
		[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
		[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
		[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
		[Calls(Type = typeof(TextureLerper), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 10)]
		[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(TextureLerper), Member = "get_instance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	internal void EndFrame()
	{
	}

	[Calls(Type = typeof(Texture), Member = "set_anisoLevel")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RenderTexture), Member = "set_enableRandomWrite")]
	[Calls(Type = typeof(RenderTexture), Member = "set_volumeDepth")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(RenderTexture), Member = "get_enableRandomWrite")]
	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = false, bool force3D = false)
	{
		return null;
	}

	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "GetUncompressedRenderTextureFormat")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[Calls(Type = typeof(Texture3D), Member = "get_depth")]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	internal Texture Lerp(Texture from, Texture to, float t)
	{
		return null;
	}

	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "GetUncompressedRenderTextureFormat")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[Calls(Type = typeof(Texture3D), Member = "get_depth")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	internal Texture Lerp(Texture from, Color to, float t)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 1)]
	internal void Clear()
	{
	}
}
