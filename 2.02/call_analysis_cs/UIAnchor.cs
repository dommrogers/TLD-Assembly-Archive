using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIAnchor : MonoBehaviour
{
	public enum Side
	{
		BottomLeft,
		Left,
		TopLeft,
		Top,
		TopRight,
		Right,
		BottomRight,
		Bottom,
		Center
	}

	public static float m_UI_Height;

	public static float m_UI_Width;

	public Camera uiCamera;

	public GameObject container;

	public Side side;

	public Vector2 relativeOffset;

	public Vector2 pixelOffset;

	private UIWidget widgetContainer;

	private Transform mTrans;

	private Animation mAnim;

	private Rect mRect;

	private UIRoot mRoot;

	private bool mStarted;

	private bool hasStretchComponent;

	private UIWidget m_UIWidget;

	private UIPanel m_UIPanel;

	private Vector3 m_PreviousLossyScale;

	private Vector3 m_PreviousPosition;

	private Quaternion m_PreviousRotation;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CallerCount(Count = 0)]
	private void ScreenSizeChanged()
	{
	}

	[Calls(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[Calls(Type = typeof(Quaternion), Member = "op_Equality")]
	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	private bool HasPositionChanged()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 6)]
	private void UpdatePreviousPosition()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "CalculateBounds")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIAnchor), Member = "ScreenSizeChanged")]
	[CalledBy(Type = typeof(UIAnchor), Member = "Start")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[Calls(Type = typeof(UIAnchor), Member = "UpdatePreviousPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIAnchor), Member = "HasPositionChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	public UIAnchor()
	{
	}
}
