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

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIDragScrollView), Member = "FindScrollView")]
	private void OnEnable()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(UIDragScrollView), Member = "OnEnable")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void FindScrollView()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIScrollView), Member = "Press")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void OnPress(bool pressed)
	{
	}

	[Calls(Type = typeof(UIScrollView), Member = "Drag")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDrag(Vector2 delta)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnScroll(float delta)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIDragScrollView()
	{
	}
}
