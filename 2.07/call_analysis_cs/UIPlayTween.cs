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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(UIPlayTween), Member = "OnHover")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnEnable")]
	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void OnHover(bool isOver)
	{
	}

	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDragOut()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	private void OnPress(bool isPressed)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnClick()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	private void OnDoubleClick()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	private void OnSelect(bool isSelected)
	{
	}

	[Calls(Type = typeof(UIPlayTween), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnToggle()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "get_direction")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UITweener), Member = "Toggle")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnHover")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnDragOver")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnDragOut")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnPress")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnClick")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnDoubleClick")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnSelect")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnToggle")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	public void Play(bool forward)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallerCount(Count = 0)]
	private void OnFinished()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UIPlayTween()
	{
	}
}
