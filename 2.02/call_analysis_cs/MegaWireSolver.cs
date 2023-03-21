using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class MegaWireSolver
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void doIntegration1(MegaWireConnection rope, MegaWire wire, float dt)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void Solve()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MegaWireSolver()
	{
	}
}
