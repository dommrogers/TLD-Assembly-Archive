using System;
using System.Diagnostics;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class NGUIMath
{
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static float Lerp(float from, float to, float factor)
	{
		return default(float);
	}

	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	public static int ClampIndex(int val, int max)
	{
		return default(int);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	public static int RepeatIndex(int val, int max)
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnWillRenderObject")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnWillRenderObject")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnWillRenderObject")]
	public static float WrapAngle(float angle)
	{
		return default(float);
	}

	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static float Wrap01(float val)
	{
		return default(float);
	}

	[CallAnalysisFailed]
	[DebuggerHidden]
	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	[DebuggerStepThrough]
	public static int HexToDecimal(char ch)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static char DecimalToHexChar(int num)
	{
		return default(char);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string DecimalToHex8(int num)
	{
		return null;
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public static string DecimalToHex24(int num)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	public static string DecimalToHex32(int num)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CalledBy(Type = typeof(NGUIText), Member = "EncodeColor32")]
	[CalledBy(Type = typeof(NGUIText), Member = "EncodeColor24")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public static int ColorToInt(Color c)
	{
		return default(int);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	public static Color IntToColor(int val)
	{
		return default(Color);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string IntToBinary(int val, int bits)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	public static Color HexToColor(uint val)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	public static Rect ConvertToTexCoords(Rect rect, int width, int height)
	{
		return default(Rect);
	}

	[CalledBy(Type = typeof(UIAtlas), Member = "Upgrade")]
	[CalledBy(Type = typeof(UIFont), Member = "Trim")]
	[CalledBy(Type = typeof(UIAtlas), Member = "Upgrade")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CalledBy(Type = typeof(NGUIMath), Member = "MakePixelPerfect")]
	public static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
	{
		return default(Rect);
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public static Rect MakePixelPerfect(Rect rect)
	{
		return default(Rect);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public static Rect MakePixelPerfect(Rect rect, int width, int height)
	{
		return default(Rect);
	}

	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "CalculateConstrainOffset")]
	[CalledBy(Type = typeof(UIPanel), Member = "CalculateConstrainOffset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Press")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
	{
		return default(Bounds);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	public static Bounds CalculateRelativeWidgetBounds(Transform trans)
	{
		return default(Bounds);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	public static Bounds CalculateRelativeWidgetBounds(Transform trans, bool considerInactive)
	{
		return default(Bounds);
	}

	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CallerCount(Count = 0)]
	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content)
	{
		return default(Bounds);
	}

	[CalledBy(Type = typeof(UIDragObject), Member = "UpdateBounds")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UITable), Member = "RepositionVariableSize")]
	[CalledBy(Type = typeof(UITable), Member = "RepositionVariableSize")]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CalledBy(Type = typeof(UIScrollView), Member = "get_bounds")]
	[CalledBy(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CalledBy(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[CalledBy(Type = typeof(UIStretch), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "InitializeHinterlandMailingListWidget")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateHinterlandMailingListWidget")]
	[CalledBy(Type = typeof(EnvelopContent), Member = "Execute")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CalledBy(Type = typeof(CenterContents), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix")]
	[CallsUnknownMethods(Count = 1)]
	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive, bool considerParents = true)
	{
		return default(Bounds);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	private static void CalculateRelativeWidgetBounds(Transform content, bool considerInactive, bool isRoot, ref Matrix4x4 toLocal, ref Vector3 vMin, ref Vector3 vMax, ref bool isSet, bool considerParents)
	{
	}

	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UICenterOnChild), Member = "Recenter")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
	{
		return default(Vector3);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CalledBy(Type = typeof(SpringPosition), Member = "Update")]
	[CalledBy(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(SpringPosition), Member = "Update")]
	[CalledBy(Type = typeof(SpringPanel), Member = "AdvanceTowardsPosition")]
	public static float SpringLerp(float strength, float deltaTime)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(WindowDragTilt), Member = "Update")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CallerCount(Count = 3)]
	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(Vector2), Member = "Lerp")]
	public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
	{
		return default(Vector2);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallsUnknownMethods(Count = 1)]
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		return default(Quaternion);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static float RotateTowards(float from, float to, float maxAngle)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUIMath), Member = "DistanceToRectangle")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUIMath), Member = "DistancePointToLineSegment")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(NGUIMath), Member = "DistanceToRectangle")]
	public static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUIMath), Member = "DistanceToRectangle")]
	[CallsUnknownMethods(Count = 8)]
	public static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam)
	{
		return default(float);
	}

	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 25)]
	public static Vector2 GetPivotOffset(UIWidget.Pivot pv)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(UIScrollView), Member = "Awake")]
	[CalledBy(Type = typeof(UIInput), Member = "SetPivotToRight")]
	[CalledBy(Type = typeof(UIInput), Member = "SetPivotToLeft")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 4)]
	public static UIWidget.Pivot GetPivot(Vector2 offset)
	{
		return default(UIWidget.Pivot);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "MoveRect")]
	public static void MoveWidget(UIRect w, float x, float y)
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(NGUIMath), Member = "MoveWidget")]
	public static void MoveRect(UIRect rect, float x, float y)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "ResizeWidget")]
	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight)
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(NGUIMath), Member = "ResizeWidget")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CalledBy(Type = typeof(UIDragResize), Member = "OnDrag")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
	}

	[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CallerCount(Count = 0)]
	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top)
	{
	}

	[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CallerCount(Count = 0)]
	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
	[Calls(Type = typeof(UIRect.AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect.AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIRect.AnchorPoint), Member = "SetVertical")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UIRect.AnchorPoint), Member = "SetVertical")]
	[CalledBy(Type = typeof(NGUIMath), Member = "ResizeWidget")]
	[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_width")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 3)]
	public static int AdjustByDPI(float height)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static Vector2 ScreenToPixels(Vector2 pos, Transform relativeTo)
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	public static Vector2 ScreenToParentPixels(Vector2 pos, Transform relativeTo)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static Vector3 WorldToLocalPoint(Vector3 worldPos, Camera worldCam, Camera uiCam, Transform relativeTo)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CallsUnknownMethods(Count = 9)]
	public static void OverlayPosition(this Transform trans, Vector3 worldPos, Camera worldCam, Camera myCam)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static void OverlayPosition(this Transform trans, Vector3 worldPos, Camera worldCam)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public static void OverlayPosition(this Transform trans, Transform target)
	{
	}
}
