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
	[Calls(Type = typeof(ReInput), Member = "get_unityJoystickIdentificationRequired")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "IdentifyAllJoysticks")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "Awake")]
	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "JoystickConnected")]
	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "JoystickDisconnected")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(TypeFullName = "bqgFhLJevgwGDBkMuBcbCeTHblPK", Member = "BDnioedRPzgfKGYCJPnUcwhBIaAG")]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "SetInputDelay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void IdentifyAllJoysticks()
	{
	}

	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "IdentifyAllJoysticks")]
	[CalledBy(Type = typeof(FallbackJoystickIdentificationDemo), Member = "OnGUI")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetInputDelay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(GUILayout), Member = "Window")]
	[Calls(Type = typeof(GUI), Member = "FocusWindow")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "SetUnityJoystickIdFromAnyButtonOrAxisPress")]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "SetInputDelay")]
	[Calls(Type = typeof(FallbackJoystickIdentificationDemo), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUI), Member = "get_skin")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(GUIStyle), Member = "set_wordWrap")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
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
