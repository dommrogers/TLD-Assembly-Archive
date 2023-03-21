using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraLayer : StateMachineBehaviour
{
	private PlayerAnimation.CameraLayer m_Layer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CallsUnknownMethods(Count = 2)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CameraLayer()
	{
	}
}
