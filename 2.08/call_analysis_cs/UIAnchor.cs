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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CallerCount(Count = 0)]
	private void ScreenSizeChanged()
	{
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 6)]
	private bool HasPositionChanged()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private void UpdatePreviousPosition()
	{
	}

	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "set_position")]
	[CalledBy(Type = typeof(UIAnchor), Member = "ScreenSizeChanged")]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIAnchor), Member = "HasPositionChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(UIAnchor), Member = "Start")]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect")]
	[Calls(Type = typeof(UIWidget), Member = "CalculateBounds")]
	[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[Calls(Type = typeof(UIAnchor), Member = "UpdatePreviousPosition")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CallsUnknownMethods(Count = 13)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public UIAnchor()
	{
	}
}
