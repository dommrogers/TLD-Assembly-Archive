using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class VoronoiPointSet
{
	public const int POINT_COUNT = 16;

	private Vector4[] m_Points;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VoronoiPointSet), Member = "SetPoint")]
	[CallsUnknownMethods(Count = 2)]
	public VoronoiPointSet()
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "RemoveBrokenIceFromTexture")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BreakableIce), Member = "AddBrokenIceToTexture")]
	[Calls(Type = typeof(VoronoiPointSet), Member = "GetPoint")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(VoronoiPointSet), Member = "GetPoint")]
	[CallerCount(Count = 3)]
	public int ComputeNearestPointIndex(Vector2 pos)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	[CalledBy(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	[CallsUnknownMethods(Count = 2)]
	public Vector2 GetPoint(int index)
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(VoronoiPointSet), Member = "SetPoint")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public void Randomize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[CallsUnknownMethods(Count = 1)]
	public void CopyTo(Vector4[] array, int index)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(VoronoiPointSet), Member = ".ctor")]
	[CalledBy(Type = typeof(VoronoiPointSet), Member = "Randomize")]
	[CallsUnknownMethods(Count = 2)]
	public void SetPoint(int index, Vector2 point)
	{
	}
}
