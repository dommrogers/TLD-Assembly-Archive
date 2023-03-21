using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ODE3
{
	public int numEquations;

	public Vector3[] q;

	public float t;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ODE3(int _numEquations)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual Vector3[] GetRightHandSide(float t, Vector3[] q, Vector3[] deltaQ, float dt, float qScale)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	public void Update(float dt)
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 26)]
	public void Update2(float dt)
	{
	}
}
