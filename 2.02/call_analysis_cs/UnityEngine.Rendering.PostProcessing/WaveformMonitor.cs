using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class WaveformMonitor : Monitor
{
	public float exposure;

	public int height;

	private ComputeBuffer m_Data;

	private const int k_ThreadGroupSize = 256;

	private const int k_ThreadGroupSizeX = 16;

	private const int k_ThreadGroupSizeY = 16;

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "OnDisable")]
	[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
	internal override void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal override bool NeedsHalfRes()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Monitor), Member = "CheckOutput")]
	[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	internal override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public WaveformMonitor()
	{
	}
}
