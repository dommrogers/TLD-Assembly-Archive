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

	[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
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
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
	[Calls(Type = typeof(Monitor), Member = "CheckOutput")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
	[CallsUnknownMethods(Count = 18)]
	internal override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public HistogramMonitor()
	{
	}
}
