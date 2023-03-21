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

	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[Calls(Type = typeof(PressAnyButtonToJoinExample_Assigner), Member = "FindPlayerWithoutJoystick")]
	[Calls(Type = typeof(PressAnyButtonToJoinExample_Assigner), Member = "FindPlayerWithoutJoystick")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsControllerAssigned")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void AssignJoysticksToPlayers()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PressAnyButtonToJoinExample_Assigner), Member = "DoAllPlayersHaveJoysticks")]
	[CalledBy(Type = typeof(PressAnyButtonToJoinExample_Assigner), Member = "AssignJoysticksToPlayers")]
	[CalledBy(Type = typeof(PressAnyButtonToJoinExample_Assigner), Member = "AssignJoysticksToPlayers")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	private Player FindPlayerWithoutJoystick()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PressAnyButtonToJoinExample_Assigner), Member = "FindPlayerWithoutJoystick")]
	private bool DoAllPlayersHaveJoysticks()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PressAnyButtonToJoinExample_Assigner()
	{
	}
}
