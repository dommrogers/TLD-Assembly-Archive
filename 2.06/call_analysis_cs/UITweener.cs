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
			return default(float);
		}
	}

	public float tweenFactor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Direction direction
	{
		[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
		[CallerCount(Count = 0)]
		get
		{
			return default(Direction);
		}
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	protected virtual void Start()
	{
	}

	[CalledBy(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(UITweener), Member = "PlayForward")]
	[CalledBy(Type = typeof(HUDChapter), Member = "Enqueue")]
	[CalledBy(Type = typeof(UITweener), Member = "PlayReverse")]
	[CalledBy(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CalledBy(Type = typeof(GearMessage), Member = "ShowNextMessageInQueue")]
	[CalledBy(Type = typeof(GearMessage), Member = "ShowNextMessageInQueue")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CalledBy(Type = typeof(ObjectiveInfoDisplay), Member = "Show")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "StartBuffNotificationTweeens")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "SetLoadingScreenText")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(UITweener), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	private void Update()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[CallerCount(Count = 0)]
	public void SetOnFinished(EventDelegate.Callback del)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void SetOnFinished(EventDelegate del)
	{
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "Awake")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Awake")]
	[CalledBy(Type = typeof(ObjectiveInfoDisplay), Member = "Awake")]
	[CalledBy(Type = typeof(HUDChapter), Member = "Awake")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Awake")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	public void RemoveOnFinished(EventDelegate del)
	{
	}

	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 91)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Sample(float factor, bool isFinished)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	private float BounceLogic(float val)
	{
		return default(float);
	}

	[Obsolete("Use PlayForward() instead")]
	[DeduplicatedMethod]
	[CallerCount(Count = 68)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	public void Play()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 68)]
	[DeduplicatedMethod]
	public void PlayForward()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	public void PlayReverse()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	public void Play(bool forward)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "DoTap")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Hide")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Show")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	public void ResetToBeginning()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	public void Toggle()
	{
	}

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	protected abstract void OnUpdate(float factor, bool isFinished);

	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[DeduplicatedMethod]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
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

	[CalledBy(Type = typeof(TweenFOV), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenColor), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenAlpha), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(TweenScale), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenPosition), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenRotation), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenTransform), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenVolume), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenWidth), Member = ".ctor")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(TweenHeight), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenOrthoSize), Member = ".ctor")]
	protected UITweener()
	{
	}
}
