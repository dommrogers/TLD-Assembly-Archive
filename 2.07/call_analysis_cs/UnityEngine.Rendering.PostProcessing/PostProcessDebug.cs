using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessDebug : MonoBehaviour
{
	public PostProcessLayer postProcessLayer;

	private PostProcessLayer m_PreviousPostProcessLayer;

	public bool lightMeter;

	public bool histogram;

	public bool waveform;

	public bool vectorscope;

	public DebugOverlay debugOverlay;

	private Camera m_CurrentCamera;

	private CommandBuffer m_CmdAfterEverything;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessDebug), Member = "UpdateStates")]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Reset()
	{
	}

	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RequestMonitorPass")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RequestMonitorPass")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "Update")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RequestMonitorPass")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RequestMonitorPass")]
	private void UpdateStates()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	private void OnPostRender()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessDebug), Member = "DrawMonitor")]
	[Calls(Type = typeof(PostProcessDebug), Member = "DrawMonitor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessDebug), Member = "DrawMonitor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessDebug), Member = "DrawMonitor")]
	private void OnGUI()
	{
	}

	[CalledBy(Type = typeof(PostProcessDebug), Member = "OnGUI")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "OnGUI")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "OnGUI")]
	[Calls(Type = typeof(GUI), Member = "DrawTexture")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "OnGUI")]
	private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PostProcessDebug()
	{
	}
}
