using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class VoronoiPointSet
{
	public const int POINT_COUNT = 16;

	private Vector4[] m_Points;

	[Calls(Type = typeof(VoronoiPointSet), Member = "SetPoint")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	public VoronoiPointSet()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(VoronoiPointSet), Member = "GetPoint")]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[Calls(Type = typeof(VoronoiPointSet), Member = "GetPoint")]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(BreakableIce), Member = "AddBrokenIceToTexture")]
	[CalledBy(Type = typeof(BreakableIce), Member = "RemoveBrokenIceFromTexture")]
	public int ComputeNearestPointIndex(Vector2 pos)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	public Vector2 GetPoint(int index)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(VoronoiPointSet), Member = "SetPoint")]
	[CallsUnknownMethods(Count = 1)]
	public void Randomize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	public void CopyTo(Vector4[] array, int index)
	{
	}

	[CalledBy(Type = typeof(VoronoiPointSet), Member = "Randomize")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(VoronoiPointSet), Member = ".ctor")]
	public void SetPoint(int index, Vector2 point)
	{
	}
}
