using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CenterContents : MonoBehaviour
{
	public Transform targetRoot;

	public int padLeft;

	public int padRight;

	public int padBottom;

	public int padTop;

	private bool mStarted;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CenterContents), Member = "LateUpdate")]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(CenterContents), Member = "Start")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(NGUITools), Member = "IsChild")]
	[CallerCount(Count = 1)]
	[ContextMenu("Execute")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	public void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CenterContents()
	{
	}
}
