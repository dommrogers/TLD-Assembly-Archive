using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

public class RopeExitPoint : BaseInteraction
{
	public Rope m_Rope;

	public Transform m_ExitPoint;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerClimbRope), Member = "RequestExitToPoint")]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformInteraction()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	public RopeExitPoint()
	{
	}
}
