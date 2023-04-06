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
		[CallerCount(Count = 92)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 281)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
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
