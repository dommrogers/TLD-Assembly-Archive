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
		[CallerCount(Count = 80)]
		get
		{
			return null;
		}
		[CallerCount(Count = 279)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
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
	[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
	[CallsUnknownMethods(Count = 1)]
	public void Release()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LogHistogram()
	{
	}
}
