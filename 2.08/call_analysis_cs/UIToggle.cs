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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIToggle), Member = "Set")]
		set
		{
		}
	}

	public bool isChecked
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[Calls(Type = typeof(UIToggle), Member = "Set")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnClick()
	{
	}

	[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
	[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIToggle), Member = "set_value")]
	[CalledBy(Type = typeof(UIToggle), Member = "set_isChecked")]
	[CalledBy(Type = typeof(UIToggle), Member = "Start")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(Burns), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Burns), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "UpdateRemedyItems")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Finish")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	public void Set(bool state)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UIToggle()
	{
	}
}
