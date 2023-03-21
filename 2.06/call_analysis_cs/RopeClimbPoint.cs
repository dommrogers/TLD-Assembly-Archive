using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RopeClimbPoint : MonoBehaviour
{
	public Rope m_Rope;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CallsUnknownMethods(Count = 7)]
	public void PerformInteraction()
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "OnRopeTransition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnRopeTransition(bool playerOnRope)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public RopeClimbPoint()
	{
	}
}
