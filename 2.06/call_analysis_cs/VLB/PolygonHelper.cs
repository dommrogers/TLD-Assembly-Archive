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

		[CallerCount(Count = 0)]
		public float Distance(Vector2 point)
		{
			return default(float);
		}

		[CallerCount(Count = 0)]
		public Vector2 ClosestPoint(Vector2 pt)
		{
			return default(Vector2);
		}

		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(Plane2D), Member = "CutConvex")]
		[CalledBy(Type = typeof(Plane2D), Member = "CutConvex")]
		public Vector2 Intersect(Vector2 p1, Vector2 p2)
		{
			return default(Vector2);
		}

		[CallerCount(Count = 0)]
		public bool GetSide(Vector2 point)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
		{
			return default(Plane2D);
		}

		[CallerCount(Count = 0)]
		public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
		{
			return default(Plane2D);
		}

		[CallerCount(Count = 0)]
		public void Flip()
		{
		}

		[CalledBy(Type = typeof(TriggerZone), Member = "ComputeZone")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 13)]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[Calls(Type = typeof(Plane2D), Member = "Intersect")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Plane2D), Member = "Intersect")]
		public Vector2[] CutConvex(Vector2[] poly)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		public override string ToString()
		{
			return null;
		}
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public PolygonHelper()
	{
	}
}
