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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
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
