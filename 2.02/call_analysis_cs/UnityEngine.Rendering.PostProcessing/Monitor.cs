using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public abstract class Monitor
{
	private RenderTexture _003Coutput_003Ek__BackingField;

	internal bool requested;

	public RenderTexture output
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		protected set
		{
		}
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isAndroidOpenGL")]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "RenderMonitors")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "ShouldGenerateLogHistogram")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsRequestedAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual bool NeedsHalfRes()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CalledBy(Type = typeof(HistogramMonitor), Member = "Render")]
	[CalledBy(Type = typeof(LightMeterMonitor), Member = "Render")]
	[CalledBy(Type = typeof(VectorscopeMonitor), Member = "Render")]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "Render")]
	protected void CheckOutput(int width, int height)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal virtual void OnEnable()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CalledBy(Type = typeof(HistogramMonitor), Member = "OnDisable")]
	[CalledBy(Type = typeof(VectorscopeMonitor), Member = "OnDisable")]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "OnDisable")]
	internal virtual void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	internal abstract void Render(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected Monitor()
	{
	}
}
