using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos;

public class PressAnyButtonToJoinExample_Assigner : MonoBehaviour
{
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsControllerAssigned")]
	[Calls(Type = typeof(PressAnyButtonToJoinExample_Assigner), Member = "FindPlayerWithoutJoystick")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void AssignJoysticksToPlayers()
	{
	}

	[CalledBy(Type = typeof(PressAnyButtonToJoinExample_Assigner), Member = "AssignJoysticksToPlayers")]
	[CalledBy(Type = typeof(PressAnyButtonToJoinExample_Assigner), Member = "DoAllPlayersHaveJoysticks")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[CallsUnknownMethods(Count = 4)]
	private Player FindPlayerWithoutJoystick()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PressAnyButtonToJoinExample_Assigner), Member = "FindPlayerWithoutJoystick")]
	private bool DoAllPlayersHaveJoysticks()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public PressAnyButtonToJoinExample_Assigner()
	{
	}
}
