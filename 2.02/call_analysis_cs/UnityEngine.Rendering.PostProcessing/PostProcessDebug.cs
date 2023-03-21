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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessDebug), Member = "UpdateStates")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Reset()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "Update")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RequestMonitorPass")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RequestMonitorPass")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RequestMonitorPass")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RequestMonitorPass")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	private void UpdateStates()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	private void OnPostRender()
	{
	}

	[Calls(Type = typeof(PostProcessDebug), Member = "DrawMonitor")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PostProcessDebug), Member = "DrawMonitor")]
	[Calls(Type = typeof(PostProcessDebug), Member = "DrawMonitor")]
	[Calls(Type = typeof(PostProcessDebug), Member = "DrawMonitor")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GUI), Member = "DrawTexture")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "OnGUI")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "OnGUI")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "OnGUI")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "OnGUI")]
	[CallsUnknownMethods(Count = 4)]
	private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PostProcessDebug()
	{
	}
}
