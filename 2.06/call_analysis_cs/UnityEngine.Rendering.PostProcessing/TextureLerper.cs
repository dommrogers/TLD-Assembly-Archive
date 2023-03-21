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
		[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(TextureLerper), Member = ".ctor")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(TextureLerper), Member = "get_instance")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private TextureLerper()
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal void BeginFrame(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	internal void EndFrame()
	{
	}

	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	[Calls(Type = typeof(RenderTexture), Member = "get_enableRandomWrite")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel")]
	[Calls(Type = typeof(RenderTexture), Member = "set_volumeDepth")]
	[Calls(Type = typeof(RenderTexture), Member = "set_enableRandomWrite")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = false, bool force3D = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[Calls(Type = typeof(Texture3D), Member = "get_depth")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "GetUncompressedRenderTextureFormat")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 10)]
	internal Texture Lerp(Texture from, Texture to, float t)
	{
		return null;
	}

	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth")]
	[Calls(Type = typeof(Texture3D), Member = "get_depth")]
	[Calls(Type = typeof(TextureLerper), Member = "Get")]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "GetUncompressedRenderTextureFormat")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 8)]
	internal Texture Lerp(Texture from, Color to, float t)
	{
		return null;
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 7)]
	internal void Clear()
	{
	}
}
