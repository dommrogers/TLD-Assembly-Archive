using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

public class RopeExitPoint : BaseInteraction
{
	public Rope m_Rope;

	public Transform m_ExitPoint;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerClimbRope), Member = "RequestExitToPoint")]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	public RopeExitPoint()
	{
	}
}
