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
		[CalledBy(Type = typeof(UITweener), Member = "Begin")]
		[CalledBy(Type = typeof(UITweener), Member = "Toggle")]
		[CalledBy(Type = typeof(UITweener), Member = "Update")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(UITweener), Member = "Toggle")]
		get
		{
			return default(float);
		}
	}

	public float tweenFactor
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CalledBy(Type = typeof(UIPlayTween), Member = "Update")]
		[CallerCount(Count = 1)]
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

	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(GearMessage), Member = "ShowNextMessageInQueue")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UITweener), Member = "Start")]
	[CalledBy(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[CallerCount(Count = 0)]
	public void SetOnFinished(EventDelegate.Callback del)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void SetOnFinished(EventDelegate del)
	{
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "Awake")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(HUDChapter), Member = "Awake")]
	[CalledBy(Type = typeof(ObjectiveInfoDisplay), Member = "Awake")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Awake")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Awake")]
	public void AddOnFinished(EventDelegate.Callback del)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallerCount(Count = 0)]
	public void AddOnFinished(EventDelegate del)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void RemoveOnFinished(EventDelegate del)
	{
	}

	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 28)]
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
		return default(float);
	}

	[Obsolete("Use PlayForward() instead")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	public void Play()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	public void PlayForward()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	public void PlayReverse()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 80)]
	public void Play(bool forward)
	{
	}

	[CallerCount(Count = 73)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	public void ResetToBeginning()
	{
	}

	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallerCount(Count = 1)]
	public void Toggle()
	{
	}

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	protected abstract void OnUpdate(float factor, bool isFinished);

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	public static T Begin<T>(GameObject go, float duration) where T : UITweener
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void SetStartToCurrentValue()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SetEndToCurrentValue()
	{
	}

	[CalledBy(Type = typeof(TweenScale), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenRotation), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenPosition), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenOrthoSize), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenColor), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenHeight), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenFOV), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenTransform), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenAlpha), Member = ".ctor")]
	[CalledBy(Type = typeof(TweenWidth), Member = ".ctor")]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(TweenVolume), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	protected UITweener()
	{
	}
}
