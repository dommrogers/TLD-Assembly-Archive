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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[CallsUnknownMethods(Count = 7)]
	public override void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HeadTrack()
	{
	}
}
