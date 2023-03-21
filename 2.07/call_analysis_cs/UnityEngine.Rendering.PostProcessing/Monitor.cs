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
		[CallerCount(Count = 80)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 279)]
		[DeduplicatedMethod]
		protected set
		{
		}
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 101261)]
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal virtual bool NeedsHalfRes()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CalledBy(Type = typeof(HistogramMonitor), Member = "Render")]
	[CalledBy(Type = typeof(LightMeterMonitor), Member = "Render")]
	[CalledBy(Type = typeof(VectorscopeMonitor), Member = "Render")]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "Render")]
	[CallsUnknownMethods(Count = 6)]
	protected void CheckOutput(int width, int height)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	internal virtual void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	internal virtual void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	internal abstract void Render(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected Monitor()
	{
	}
}
