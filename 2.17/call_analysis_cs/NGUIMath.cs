using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class NGUIMath
{
	[DebuggerStepThrough]
	[DebuggerHidden]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static float Lerp(float from, float to, float factor)
	{
		return 0f;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	public static int ClampIndex(int val, int max)
	{
		return 0;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	public static int RepeatIndex(int val, int max)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnWillRenderObject")]
	[CallerCount(Count = 3)]
	public static float WrapAngle(float angle)
	{
		return 0f;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Wrap01(float val)
	{
		return 0f;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[DeduplicatedMethod]
	[CallAnalysisFailed]
	[CallerCount(Count = 26)]
	public static int HexToDecimal(char ch)
	{
		return 0;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	public static char DecimalToHexChar(int num)
	{
		return '\0';
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	public static string DecimalToHex8(int num)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	public static string DecimalToHex24(int num)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	public static string DecimalToHex32(int num)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CalledBy(Type = typeof(NGUIText), Member = "EncodeColor24")]
	[CalledBy(Type = typeof(NGUIText), Member = "EncodeColor32")]
	[CalledBy(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static int ColorToInt(Color c)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	public static Color IntToColor(int val)
	{
		return default(Color);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	public static string IntToBinary(int val, int bits)
	{
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
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

	[CalledBy(Type = typeof(NGUIMath), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(UIAtlas), Member = "Upgrade")]
	[CalledBy(Type = typeof(UIFont), Member = "Trim")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
	{
		return default(Rect);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static Rect MakePixelPerfect(Rect rect)
	{
		return default(Rect);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[CallsUnknownMethods(Count = 4)]
	public static Rect MakePixelPerfect(Rect rect, int width, int height)
	{
		return default(Rect);
	}

	[CalledBy(Type = typeof(UIDraggableCamera), Member = "CalculateConstrainOffset")]
	[CalledBy(Type = typeof(UIPanel), Member = "CalculateConstrainOffset")]
	[CallerCount(Count = 2)]
	public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Press")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content)
	{
		return default(Bounds);
	}

	[CalledBy(Type = typeof(EnvelopContent), Member = "Execute")]
	[CalledBy(Type = typeof(UIDragObject), Member = "UpdateBounds")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIScrollView), Member = "get_bounds")]
	[CalledBy(Type = typeof(UITable), Member = "RepositionVariableSize")]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CalledBy(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CalledBy(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[CalledBy(Type = typeof(UIStretch), Member = "Update")]
	[CalledBy(Type = typeof(CenterContents), Member = "LateUpdate")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive, bool considerParents = true)
	{
		return default(Bounds);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CalledBy(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 7)]
	private static void CalculateRelativeWidgetBounds(Transform content, bool considerInactive, bool isRoot, ref Matrix4x4 toLocal, ref Vector3 vMin, ref Vector3 vMax, ref bool isSet, bool considerParents)
	{
	}

	[CalledBy(Type = typeof(UICenterOnChild), Member = "Recenter")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CalledBy(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CalledBy(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CalledBy(Type = typeof(SpringPanel), Member = "AdvanceTowardsPosition")]
	[CalledBy(Type = typeof(SpringPosition), Member = "Update")]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public static float SpringLerp(float strength, float deltaTime)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(WindowDragTilt), Member = "Update")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	public static float RotateTowards(float from, float to, float maxAngle)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(NGUIMath), Member = "DistanceToRectangle")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(NGUIMath), Member = "DistanceToRectangle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUIMath), Member = "DistancePointToLineSegment")]
	[CallsUnknownMethods(Count = 2)]
	public static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "DistanceToRectangle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam)
	{
		return 0f;
	}

	[CallerCount(Count = 25)]
	public static Vector2 GetPivotOffset(UIWidget.Pivot pv)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(UIScrollView), Member = "Awake")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIInput), Member = "SetPivotToLeft")]
	[CalledBy(Type = typeof(UIInput), Member = "SetPivotToRight")]
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

	[CalledBy(Type = typeof(NGUIMath), Member = "MoveWidget")]
	[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static void MoveRect(UIRect rect, float x, float y)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "ResizeWidget")]
	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight)
	{
	}

	[CalledBy(Type = typeof(UIDragResize), Member = "OnDrag")]
	[CalledBy(Type = typeof(NGUIMath), Member = "ResizeWidget")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
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

	[CalledBy(Type = typeof(NGUIMath), Member = "ResizeWidget")]
	[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_width")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_height")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect.AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(UIRect.AnchorPoint), Member = "SetVertical")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static int AdjustByDPI(float height)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public static Vector2 ScreenToPixels(Vector2 pos, Transform relativeTo)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
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

	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public static void OverlayPosition(this Transform trans, Vector3 worldPos, Camera worldCam, Camera myCam)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void OverlayPosition(this Transform trans, Vector3 worldPos, Camera worldCam)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public static void OverlayPosition(this Transform trans, Transform target)
	{
	}
}
