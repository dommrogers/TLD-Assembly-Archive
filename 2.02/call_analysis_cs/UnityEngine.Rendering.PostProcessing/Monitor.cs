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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		protected set
		{
		}
	}

	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "RenderMonitors")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "ShouldGenerateLogHistogram")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isAndroidOpenGL")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsRequestedAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal virtual bool NeedsHalfRes()
	{
		return false;
	}

	[CalledBy(Type = typeof(HistogramMonitor), Member = "Render")]
	[CalledBy(Type = typeof(LightMeterMonitor), Member = "Render")]
	[CalledBy(Type = typeof(VectorscopeMonitor), Member = "Render")]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "Render")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	protected void CheckOutput(int width, int height)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	internal virtual void OnEnable()
	{
	}

	[CalledBy(Type = typeof(HistogramMonitor), Member = "OnDisable")]
	[CalledBy(Type = typeof(VectorscopeMonitor), Member = "OnDisable")]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "OnDisable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void OnDisable()
	{
	}

	internal abstract void Render(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected Monitor()
	{
	}
}
