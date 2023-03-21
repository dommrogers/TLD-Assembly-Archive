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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Remove")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 6)]
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
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void OnToggle()
	{
	}

	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDragOver()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDragOut()
	{
	}

	[Calls(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDrop(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void Play(bool forward)
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnHover")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnPress")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnClick")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDoubleClick")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnSelect")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnToggle")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnToggle")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "PlayReverse")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "PlayForward")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDrop")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDragOut")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDragOver")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Reset")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 13)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private void OnFinished()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UIPlayAnimation()
	{
	}
}
