using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class MegaWireConstraint
{
	public bool active;

	public float reactivate;

	public float rtime;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void Apply(MegaWireConnection soft)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MegaWireConstraint()
	{
	}
}
