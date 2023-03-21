using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OctreeBounds<T>
{
	private int _003CCount_003Ek__BackingField;

	private OctreeBoundsNode<T> rootNode;

	private readonly float looseness;

	private readonly float initialSize;

	private readonly float minSize;

	public int Count
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 26)]
	public OctreeBounds(float initialWorldSize, Vector3 initialWorldPos, float minNodeSize, float loosenessVal)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 2)]
	public void Add(T obj, Bounds objBounds)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public bool Remove(T obj)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsColliding(Bounds checkBounds)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void GetColliding(Bounds checkBounds, ref List<T> resultList)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void FrustumCapture(Plane[] frustumPlanes, ref List<T> captureList)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DrawAllBounds()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DrawAllObjects()
	{
	}

	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 27)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Grow(Vector3 direction)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void Shrink()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static int GetRootPosIndex(int xDir, int yDir, int zDir)
	{
		return default(int);
	}
}
