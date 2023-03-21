using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion;

public static class CurveUtils
{
	private const float POS_CHECK_RES = 100f;

	private const float POS_CHECK_DISTANCE = 10f;

	[CallerCount(Count = 0)]
	public static Vector2 GetPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, float t)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CurveUtils), Member = "IsPosAlongCurve")]
	public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CurveUtils), Member = "IsPosAlongCurve")]
	public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition, out float norm)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref norm) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CurveUtils), Member = "ResolveTangents")]
	public static void ResolveTangents(Vector2 from, Vector2 to, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector2, @null>(ref fromTangent) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector2, @null>(ref toTangent) = null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CurveUtils), Member = "ResolveTangents")]
	public static void ResolveTangents(Vector2 from, Vector2 to, Rect fromRect, Rect toRect, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector2, @null>(ref fromTangent) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector2, @null>(ref toTangent) = null;
	}
}
