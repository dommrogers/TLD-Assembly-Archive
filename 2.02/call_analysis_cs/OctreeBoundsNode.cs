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
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(Bounds), Member = "op_Equality")]
		[CallsUnknownMethods(Count = 7)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Bounds), Member = "op_Equality")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Bounds), Member = "op_Equality")]
		[CallsUnknownMethods(Count = 2)]
		public static bool operator ==(OctreeObject lhs, OctreeObject rhs)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Bounds), Member = "op_Equality")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public OctreeBoundsNode(float baseLengthVal, float minSizeVal, float loosenessVal, Vector3 centerVal)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool Add(T obj, Bounds objBounds)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	public bool Remove(T obj)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	public bool IsColliding(Bounds checkBounds)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CallsUnknownMethods(Count = 3)]
	public void GetColliding(Bounds checkBounds, ref List<T> resultList)
	{
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void FrustumCapture(Plane[] frustumPlanes, ref List<T> captureList)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	public void SetChildren(OctreeBoundsNode<T>[] childOctrees)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	public void DrawAllBounds(float depth = 0f)
	{
	}

	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 18)]
	public void DrawAllObjects()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 9)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public OctreeBoundsNode<T> ShrinkIfPossible(float minLength)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 25)]
	private void SetValues(float baseLengthVal, float minSizeVal, float loosenessVal, Vector3 centerVal)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 22)]
	private void SubAdd(T obj, Bounds objBounds)
	{
	}

	[CallsUnknownMethods(Count = 106)]
	[CallsDeduplicatedMethods(Count = 19)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Split()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Merge()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	private static bool Encapsulates(Bounds outerBounds, Bounds innerBounds)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private int BestFitChild(Bounds objBounds)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool ShouldMerge()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool HasAnyObjects()
	{
		return default(bool);
	}
}
