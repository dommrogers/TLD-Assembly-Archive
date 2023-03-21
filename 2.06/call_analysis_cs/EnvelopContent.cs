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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 1)]
	[ContextMenu("Execute")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[Calls(Type = typeof(NGUITools), Member = "IsChild")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(EnvelopContent), Member = "Start")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public void Execute()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public EnvelopContent()
	{
	}
}
