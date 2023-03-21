using System;
using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class UITweener : MonoBehaviour
{
	public enum Method
	{
		Linear,
		EaseIn,
		EaseOut,
		EaseInOut,
		BounceIn,
		BounceOut
	}

	public enum Style
	{
		Once,
		Loop,
		PingPong
	}

	public static UITweener current;

	public Method method;

	public Style style;

	public AnimationCurve animationCurve;

	public bool ignoreTimeScale;

	public float delay;

	public float duration;

	public bool steeperCurves;

	public int tweenGroup;

	public bool doNotResetOnDisable;

	public List<EventDelegate> onFinished;

	public GameObject eventReceiver;

	public string callWhenFinished;

	private bool mStarted;

	private float mStartTime;

	private float mDuration;

	private float mAmountPerDelta;

	private float mFactor;

	private List<EventDelegate> mTemp;

	public float amountPerDelta
	{
		[CallerCount(Count = 72)]
		get
		{
			return 0f;
		}
	}

	public float tweenFactor
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Direction direction
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
		get
		{
			return default(Direction);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	protected virtual void Start()
	{
	}

	[CalledBy(Type = typeof(UITweener), Member = "Start")]
	[CalledBy(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(UITweener), Member = "PlayForward")]
	[CalledBy(Type = typeof(UITweener), Member = "PlayReverse")]
	[CalledBy(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CalledBy(Type = typeof(GearMessage), Member = "ShowNextMessageInQueue")]
	[CalledBy(Type = typeof(HUDChapter), Member = "Enqueue")]
	[CalledBy(Type = typeof(ObjectiveInfoDisplay), Member = "Show")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "StartBuffNotificationTweeens")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "SetLoadingScreenText")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	public void SetOnFinished(EventDelegate.Callback del)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetOnFinished(EventDelegate del)
	{
	}

	[CalledBy(Type = typeof(HUDChapter), Member = "Awake")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Awake")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Awake")]
	[CalledBy(Type = typeof(ObjectiveInfoDisplay), Member = "Awake")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	public void AddOnFinished(EventDelegate.Callback del)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	public void AddOnFinished(EventDelegate del)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	public void RemoveOnFinished(EventDelegate del)
	{
	}

	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 91)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void Sample(float factor, bool isFinished)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	private float BounceLogic(float val)
	{
		return 0f;
	}

	[Obsolete("Use PlayForward() instead")]
	[DeduplicatedMethod]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Play()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void PlayForward()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void PlayReverse()
	{
	}

	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Play(bool forward)
	{
	}

	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Hide")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Show")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DoTap")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	public void ResetToBeginning()
	{
	}

	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsUnknownMethods(Count = 1)]
	public void Toggle()
	{
	}

	protected abstract void OnUpdate(float factor, bool isFinished);

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(TweenAlpha), Member = "Begin")]
	[CalledBy(Type = typeof(TweenColor), Member = "Begin")]
	[CalledBy(Type = typeof(TweenFOV), Member = "Begin")]
	[CalledBy(Type = typeof(TweenHeight), Member = "Begin")]
	[CalledBy(Type = typeof(TweenOrthoSize), Member = "Begin")]
	[CalledBy(Type = typeof(TweenPosition), Member = "Begin")]
	[CalledBy(Type = typeof(TweenPosition), Member = "Begin")]
	[CalledBy(Type = typeof(TweenRotation), Member = "Begin")]
	[CalledBy(Type = typeof(TweenScale), Member = "Begin")]
	[CalledBy(Type = typeof(TweenTransform), Member = "Begin")]
	[CalledBy(Type = typeof(TweenTransform), Member = "Begin")]
	[CalledBy(Type = typeof(TweenVolume), Member = "Begin")]
	[CalledBy(Type = typeof(TweenWidth), Member = "Begin")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	public static T Begin<T>(GameObject go, float duration) where T : UITweener
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SetStartToCurrentValue()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SetEndToCurrentValue()
	{
	}

	[CalledBy(Type = typeof(TweenAlpha), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenColor), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenFOV), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenHeight), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenOrthoSize), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenPosition), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenRotation), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenScale), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenTransform), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenVolume), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenWidth), Member = ".ctor")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	protected UITweener()
	{
	}
}
