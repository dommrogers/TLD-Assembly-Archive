using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIStretch : MonoBehaviour
{
	public enum Style
	{
		None,
		Horizontal,
		Vertical,
		Both,
		BasedOnHeight,
		FillKeepingRatio,
		FitInternalKeepingRatio
	}

	public Camera uiCamera;

	public GameObject container;

	public Style style;

	public Vector2 relativeSize;

	public Vector2 initialSize;

	public Vector2 borderPadding;

	private UIWidget widgetContainer;

	private Transform mTrans;

	private UIWidget mWidget;

	private UISprite mSprite;

	private UIPanel mPanel;

	private UIRoot mRoot;

	private Animation mAnim;

	private Rect mRect;

	private bool mStarted;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIStretch), Member = "Update")]
	private void ScreenSizeChanged()
	{
	}

	[Calls(Type = typeof(UIStretch), Member = "Update")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CallsUnknownMethods(Count = 5)]
	private void Start()
	{
	}

	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "get_orthographicSize")]
	[Calls(Type = typeof(Camera), Member = "get_orthographicSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[CalledBy(Type = typeof(UIStretch), Member = "Start")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Transform), Member = "set_localScale")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
	[Calls(Type = typeof(UIPanel), Member = "set_baseClipRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIStretch), Member = "ScreenSizeChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UIWidget), Member = "CalculateBounds")]
	[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public UIStretch()
	{
	}
}
