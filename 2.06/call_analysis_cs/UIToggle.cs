using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIToggle : UIWidgetContainer
{
	public delegate bool Validate(bool choice);

	public static BetterList<UIToggle> list;

	public static UIToggle current;

	public int group;

	public UIWidget activeSprite;

	public UIWidget inactiveSprite;

	public Animation activeAnimation;

	public Animator animator;

	public bool startsActive;

	public bool instantTween;

	public bool optionCanBeNone;

	public List<EventDelegate> onChange;

	public Validate validator;

	private UISprite checkSprite;

	private Animation checkAnimation;

	private GameObject eventReceiver;

	private string functionName;

	private bool startsChecked;

	private bool mIsActive;

	private bool mStarted;

	private float activeSpriteAlpha;

	private float inactiveSpriteAlpha;

	public bool value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[Calls(Type = typeof(UIToggle), Member = "Set")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool isChecked
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIToggle), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static UIToggle GetActiveToggle(int group)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnClick()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Finish")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIToggle), Member = "set_isChecked")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(UIToggle), Member = "set_value")]
	[CalledBy(Type = typeof(Burns), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Burns), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(UIToggle), Member = "Start")]
	[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	public void Set(bool state)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public UIToggle()
	{
	}
}
