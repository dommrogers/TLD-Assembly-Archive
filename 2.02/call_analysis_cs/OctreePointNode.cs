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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public OctreePointNode(float baseLengthVal, float minSizeVal, Vector3 centerVal)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool Add(T obj, Vector3 objPos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool Remove(T obj)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 12)]
	public T[] GetNearby(Ray ray, float maxDistance)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public void SetChildren(OctreePointNode<T>[] childOctrees)
	{
	}

	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 9)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void DrawAllBounds(float depth = 0f)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 13)]
	public void DrawAllObjects()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	public OctreePointNode<T> ShrinkIfPossible(float minLength)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 25)]
	[CallsDeduplicatedMethods(Count = 26)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SetValues(float baseLengthVal, float minSizeVal, Vector3 centerVal)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 23)]
	private void SubAdd(T obj, Vector3 objPos)
	{
	}

	[CallsUnknownMethods(Count = 106)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 19)]
	private void Split()
	{
	}

	[CallsUnknownMethods(Count = 3)]
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
	[CallsUnknownMethods(Count = 1)]
	private int BestFitChild(Vector3 objPos)
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	public static float DistanceToRay(Ray ray, Vector3 point)
	{
		return default(float);
	}
}
