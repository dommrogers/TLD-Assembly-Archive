using Cpp2ILInjected.CallAnalysis;

public class ODE
{
	public int numEquations;

	public float[] q;

	public float t;

	[CallerCount(Count = 0)]
	public ODE(int _numEquations)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual float[] GetRightHandSide(float t, float[] q, float[] deltaQ, float dt, float qScale)
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
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Update2(float dt)
	{
	}
}
