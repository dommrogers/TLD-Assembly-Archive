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

	[Calls(Type = typeof(CameraOverride), Member = "UpdateCamera")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraOverride), Member = "UpdateCamera")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CalledBy(Type = typeof(CameraOverride), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(CameraOverride), Member = "OnStateUpdate")]
	[CallsUnknownMethods(Count = 4)]
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
