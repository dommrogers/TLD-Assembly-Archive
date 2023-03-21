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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual float[] GetRightHandSide(float t, float[] q, float[] deltaQ, float dt, float qScale)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Update(float dt)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CallsUnknownMethods(Count = 2)]
	public void Update2(float dt)
	{
	}
}
