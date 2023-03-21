using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ODE3
{
	public int numEquations;

	public Vector3[] q;

	public float t;

	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void Update(float dt)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void Update2(float dt)
	{
	}
}
