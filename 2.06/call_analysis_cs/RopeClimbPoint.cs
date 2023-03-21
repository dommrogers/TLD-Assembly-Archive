using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RopeClimbPoint : MonoBehaviour
{
	public Rope m_Rope;

	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 7)]
	public void PerformInteraction()
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "OnRopeTransition")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnRopeTransition(bool playerOnRope)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public RopeClimbPoint()
	{
	}
}
