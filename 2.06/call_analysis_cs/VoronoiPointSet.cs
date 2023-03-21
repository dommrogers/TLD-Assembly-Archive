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

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VoronoiPointSet), Member = "GetPoint")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(BreakableIce), Member = "AddBrokenIceToTexture")]
	[CalledBy(Type = typeof(BreakableIce), Member = "RemoveBrokenIceFromTexture")]
	public int ComputeNearestPointIndex(Vector2 pos)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public Vector2 GetPoint(int index)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(VoronoiPointSet), Member = "SetPoint")]
	[CallsUnknownMethods(Count = 2)]
	public void Randomize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[CallsUnknownMethods(Count = 1)]
	public void CopyTo(Vector4[] array, int index)
	{
	}

	[CalledBy(Type = typeof(VoronoiPointSet), Member = "Randomize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(VoronoiPointSet), Member = ".ctor")]
	[CallerCount(Count = 2)]
	public void SetPoint(int index, Vector2 point)
	{
	}
}
