using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIPlayTween : MonoBehaviour
{
	public static UIPlayTween current;

	public GameObject tweenTarget;

	public int tweenGroup;

	public Trigger trigger;

	public Direction playDirection;

	public bool resetOnPlay;

	public bool resetIfDisabled;

	public EnableCondition ifDisabledOnPlay;

	public DisableCondition disableWhenFinished;

	public bool includeChildren;

	public List<EventDelegate> onFinished;

	private GameObject eventReceiver;

	private string callWhenFinished;

	private UITweener[] mTweens;

	private bool mStarted;

	private int mActive;

	private bool mActivated;

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UIPlayTween), Member = "OnHover")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(EventDelegate), Member = "Remove")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDragOver()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnEnable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	private void OnHover(bool isOver)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDragOut()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	private void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	private void OnClick()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDoubleClick()
	{
	}

	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnToggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(UIPlayTween), Member = "OnDoubleClick")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnSelect")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnClick")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnPress")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnDragOut")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnHover")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UITweener), Member = "Toggle")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnDragOver")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public void Play(bool forward)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private void OnFinished()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UIPlayTween()
	{
	}
}
