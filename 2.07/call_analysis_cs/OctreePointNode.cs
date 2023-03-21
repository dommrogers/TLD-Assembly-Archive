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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public float SideLength
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public T[] GetNearby(Ray ray, float maxDistance)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 2)]
	public void SetChildren(OctreePointNode<T>[] childOctrees)
	{
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void DrawAllBounds(float depth = 0f)
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void DrawAllObjects()
	{
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public OctreePointNode<T> ShrinkIfPossible(float minLength)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 2)]
	private void SetValues(float baseLengthVal, float minSizeVal, Vector3 centerVal)
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SubAdd(T obj, Vector3 objPos)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 42)]
	private void Split()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Merge()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldMerge()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool HasAnyObjects()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float DistanceToRay(Ray ray, Vector3 point)
	{
		return default(float);
	}
}
