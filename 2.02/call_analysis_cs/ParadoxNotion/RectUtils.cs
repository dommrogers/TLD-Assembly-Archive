using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion;

public static class RectUtils
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static Rect GetBoundRect(Rect[] rects)
	{
		return default(Rect);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CurveUtils), Member = "IsPosAlongCurve")]
	[CallsUnknownMethods(Count = 5)]
	public static Rect GetBoundRect(Vector2[] positions)
	{
		return default(Rect);
	}

	[CallerCount(Count = 0)]
	public static bool Encapsulates(this Rect a, Rect b)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static Rect ExpandBy(this Rect rect, float margin)
	{
		return default(Rect);
	}

	[CallerCount(Count = 0)]
	public static Rect ExpandBy(this Rect rect, float xMargin, float yMargin)
	{
		return default(Rect);
	}

	[CallerCount(Count = 0)]
	public static Rect ExpandBy(this Rect rect, float left, float top, float right, float bottom)
	{
		return default(Rect);
	}

	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 0)]
	public static Rect TransformSpace(this Rect rect, Rect oldContainer, Rect newContainer)
	{
		return default(Rect);
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector2 TransformSpace(this Vector2 vector, Rect oldContainer, Rect newContainer)
	{
		return default(Vector2);
	}
}
