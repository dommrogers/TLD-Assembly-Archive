using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OctreePointNode<T> where T : class
{
	private class OctreeObject
	{
		public T Obj;

		public Vector3 Pos;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public OctreeObject()
		{
		}
	}

	private Vector3 _003CCenter_003Ek__BackingField;

	private float _003CSideLength_003Ek__BackingField;

	private float minSize;

	private Bounds bounds;

	private readonly List<OctreeObject> objects;

	private OctreePointNode<T>[] children;

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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public float SideLength
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public OctreePointNode(float baseLengthVal, float minSizeVal, Vector3 centerVal)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool Add(T obj, Vector3 objPos)
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
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	public T[] GetNearby(Ray ray, float maxDistance)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public void SetChildren(OctreePointNode<T>[] childOctrees)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	public void DrawAllBounds(float depth = 0f)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void DrawAllObjects()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public OctreePointNode<T> ShrinkIfPossible(float minLength)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 16)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void SetValues(float baseLengthVal, float minSizeVal, Vector3 centerVal)
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SubAdd(T obj, Vector3 objPos)
	{
	}

	[CallsUnknownMethods(Count = 82)]
	[CallsDeduplicatedMethods(Count = 18)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Split()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Merge()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool Encapsulates(Bounds outerBounds, Vector3 point)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private int BestFitChild(Vector3 objPos)
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
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool HasAnyObjects()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 1)]
	public static float DistanceToRay(Ray ray, Vector3 point)
	{
		return default(float);
	}
}
