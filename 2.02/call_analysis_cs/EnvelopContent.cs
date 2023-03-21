using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EnvelopContent : MonoBehaviour
{
	public Transform targetRoot;

	public int padLeft;

	public int padRight;

	public int padBottom;

	public int padTop;

	private bool mStarted;

	[Calls(Type = typeof(EnvelopContent), Member = "Execute")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(EnvelopContent), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "IsChild")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	public void Execute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EnvelopContent()
	{
	}
}
