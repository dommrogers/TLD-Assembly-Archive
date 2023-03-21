using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Spring3 : ODE3
{
	public float mass;

	public Vector3 damp;

	public Vector3 k;

	public Vector3 restPos;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Spring3(float _mass, Vector3 _dampening, Vector3 _k, Vector3 _restPosition, Vector3 _initialPosition)
		: base(default(int))
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override Vector3[] GetRightHandSide(float t, Vector3[] q, Vector3[] deltaQ, float dt, float qScale)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SetPosition(Vector3 position)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetVelocity(Vector3 velocity)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void AddForce(Vector3 force)
	{
	}
}
