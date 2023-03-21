using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraOverride : StateMachineBehaviour
{
	public enum Action
	{
		DoNothing,
		BlendToPitch
	}

	public float m_SecondsToDamp;

	public float m_TargetPitch;

	private float m_StartTime;

	private float m_StartPitch;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CameraOverride), Member = "UpdateCamera")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraOverride), Member = "UpdateCamera")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CalledBy(Type = typeof(CameraOverride), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(CameraOverride), Member = "OnStateUpdate")]
	private void UpdateCamera()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public CameraOverride()
	{
	}
}
