using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class LogHistogram
{
	public const int rangeMin = -9;

	public const int rangeMax = 9;

	private const int k_Bins = 128;

	private ComputeBuffer _003Cdata_003Ek__BackingField;

	public ComputeBuffer data
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		private set
		{
		}
	}

	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	public void Generate(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Release()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LogHistogram()
	{
	}
}
