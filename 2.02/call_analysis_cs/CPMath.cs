using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CPMath
{
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector3 CalculateBezier(float t, Vector3 p, Vector3 a, Vector3 b, Vector3 q)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector3 CalculateHermite(Vector3 p, Vector3 a, Vector3 b, Vector3 q, float t, float tension, float bias)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector3 CalculateCatmullRom(Vector3 p, Vector3 a, Vector3 b, Vector3 q, float t)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector2 CalculateBezier(float t, Vector2 p, Vector2 a, Vector2 b, Vector2 q)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector2 CalculateHermite(Vector2 p, Vector2 a, Vector2 b, Vector2 q, float t, float tension, float bias)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector2 CalculateCatmullRom(Vector2 p, Vector2 a, Vector2 b, Vector2 q, float t)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "CubicInterpolation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CPMath), Member = "SquadTangent")]
	[Calls(Type = typeof(CPMath), Member = "Slerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Quaternion CalculateCubic(Quaternion p, Quaternion a, Quaternion b, Quaternion q, float t)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	public static float CalculateCubic(float p, float a, float b, float q, float t)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float CalculateHermite(float p, float a, float b, float q, float t, float tension, float bias)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float CalculateCatmullRom(float p, float a, float b, float q, float t)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float SmoothStep(float val)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CPMath), Member = "CalculateCubic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CPMath), Member = "LnDif")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	[Calls(Type = typeof(Quaternion), Member = "set_Item")]
	[Calls(Type = typeof(CPMath), Member = "Exp")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Quaternion SquadTangent(Quaternion before, Quaternion center, Quaternion after)
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(CPMath), Member = "SquadTangent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(CPMath), Member = "Normalize")]
	[Calls(Type = typeof(CPMath), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Quaternion LnDif(Quaternion a, Quaternion b)
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(CPMath), Member = "LnDif")]
	[CalledBy(Type = typeof(CPMath), Member = "Nlerp")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Quaternion Normalize(Quaternion q)
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(CPMath), Member = "SquadTangent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 3)]
	public static Quaternion Exp(Quaternion q)
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(CPMath), Member = "LnDif")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	public static Quaternion Log(Quaternion q)
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(CPMath), Member = "CalculateCubic")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static Quaternion Slerp(Quaternion p, Quaternion q, float t)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPMath), Member = "Normalize")]
	public static Quaternion Nlerp(Quaternion p, Quaternion q, float t)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	public static Quaternion GetQuatConjugate(Quaternion q)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 up)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CPMath()
	{
	}
}
