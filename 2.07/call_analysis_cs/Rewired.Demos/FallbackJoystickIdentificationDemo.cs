using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos;

public class FallbackJoystickIdentificationDemo : MonoBehaviour
{
	private const float windowWidth = 250f;

	private const float windowHeight = 250f;

	private const float inputDelay = 1f;

	private bool identifyRequired;

	private Queue<Joystick> joysticksToIdentify;

	private float nextInputAllowedTime;

	private GUIStyle style;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_unityJoystickIdentificationRequired")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "IdentifyAllJoysticks")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "IdentifyAllJoysticks")]
	private void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "IdentifyAllJoysticks")]
	private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "JoystickConnected")]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "SetInputDelay")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "JoystickDisconnected")]
	[Calls(Type = typeof(bqgFhLJevgwGDBkMuBcbCeTHblPK), Member = "BDnioedRPzgfKGYCJPnUcwhBIaAG")]
	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "Awake")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	public void IdentifyAllJoysticks()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "IdentifyAllJoysticks")]
	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "OnGUI")]
	[CallsUnknownMethods(Count = 1)]
	private void SetInputDelay()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "SetInputDelay")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "SetUnityJoystickIdFromAnyButtonOrAxisPress")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(GUI), Member = "FocusWindow")]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "Reset")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Window")]
	private void OnGUI()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUIStyle), Member = "set_wordWrap")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(GUI), Member = "get_skin")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	private void DrawDialogWindow(int windowId)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "OnGUI")]
	private void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FallbackJoystickIdentificationDemo()
	{
	}
}
