using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Spring3 : ODE3
{
	public float mass;

	public Vector3 damp;

	public Vector3 k;

	public Vector3 restPos;

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Spring3(float _mass, Vector3 _dampening, Vector3 _k, Vector3 _restPosition, Vector3 _initialPosition)
		: base(default(int))
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public override Vector3[] GetRightHandSide(float t, Vector3[] q, Vector3[] deltaQ, float dt, float qScale)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetPosition(Vector3 position)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void SetVelocity(Vector3 velocity)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AddForce(Vector3 force)
	{
	}
}
