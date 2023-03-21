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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "IdentifyAllJoysticks")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_unityJoystickIdentificationRequired")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "IdentifyAllJoysticks")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "IdentifyAllJoysticks")]
	[DeduplicatedMethod]
	private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "JoystickDisconnected")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "JoystickConnected")]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "SetInputDelay")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "IdentifyAllJoysticks")]
	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "OnGUI")]
	private void SetInputDelay()
	{
	}

	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "SetUnityJoystickIdFromAnyButtonOrAxisPress")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "Reset")]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "SetInputDelay")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(GUILayout), Member = "Window")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUI), Member = "FocusWindow")]
	private void OnGUI()
	{
	}

	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(GUIStyle), Member = "set_wordWrap")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(GUI), Member = "get_skin")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsUnknownMethods(Count = 3)]
	private void DrawDialogWindow(int windowId)
	{
	}

	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "OnGUI")]
	[CallerCount(Count = 1)]
	private void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FallbackJoystickIdentificationDemo()
	{
	}
}
