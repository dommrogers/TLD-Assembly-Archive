using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CPMath
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CallerCount(Count = 1)]
	public static Vector3 CalculateBezier(float t, Vector3 p, Vector3 a, Vector3 b, Vector3 q)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static Vector3 CalculateHermite(Vector3 p, Vector3 a, Vector3 b, Vector3 q, float t, float tension, float bias)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static Vector2 CalculateHermite(Vector2 p, Vector2 a, Vector2 b, Vector2 q, float t, float tension, float bias)
	{
		return default(Vector2);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static Vector2 CalculateCatmullRom(Vector2 p, Vector2 a, Vector2 b, Vector2 q, float t)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CPMath), Member = "SquadTangent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "CubicInterpolation")]
	[Calls(Type = typeof(CPMath), Member = "Slerp")]
	[Calls(Type = typeof(CPMath), Member = "Slerp")]
	[Calls(Type = typeof(CPMath), Member = "Slerp")]
	[Calls(Type = typeof(CPMath), Member = "SquadTangent")]
	public static Quaternion CalculateCubic(Quaternion p, Quaternion a, Quaternion b, Quaternion q, float t)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	public static float CalculateCubic(float p, float a, float b, float q, float t)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float CalculateHermite(float p, float a, float b, float q, float t, float tension, float bias)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float CalculateCatmullRom(float p, float a, float b, float q, float t)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float SmoothStep(float val)
	{
		return default(float);
	}

	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(CPMath), Member = "LnDif")]
	[Calls(Type = typeof(CPMath), Member = "LnDif")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "set_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CPMath), Member = "Exp")]
	[CalledBy(Type = typeof(CPMath), Member = "CalculateCubic")]
	[CalledBy(Type = typeof(CPMath), Member = "CalculateCubic")]
	public static Quaternion SquadTangent(Quaternion before, Quaternion center, Quaternion after)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(CPMath), Member = "Normalize")]
	[Calls(Type = typeof(CPMath), Member = "Log")]
	[CalledBy(Type = typeof(CPMath), Member = "SquadTangent")]
	[CalledBy(Type = typeof(CPMath), Member = "SquadTangent")]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	public static Quaternion LnDif(Quaternion a, Quaternion b)
	{
		return default(Quaternion);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CPMath), Member = "LnDif")]
	[CalledBy(Type = typeof(CPMath), Member = "Nlerp")]
	public static Quaternion Normalize(Quaternion q)
	{
		return default(Quaternion);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CPMath), Member = "SquadTangent")]
	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	public static Quaternion Exp(Quaternion q)
	{
		return default(Quaternion);
	}

	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CPMath), Member = "LnDif")]
	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	[Calls(Type = typeof(Quaternion), Member = "get_Item")]
	[CallerCount(Count = 1)]
	public static Quaternion Log(Quaternion q)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CPMath), Member = "CalculateCubic")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CPMath), Member = "CalculateCubic")]
	[CalledBy(Type = typeof(CPMath), Member = "CalculateCubic")]
	public static Quaternion Slerp(Quaternion p, Quaternion q, float t)
	{
		return default(Quaternion);
	}

	[Calls(Type = typeof(CPMath), Member = "Normalize")]
	[CallerCount(Count = 0)]
	public static Quaternion Nlerp(Quaternion p, Quaternion q, float t)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	public static Quaternion GetQuatConjugate(Quaternion q)
	{
		return default(Quaternion);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 up)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CPMath()
	{
	}
}
