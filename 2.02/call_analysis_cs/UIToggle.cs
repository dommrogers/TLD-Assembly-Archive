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

	public bool isChecked
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(UIToggle), Member = "Set")]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public static UIToggle GetActiveToggle(int group)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnClick()
	{
	}

	[CalledBy(Type = typeof(UIToggle), Member = "set_value")]
	[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Finish")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIToggle), Member = "set_isChecked")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[CalledBy(Type = typeof(Burns), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "UpdateRemedyItems")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Burns), Member = "UpdateRemedyItems")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public void Set(bool state)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public UIToggle()
	{
	}
}
