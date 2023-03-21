using System;
using System.Collections.Generic;
using System.Globalization;
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
		[CallerCount(Count = 14)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public OctreeBounds(float initialWorldSize, Vector3 initialWorldPos, float minNodeSize, float loosenessVal)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	public void Add(T obj, Bounds objBounds)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
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
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
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

	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static int GetRootPosIndex(int xDir, int yDir, int zDir)
	{
		return default(int);
	}
}
