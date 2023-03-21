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

		[CalledBy(Type = typeof(Plane2D), Member = "ClosestPoint")]
		[CalledBy(Type = typeof(Plane2D), Member = "GetSide")]
		[CalledBy(Type = typeof(Plane2D), Member = "CutConvex")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		public float Distance(Vector2 point)
		{
			return 0f;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Plane2D), Member = "Distance")]
		[CallsDeduplicatedMethods(Count = 1)]
		public Vector2 ClosestPoint(Vector2 pt)
		{
			return default(Vector2);
		}

		[CalledBy(Type = typeof(Plane2D), Member = "CutConvex")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Utils), Member = "IsAlmostZero")]
		[CallsDeduplicatedMethods(Count = 1)]
		public Vector2 Intersect(Vector2 p1, Vector2 p2)
		{
			return default(Vector2);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Plane2D), Member = "Distance")]
		public bool GetSide(Vector2 point)
		{
			return false;
		}

		[CalledBy(Type = typeof(TriggerZone), Member = "ComputeZone")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "Normalize")]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void Flip()
		{
		}

		[CalledBy(Type = typeof(TriggerZone), Member = "ComputeZone")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Plane2D), Member = "Distance")]
		[Calls(Type = typeof(Plane2D), Member = "Intersect")]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 36)]
		public Vector2[] CutConvex(Vector2[] poly)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
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
