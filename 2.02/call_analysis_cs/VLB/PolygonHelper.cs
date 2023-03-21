using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class PolygonHelper : MonoBehaviour
{
	public struct Plane2D
	{
		public Vector2 normal;

		public float distance;

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(Plane2D), Member = "ClosestPoint")]
		[CalledBy(Type = typeof(Plane2D), Member = "GetSide")]
		[CalledBy(Type = typeof(Plane2D), Member = "CutConvex")]
		[CalledBy(Type = typeof(Plane2D), Member = "CutConvex")]
		public float Distance(Vector2 point)
		{
			return default(float);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Plane2D), Member = "Distance")]
		public Vector2 ClosestPoint(Vector2 pt)
		{
			return default(Vector2);
		}

		[CalledBy(Type = typeof(Plane2D), Member = "CutConvex")]
		[Calls(Type = typeof(Utils), Member = "IsAlmostZero")]
		[CalledBy(Type = typeof(Plane2D), Member = "CutConvex")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		public Vector2 Intersect(Vector2 p1, Vector2 p2)
		{
			return default(Vector2);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Plane2D), Member = "Distance")]
		public bool GetSide(Vector2 point)
		{
			return default(bool);
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Vector3), Member = "Normalize")]
		[CalledBy(Type = typeof(TriggerZone), Member = "ComputeZone")]
		public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
		{
			return default(Plane2D);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
		{
			return default(Plane2D);
		}

		[CalledBy(Type = typeof(TriggerZone), Member = "ComputeZone")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		public void Flip()
		{
		}

		[CallsUnknownMethods(Count = 36)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(Plane2D), Member = "Distance")]
		[Calls(Type = typeof(Plane2D), Member = "Distance")]
		[Calls(Type = typeof(Plane2D), Member = "Intersect")]
		[Calls(Type = typeof(Plane2D), Member = "Intersect")]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CalledBy(Type = typeof(TriggerZone), Member = "ComputeZone")]
		public Vector2[] CutConvex(Vector2[] poly)
		{
			return null;
		}

		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public override string ToString()
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PolygonHelper()
	{
	}
}
