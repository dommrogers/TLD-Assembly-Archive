using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OctreeBoundsNode<T>
{
	private struct OctreeObject : IEquatable<OctreeObject>
	{
		public T Obj;

		public Bounds Bounds;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsUnknownMethods(Count = 7)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool Equals(OctreeObject obj)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Bounds), Member = "GetHashCode")]
		[CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public static bool operator ==(OctreeObject lhs, OctreeObject rhs)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public static bool operator !=(OctreeObject lhs, OctreeObject rhs)
		{
			return default(bool);
		}
	}

	private Vector3 _003CCenter_003Ek__BackingField;

	private float _003CBaseLength_003Ek__BackingField;

	private float looseness;

	private float minSize;

	private float adjLength;

	private Bounds bounds;

	private readonly List<OctreeObject> objects;

	private OctreeBoundsNode<T>[] children;

	private Bounds[] childBounds;

	private const int numObjectsAllowed = 8;

	public Vector3 Center
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public float BaseLength
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public OctreeBoundsNode(float baseLengthVal, float minSizeVal, float loosenessVal, Vector3 centerVal)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool Add(T obj, Bounds objBounds)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public bool Remove(T obj)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsColliding(Bounds checkBounds)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void GetColliding(Bounds checkBounds, ref List<T> resultList)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	public void FrustumCapture(Plane[] frustumPlanes, ref List<T> captureList)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public void SetChildren(OctreeBoundsNode<T>[] childOctrees)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public void DrawAllBounds(float depth = 0f)
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public void DrawAllObjects()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public OctreeBoundsNode<T> ShrinkIfPossible(float minLength)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 13)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void SetValues(float baseLengthVal, float minSizeVal, float loosenessVal, Vector3 centerVal)
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 13)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SubAdd(T obj, Bounds objBounds)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 42)]
	private void Split()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Merge()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static bool Encapsulates(Bounds outerBounds, Bounds innerBounds)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private int BestFitChild(Bounds objBounds)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool ShouldMerge()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool HasAnyObjects()
	{
		return default(bool);
	}
}
