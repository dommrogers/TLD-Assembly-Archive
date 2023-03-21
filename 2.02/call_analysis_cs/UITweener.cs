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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 76)]
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
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Reset()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Update")]
	[CallerCount(Count = 0)]
	protected virtual void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(UITweener), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetOnFinished(EventDelegate.Callback del)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void SetOnFinished(EventDelegate del)
	{
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "Awake")]
	[CalledBy(Type = typeof(HUDChapter), Member = "Awake")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Awake")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Awake")]
	[CalledBy(Type = typeof(ObjectiveInfoDisplay), Member = "Awake")]
	public void AddOnFinished(EventDelegate.Callback del)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void AddOnFinished(EventDelegate del)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void RemoveOnFinished(EventDelegate del)
	{
	}

	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 82)]
	public void Sample(float factor, bool isFinished)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	private float BounceLogic(float val)
	{
		return default(float);
	}

	[Obsolete]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[DeduplicatedMethod]
	public void Play()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallerCount(Count = 0)]
	public void PlayForward()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallerCount(Count = 0)]
	public void PlayReverse()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallerCount(Count = 75)]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Play(bool forward)
	{
	}

	[CalledBy(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Hide")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Show")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DoTap")]
	public void ResetToBeginning()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	public void Toggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void OnUpdate(float factor, bool isFinished);

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public static T Begin<T>(GameObject go, float duration) where T : UITweener
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void SetStartToCurrentValue()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void SetEndToCurrentValue()
	{
	}

	[CalledBy(Type = typeof(TweenFOV), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenHeight), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenOrthoSize), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenPosition), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenScale), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenTransform), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenVolume), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenWidth), Member = ".ctor")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(TweenColor), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenAlpha), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenRotation), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	protected UITweener()
	{
	}
}
