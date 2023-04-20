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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraOverride), Member = "UpdateCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraOverride), Member = "UpdateCamera")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CalledBy(Type = typeof(CameraOverride), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(CameraOverride), Member = "OnStateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateCamera()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public CameraOverride()
	{
	}
}
