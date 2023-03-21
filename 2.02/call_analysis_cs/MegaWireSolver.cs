using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class MegaWireSolver
{
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void doIntegration1(MegaWireConnection rope, MegaWire wire, float dt)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void Solve()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MegaWireSolver()
	{
	}
}
