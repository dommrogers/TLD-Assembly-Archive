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
		[CallerCount(Count = 98)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 265)]
		protected set
		{
		}
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "ShouldGenerateLogHistogram")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isAndroidOpenGL")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "RenderMonitors")]
	public bool IsRequestedAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal virtual bool NeedsHalfRes()
	{
		return default(bool);
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "Render")]
	[CalledBy(Type = typeof(VectorscopeMonitor), Member = "Render")]
	[CalledBy(Type = typeof(LightMeterMonitor), Member = "Render")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(HistogramMonitor), Member = "Render")]
	protected void CheckOutput(int width, int height)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	internal virtual void OnEnable()
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 0)]
	internal virtual void OnDisable()
	{
	}

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	internal abstract void Render(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected Monitor()
	{
	}
}
