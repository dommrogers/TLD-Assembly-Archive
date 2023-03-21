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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIStretch), Member = "Update")]
	private void ScreenSizeChanged()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIStretch), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(UIStretch), Member = "Start")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "get_orthographicSize")]
	[Calls(Type = typeof(Camera), Member = "get_orthographicSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(UIPanel), Member = "set_baseClipRegion")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIWidget), Member = "CalculateBounds")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIStretch), Member = "ScreenSizeChanged")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_one")]
	[Calls(Type = typeof(Vector2), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UIStretch()
	{
	}
}
