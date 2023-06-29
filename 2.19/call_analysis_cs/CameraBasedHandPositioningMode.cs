using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraBasedHandPositioningMode : StateMachineBehaviour
{
	public PlayerAnimation.CameraBasedHandPositioningMode m_OnEnter;

	public bool m_RestoreOnExit;

	public PlayerAnimation.CameraBasedHandPositioningMode m_OnExit;

	private PlayerAnimation.CameraBasedHandPositioningMode m_RestoreMode;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraBasedHandPositioningMode")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnStateMachineEnter(Animator animator, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraBasedHandPositioningMode")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnStateMachineExit(Animator animator, int layerIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public CameraBasedHandPositioningMode()
	{
	}
}
