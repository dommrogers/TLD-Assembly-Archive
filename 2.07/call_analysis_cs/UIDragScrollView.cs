using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragScrollView : MonoBehaviour
{
	public UIScrollView scrollView;

	private UIScrollView draggablePanel;

	private Transform mTrans;

	private UIScrollView mScroll;

	private bool mAutoFind;

	private bool mStarted;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIDragScrollView), Member = "FindScrollView")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UIDragScrollView), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void FindScrollView()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIScrollView), Member = "Press")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void OnPress(bool pressed)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIScrollView), Member = "Drag")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void OnScroll(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIDragScrollView()
	{
	}
}
