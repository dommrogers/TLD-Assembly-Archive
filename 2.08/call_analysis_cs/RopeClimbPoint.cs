using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RopeClimbPoint : MonoBehaviour
{
	public Rope m_Rope;

	[Calls(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "OnRopeTransition")]
	[CallsUnknownMethods(Count = 3)]
	public void OnRopeTransition(bool playerOnRope)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RopeClimbPoint()
	{
	}
}
