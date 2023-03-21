using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class MegaWireConstraint
{
	public bool active;

	public float reactivate;

	public float rtime;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void Apply(MegaWireConnection soft)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public MegaWireConstraint()
	{
	}
}
