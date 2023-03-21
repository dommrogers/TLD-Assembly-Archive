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
		[DeduplicatedMethod]
		[CallerCount(Count = 279)]
		protected set
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "ShouldGenerateLogHistogram")]
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
	[CallerCount(Count = 101262)]
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal virtual bool NeedsHalfRes()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(VectorscopeMonitor), Member = "Render")]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "Render")]
	[CalledBy(Type = typeof(LightMeterMonitor), Member = "Render")]
	[CalledBy(Type = typeof(HistogramMonitor), Member = "Render")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	protected void CheckOutput(int width, int height)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	internal virtual void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	internal virtual void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	internal abstract void Render(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected Monitor()
	{
	}
}
