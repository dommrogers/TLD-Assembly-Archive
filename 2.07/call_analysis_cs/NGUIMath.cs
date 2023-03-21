using System;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class NGUIMath
{
	[CallerCount(Count = 0)]
	[DebuggerHidden]
	[DeduplicatedMethod]
	[DebuggerStepThrough]
	public static float Lerp(float from, float to, float factor)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static int ClampIndex(int val, int max)
	{
		return default(int);
	}

	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	public static int RepeatIndex(int val, int max)
	{
		return default(int);
	}

	[DebuggerStepThrough]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnWillRenderObject")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnWillRenderObject")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnWillRenderObject")]
	[CallerCount(Count = 3)]
	[DebuggerHidden]
	public static float WrapAngle(float angle)
	{
		return default(float);
	}

	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerStepThrough]
	public static float Wrap01(float val)
	{
		return default(float);
	}

	[CallerCount(Count = 26)]
	[CallAnalysisFailed]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	public static int HexToDecimal(char ch)
	{
		return default(int);
	}

	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	public static char DecimalToHexChar(int num)
	{
		return default(char);
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	public static string DecimalToHex8(int num)
	{
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public static string DecimalToHex24(int num)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public static string DecimalToHex32(int num)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(NGUIText), Member = "EncodeColor24")]
	[CalledBy(Type = typeof(NGUIText), Member = "EncodeColor32")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CallsUnknownMethods(Count = 4)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static int ColorToInt(Color c)
	{
		return default(int);
	}

	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[DebuggerHidden]
	public static Color IntToColor(int val)
	{
		return default(Color);
	}

	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	[DebuggerStepThrough]
	public static string IntToBinary(int val, int bits)
	{
		return null;
	}

	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	public static Color HexToColor(uint val)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	public static Rect ConvertToTexCoords(Rect rect, int width, int height)
	{
		return default(Rect);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIFont), Member = "Trim")]
	[CalledBy(Type = typeof(UIAtlas), Member = "Upgrade")]
	[CalledBy(Type = typeof(UIAtlas), Member = "Upgrade")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(NGUIMath), Member = "MakePixelPerfect")]
	public static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
	{
		return default(Rect);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static Rect MakePixelPerfect(Rect rect)
	{
		return default(Rect);
	}

	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static Rect MakePixelPerfect(Rect rect, int width, int height)
	{
		return default(Rect);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = "CalculateConstrainOffset")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "CalculateConstrainOffset")]
	public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Press")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	public static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
	{
		return default(Bounds);
	}

	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CallerCount(Count = 0)]
	public static Bounds CalculateRelativeWidgetBounds(Transform trans)
	{
		return default(Bounds);
	}

	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIScrollView), Member = "get_bounds")]
	[CalledBy(Type = typeof(UITable), Member = "RepositionVariableSize")]
	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UITable), Member = "RepositionVariableSize")]
	[CalledBy(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CalledBy(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CalledBy(Type = typeof(UIDragObject), Member = "UpdateBounds")]
	[CalledBy(Type = typeof(EnvelopContent), Member = "Execute")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[CalledBy(Type = typeof(CenterContents), Member = "LateUpdate")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CalledBy(Type = typeof(UIStretch), Member = "Update")]
	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive, bool considerParents = true)
	{
		return default(Bounds);
	}

	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CallsUnknownMethods(Count = 7)]
	private static void CalculateRelativeWidgetBounds(Transform content, bool considerInactive, bool isRoot, ref Matrix4x4 toLocal, ref Vector3 vMin, ref Vector3 vMax, ref bool isSet, bool considerParents)
	{
	}

	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UICenterOnChild), Member = "Recenter")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(SpringPosition), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SpringPosition), Member = "Update")]
	[CalledBy(Type = typeof(SpringPanel), Member = "AdvanceTowardsPosition")]
	[CalledBy(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CalledBy(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CalledBy(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	public static float SpringLerp(float strength, float deltaTime)
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(WindowDragTilt), Member = "Update")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 1)]
	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallerCount(Count = 0)]
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallsUnknownMethods(Count = 1)]
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	public static float RotateTowards(float from, float to, float maxAngle)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(NGUIMath), Member = "DistanceToRectangle")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
	{
		return default(float);
	}

	[Calls(Type = typeof(NGUIMath), Member = "DistancePointToLineSegment")]
	[CalledBy(Type = typeof(NGUIMath), Member = "DistanceToRectangle")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "DistanceToRectangle")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam)
	{
		return default(float);
	}

	[CallerCount(Count = 25)]
	public static Vector2 GetPivotOffset(UIWidget.Pivot pv)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(UIInput), Member = "SetPivotToRight")]
	[CalledBy(Type = typeof(UIInput), Member = "SetPivotToLeft")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIScrollView), Member = "Awake")]
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

	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CalledBy(Type = typeof(NGUIMath), Member = "MoveWidget")]
	[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	public static void MoveRect(UIRect rect, float x, float y)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "ResizeWidget")]
	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CalledBy(Type = typeof(UIDragResize), Member = "OnDrag")]
	[CalledBy(Type = typeof(NGUIMath), Member = "ResizeWidget")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight)
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect.AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect.AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect.AnchorPoint), Member = "SetVertical")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect.AnchorPoint), Member = "SetVertical")]
	[CalledBy(Type = typeof(NGUIMath), Member = "ResizeWidget")]
	[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_width")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static int AdjustByDPI(float height)
	{
		return default(int);
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static Vector2 ScreenToPixels(Vector2 pos, Transform relativeTo)
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	public static Vector2 ScreenToParentPixels(Vector2 pos, Transform relativeTo)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static Vector3 WorldToLocalPoint(Vector3 worldPos, Camera worldCam, Camera uiCam, Transform relativeTo)
	{
		return default(Vector3);
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CallsUnknownMethods(Count = 6)]
	public static void OverlayPosition(this Transform trans, Vector3 worldPos, Camera worldCam, Camera myCam)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void OverlayPosition(this Transform trans, Vector3 worldPos, Camera worldCam)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CallsUnknownMethods(Count = 6)]
	public static void OverlayPosition(this Transform trans, Transform target)
	{
	}
}
