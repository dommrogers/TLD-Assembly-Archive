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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[CalledBy(Type = typeof(CenterContents), Member = "Start")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 11)]
	[ContextMenu("Execute")]
	[Calls(Type = typeof(NGUITools), Member = "IsChild")]
	[CallerCount(Count = 1)]
	public void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CenterContents()
	{
	}
}
