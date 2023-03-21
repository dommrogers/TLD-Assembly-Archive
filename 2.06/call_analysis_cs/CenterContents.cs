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

	[CalledBy(Type = typeof(CenterContents), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[ContextMenu("Execute")]
	[Calls(Type = typeof(NGUITools), Member = "IsChild")]
	public void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public CenterContents()
	{
	}
}
