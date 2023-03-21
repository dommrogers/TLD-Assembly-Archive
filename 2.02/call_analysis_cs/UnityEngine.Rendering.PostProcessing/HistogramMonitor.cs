using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class HistogramMonitor : Monitor
{
	public enum Channel
	{
		Red,
		Green,
		Blue,
		Master
	}

	public int width;

	public int height;

	public Channel channel;

	private ComputeBuffer m_Data;

	private const int k_NumBins = 256;

	private const int k_ThreadGroupSizeX = 16;

	private const int k_ThreadGroupSizeY = 16;

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
	[Calls(Type = typeof(Monitor), Member = "OnDisable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal override void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
	[Calls(Type = typeof(Monitor), Member = "CheckOutput")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	internal override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public HistogramMonitor()
	{
	}
}
