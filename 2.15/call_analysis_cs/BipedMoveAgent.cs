using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class BipedMoveAgent : MonoBehaviour
{
	public NavMeshAgent m_NavMeshAgent;

	public Animator m_Animator;

	public Transform m_ObjectSyncPointTransform;

	public AnimationCurve m_AnimationCurve;

	public float m_BlendOutTime;

	public float m_BlendOutDistance;

	public float m_MinPathDistance;

	public GameObject m_LookAtGameObject;

	public float m_DesiredTargetWeight;

	public float m_DesiredTargetWeightBody;

	public float m_DesiredTargetWeightHead;

	public float m_DesiredTargetWeightEyes;

	public float m_DesiredTargetWeightClamp;

	public float m_TargetWeightTime;

	public float m_TargetWeightBodyTime;

	public float m_TargetWeightHeadTime;

	public float m_TargetWeightEyesTime;

	public float m_TargetWeightClampTime;

	public float m_ChangeTargetTime;

	public int m_AnimParameter_BipedTurning;

	public int m_AnimParameter_BipedTargetDistance;

	public int m_AnimParameter_BipedIsMoving;

	public int m_AnimParameter_BipedStopAngle;

	public int m_AnimParameter_BipedIsSmallStep;

	public int m_AnimParameter_BipedStartAngle;

	public int m_AnimParameter_BipedInterrupted;

	private Vector3 m_Destination;

	private Vector3 m_LastPosition;

	private float m_BlendOutTimer;

	private bool m_IsSmallStep;

	private bool m_IsNavigating;

	private float m_CurrentTargetWeight;

	private float m_CurrentTargetWeightBody;

	private float m_CurrentTargetWeightHead;

	private float m_CurrentTargetWeightEyes;

	private float m_CurrentTargetWeightClamp;

	private Vector3 m_LastTargetPosition;

	private float m_ChangeTargetWeight;

	private PlayableDirector m_PlayableDirector;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 14)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "UpdateStickToGround")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "UpdateAnimationBasedOnNavigation")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "UpdateAnimationBlendOut")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "UpdateStickToGround")]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(BipedMoveAgent), Member = "StopMovingImmediate")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "UpdateAnimationBlendOut")]
	[CalledBy(Type = typeof(Patrol), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Wander), Member = "OnExecute")]
	[CalledBy(Type = typeof(Wander), Member = "OnUpdate")]
	[CallerCount(Count = 5)]
	public bool IsMoving()
	{
		return false;
	}

	[CalledBy(Type = typeof(BipedMoveAgent), Member = "MaybePlayInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private void DoDynamicBinding()
	{
	}

	[CalledBy(Type = typeof(BipedMoveAgent), Member = "StopMoving")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "DoDynamicBinding")]
	[Calls(Type = typeof(PlayableDirector), Member = "add_stopped")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybePlayInteraction()
	{
	}

	[CalledBy(Type = typeof(BipedMoveAgent), Member = "StopMovingImmediate")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "UpdateAnimationBlendOut")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MaybePlayInteraction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void StopMoving()
	{
	}

	[CalledBy(Type = typeof(Patrol), Member = "OnStop")]
	[CalledBy(Type = typeof(Wander), Member = "OnStop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "IsMoving")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "StopMoving")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StopMovingImmediate()
	{
	}

	[CalledBy(Type = typeof(Patrol), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Wander), Member = "DoWander")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_pathStatus")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 17)]
	public bool SetDestination(Vector3 position, Transform gameObjectTransform = null)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void ClearLookAtGameObject()
	{
	}

	[CalledBy(Type = typeof(MecanimSetLookAt), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SetLookAtGameObject(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	public void SetSetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void OnAnimatorIK()
	{
	}

	[CalledBy(Type = typeof(BipedMoveAgent), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateAnimationBasedOnNavigation()
	{
	}

	[CalledBy(Type = typeof(BipedMoveAgent), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "IsMoving")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "StopMoving")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAnimationBlendOut()
	{
	}

	[CalledBy(Type = typeof(BipedMoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateStickToGround()
	{
	}

	[CalledBy(Type = typeof(BipedMoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "UpdateCurrentIKWeights")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Utils), Member = "MoveToValue")]
	private void MoveToWeight(ref float currentWeight, float desiredWeight, float time)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	private void UpdateCurrentIKWeights()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableDirector), Member = "remove_stopped")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPlayableDirectorStopped(PlayableDirector pd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "remove_stopped")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public BipedMoveAgent()
	{
	}
}
