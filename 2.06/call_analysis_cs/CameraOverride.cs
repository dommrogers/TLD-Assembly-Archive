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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CameraOverride), Member = "UpdateCamera")]
	[CallsUnknownMethods(Count = 3)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraOverride), Member = "UpdateCamera")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CameraOverride), Member = "OnStateUpdate")]
	[CalledBy(Type = typeof(CameraOverride), Member = "OnStateEnter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
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
