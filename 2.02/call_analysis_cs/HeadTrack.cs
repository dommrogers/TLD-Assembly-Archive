using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeadTrack : StateMachineBehaviour
{
	public enum TargetType
	{
		AiMarker,
		Target
	}

	public TargetType m_TargetType;

	public bool m_CanRunWhileInTransition;

	public float m_LookWeightHead;

	public float m_LookWeightEyes;

	public float m_LookWeightBody;

	public float m_LookWeightClamp;

	public float m_LookAtDistance;

	private float m_LookWeightMaster;

	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	public override void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public HeadTrack()
	{
	}
}
