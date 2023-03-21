using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion;

public static class CurveUtils
{
	private const float POS_CHECK_RES = 100f;

	private const float POS_CHECK_DISTANCE = 10f;

	[CalledBy(Type = typeof(CurveUtils), Member = "IsPosAlongCurve")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector2 GetPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, float t)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CurveUtils), Member = "IsPosAlongCurve")]
	public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition)
	{
		return false;
	}

	[CalledBy(Type = typeof(CurveUtils), Member = "IsPosAlongCurve")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectUtils), Member = "GetBoundRect")]
	[Calls(Type = typeof(CurveUtils), Member = "GetPosAlongCurve")]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition, out float norm)
	{
		norm = default(float);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CurveUtils), Member = "ResolveTangents")]
	public static void ResolveTangents(Vector2 from, Vector2 to, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent)
	{
		fromTangent = default(Vector2);
		toTangent = default(Vector2);
	}

	[CalledBy(Type = typeof(CurveUtils), Member = "ResolveTangents")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ResolveTangents(Vector2 from, Vector2 to, Rect fromRect, Rect toRect, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent)
	{
		fromTangent = default(Vector2);
		toTangent = default(Vector2);
	}
}
