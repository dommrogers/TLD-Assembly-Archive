using Cpp2ILInjected.CallAnalysis;

public class Spring : ODE
{
	public float mass;

	public float damp;

	public float k;

	public float restLen;

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CallerCount(Count = 2)]
	public Spring(float _mass, float _dampening, float _k, float _restLength, float _initialLength)
		: base(default(int))
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override float[] GetRightHandSide(float t, float[] q, float[] deltaQ, float dt, float qScale)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetLength()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetLength(float length)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetVelocity()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SetVelocity(float velocity)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void AddForce(float force)
	{
	}
}
