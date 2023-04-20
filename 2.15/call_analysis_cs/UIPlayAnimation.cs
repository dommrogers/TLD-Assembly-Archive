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
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(EventDelegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDoubleClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnToggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDragOver()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDragOut()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDrop(GameObject go)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Play(bool forward)
	{
	}

	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnHover")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnPress")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnClick")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDoubleClick")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnSelect")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnToggle")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDragOver")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDragOut")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDrop")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "PlayForward")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "PlayReverse")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Reset")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Play(bool forward, bool onlyIfDifferent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	public void PlayForward()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	public void PlayReverse()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void OnFinished()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public UIPlayAnimation()
	{
	}
}
