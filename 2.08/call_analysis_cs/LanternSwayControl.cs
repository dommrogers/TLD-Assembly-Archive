using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LanternSwayControl : StateMachineBehaviour
{
	public float m_SecondsToDamp;

	private SoftJointLimit m_AngularLimitY;

	private SoftJointLimit m_AngularLimitZ;

	private ConfigurableJoint m_ConfigurableJoint;

	private float m_StartTime;

	private float m_StartAngularLimitY;

	private float m_StartAngularLimitZ;

	public float m_TargetAngularLimitY;

	public float m_TargetAngularLimitZ;

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public LanternSwayControl()
	{
	}
}
