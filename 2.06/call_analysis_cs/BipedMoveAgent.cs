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

	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "UpdateStickToGround")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "UpdateAnimationBasedOnNavigation")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "StopMovingImmediate")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "UpdateAnimationBlendOut")]
	[CalledBy(Type = typeof(Patrol), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Wander), Member = "OnExecute")]
	[CalledBy(Type = typeof(Wander), Member = "OnUpdate")]
	public bool IsMoving()
	{
		return default(bool);
	}

	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "MaybePlayInteraction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CallsUnknownMethods(Count = 14)]
	private void DoDynamicBinding()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "StopMoving")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "DoDynamicBinding")]
	[Calls(Type = typeof(PlayableDirector), Member = "add_stopped")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void MaybePlayInteraction()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MaybePlayInteraction")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "StopMovingImmediate")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "UpdateAnimationBlendOut")]
	[CallsUnknownMethods(Count = 5)]
	private void StopMoving()
	{
	}

	[Calls(Type = typeof(BipedMoveAgent), Member = "IsMoving")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "StopMoving")]
	[CalledBy(Type = typeof(Patrol), Member = "OnStop")]
	[CalledBy(Type = typeof(Wander), Member = "OnStop")]
	[CallsUnknownMethods(Count = 2)]
	public void StopMovingImmediate()
	{
	}

	[CalledBy(Type = typeof(Patrol), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Wander), Member = "DoWander")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_pathStatus")]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	public bool SetDestination(Vector3 position, Transform gameObjectTransform = null)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void ClearLookAtGameObject()
	{
	}

	[CalledBy(Type = typeof(MecanimSetLookAt), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public void SetLookAtGameObject(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	public void SetSetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	public void OnAnimatorIK()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_desiredVelocity")]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	private void UpdateAnimationBasedOnNavigation()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "LateUpdate")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "StopMoving")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "IsMoving")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void UpdateAnimationBlendOut()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "LateUpdate")]
	private void UpdateStickToGround()
	{
	}

	[CalledBy(Type = typeof(BipedMoveAgent), Member = "UpdateCurrentIKWeights")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "UpdateCurrentIKWeights")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "UpdateCurrentIKWeights")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "UpdateCurrentIKWeights")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "UpdateCurrentIKWeights")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "UpdateCurrentIKWeights")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "Update")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Utils), Member = "MoveToValue")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "Update")]
	private void MoveToWeight(ref float currentWeight, float desiredWeight, float time)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[Calls(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	private void UpdateCurrentIKWeights()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayableDirector), Member = "remove_stopped")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnPlayableDirectorStopped(PlayableDirector pd)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "remove_stopped")]
	[CallsUnknownMethods(Count = 6)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public BipedMoveAgent()
	{
	}
}
