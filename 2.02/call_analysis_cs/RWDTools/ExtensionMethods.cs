using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace RWDTools;

public static class ExtensionMethods
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static float ToAngleDeg(this Vector2 vector)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector2 DegToVector(this float angle)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	public static bool isPowerOfTwo(this int x)
	{
		return default(bool);
	}
}
