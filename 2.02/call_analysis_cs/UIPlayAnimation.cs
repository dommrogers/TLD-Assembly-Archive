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

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(EventDelegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnHover(bool isOver)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	private void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDoubleClick()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void OnSelect(bool isSelected)
	{
	}

	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnToggle()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	private void OnDragOver()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnDragOut()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void OnDrop(GameObject go)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Play(bool forward)
	{
	}

	[Calls(Type = typeof(ActiveAnimation), Member = "Reset")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnHover")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnClick")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDrop")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDragOut")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnPress")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDragOver")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnToggle")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnSelect")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDoubleClick")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "PlayReverse")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "PlayForward")]
	public void Play(bool forward, bool onlyIfDifferent)
	{
	}

	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallerCount(Count = 0)]
	public void PlayForward()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	public void PlayReverse()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void OnFinished()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public UIPlayAnimation()
	{
	}
}
