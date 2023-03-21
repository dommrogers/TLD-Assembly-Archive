using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIPlayAnimation : MonoBehaviour
{
	public static UIPlayAnimation current;

	public Animation target;

	public Animator animator;

	public string clipName;

	public Trigger trigger;

	public Direction playDirection;

	public bool resetOnPlay;

	public bool clearSelection;

	public EnableCondition ifDisabledOnPlay;

	public DisableCondition disableWhenFinished;

	public List<EventDelegate> onFinished;

	private GameObject eventReceiver;

	private string callWhenFinished;

	private bool mStarted;

	private bool mActivated;

	private bool dragHighlight;

	private bool dualState
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Remove")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	private void OnPress(bool isPressed)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDoubleClick()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	private void OnToggle()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDragOver()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDragOut()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	private void OnDrop(GameObject go)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Play(bool forward)
	{
	}

	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnPress")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnHover")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnEnable")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDoubleClick")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "PlayForward")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDrop")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDragOut")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnClick")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDragOver")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnToggle")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnSelect")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "PlayReverse")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Play(bool forward, bool onlyIfDifferent)
	{
	}

	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallerCount(Count = 0)]
	public void PlayForward()
	{
	}

	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallerCount(Count = 0)]
	public void PlayReverse()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallerCount(Count = 0)]
	private void OnFinished()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UIPlayAnimation()
	{
	}
}
