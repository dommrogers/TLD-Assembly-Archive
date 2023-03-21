using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OctreePoint<T> where T : class
{
	private int _003CCount_003Ek__BackingField;

	private OctreePointNode<T> rootNode;

	private readonly float initialSize;

	private readonly float minSize;

	public int Count
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public OctreePoint(float initialWorldSize, Vector3 initialWorldPos, float minNodeSize)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[DeduplicatedMethod]
	public void Add(T obj, Vector3 objPos)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public bool Remove(T obj)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public T[] GetNearby(Ray ray, float maxDistance)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DrawAllBounds()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void DrawAllObjects()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 8)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Grow(Vector3 direction)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
