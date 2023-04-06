using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UITooltip : MonoBehaviour
{
	protected static UITooltip mInstance;

	public Camera uiCamera;

	public UILabel text;

	public UISprite background;

	public float appearSpeed;

	public bool scalingTransitions;

	protected GameObject mHover;

	protected Transform mTrans;

	protected float mTarget;

	protected float mCurrent;

	protected Vector3 mPos;

	protected Vector3 mSize;

	protected UIWidget[] mWidgets;

	public static bool isVisible
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void SetAlpha(float val)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Camera), Member = "get_orthographicSize")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 14)]
	protected virtual void SetText(string tooltipText)
	{
	}

	[Obsolete("Use UITooltip.Show instead")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ShowText(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Show(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void Hide()
	{
	}

	[CallerCount(Count = 0)]
	public UITooltip()
	{
	}
}
