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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnvelopContent), Member = "Execute")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "IsChild")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(EnvelopContent), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContextMenu("Execute")]
	public void Execute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public EnvelopContent()
	{
	}
}
