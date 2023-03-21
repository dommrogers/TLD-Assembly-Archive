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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIAnchor), Member = "LateUpdate")]
	private void ScreenSizeChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private bool HasPositionChanged()
	{
		return false;
	}

	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdatePreviousPosition()
	{
	}

	[CalledBy(Type = typeof(UIAnchor), Member = "ScreenSizeChanged")]
	[CalledBy(Type = typeof(UIAnchor), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIAnchor), Member = "HasPositionChanged")]
	[Calls(Type = typeof(UIAnchor), Member = "UpdatePreviousPosition")]
	[Calls(Type = typeof(UIWidget), Member = "CalculateBounds")]
	[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint")]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint")]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(Transform), Member = "set_position")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 13)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public UIAnchor()
	{
	}
}
