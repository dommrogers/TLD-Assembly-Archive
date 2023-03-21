using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BearSpearItem : MonoBehaviour
{
	public enum SpearState
	{
		None,
		Setting,
		Raised,
		Recovering
	}

	public float m_SetSpearDurationSeconds;

	public float m_RecoverSpearDurationSeconds;

	public Vector2 m_PitchLimitDegrees;

	public Vector2 m_YawLimitDegrees;

	public GameObject m_BrokenSpearPrefab;

	public float m_StaminaCost;

	public float m_DamageDealt;

	public float m_BleedOutMinutes;

	public float m_DistanceForDamageMeters;

	public float m_AngleForDamageDegrees;

	public float m_AnimationSetBaseDuration;

	public float m_AnimationRecoverBaseDuration;

	private GearItem m_GearItem;

	private float m_ActionElapsedSeconds;

	private SpearState m_CurrentSpearState;

	private PlayerControlMode _003Cm_ControlModeToRestore_003Ek__BackingField;

	private Vector2 m_StartPitchLimit;

	private Vector2 m_StartYawLimit;

	private BaseAi m_HitAi;

	private LocalizedDamage m_LocalizedDamage;

	private Vector3 m_HitPosition;

	private Vector3 m_HitSourcePosition;

	private float m_HitDamage;

	private float m_HitBleedOutMinutes;

	private SpearState m_PendingSpearState;

	private bool m_HasDisabledHipAndShoulderOffsetLayer;

	private bool m_HasTriggeredGenericAim;

	private float m_PreviousTimeScale;

	private AnimatorUpdateMode m_PreviousAnimatorUpdateMode;

	private BearSpearHead m_BearSpearHead;

	private const float MAX_MULTIPLIER = 10000f;

	public PlayerControlMode m_ControlModeToRestore
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(PlayerControlMode);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	[CallsUnknownMethods(Count = 1)]
	private float GetDamageDealt(BaseAi bai)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private float GetBleedOutMinutes(BaseAi bai)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsDamageFatal(BaseAi bai, float damageDealt)
	{
		return false;
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BearSpearItem), Member = "GetAngleBetweenSpearAndBearHeadings")]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	[Calls(Type = typeof(BearSpearItem), Member = "IsDamageFatal")]
	[Calls(Type = typeof(BaseAi), Member = "OnSpearHit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	private void OnAiCollidedWithSpear(BaseAi bai, Vector3 spearForward, LocalizedDamage localizedDamage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(BearSpearItem), Member = "Break")]
	[CallsUnknownMethods(Count = 2)]
	private void OnStruggleHitEnd()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	private void Break()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool IsSpearHitLethal()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "HitAction")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BaseAi), Member = "CanBeHitBySpear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private float DistanceToNearestSpearable()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeCollideWithSpear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "CanBeHitBySpear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	public void UpdateCollision(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Update_SpearRaised()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[Calls(Type = typeof(BearSpearItem), Member = "Update_SpearRaised")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Raised")]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsRaised()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsRaisedOrRaisingOrLowering()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetActionElapsedInSeconds()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool CanStartZoom()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public bool CheckStaminaForRaising()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool CanEndZoom()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[CallsUnknownMethods(Count = 5)]
	public void ZoomStart()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SpearState GetCurrentSpearState()
	{
		return default(SpearState);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpearAttackTooLate")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 2)]
	public float GetAngleBetweenSpearAndBearHeadings(BaseAi bai, Vector3 spearForward)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[CallsUnknownMethods(Count = 1)]
	private void RestoreYawPitchLimits()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Recovering")]
	public void ZoomEnd()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "Update_SpearRaised")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CallsUnknownMethods(Count = 5)]
	public void CancelAction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CallsUnknownMethods(Count = 5)]
	public void HitAction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 40)]
	public string GetStateDebugString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearSpearItem), Member = "MaybeEnableStaminaRecharge")]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Recovering")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Raised")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	private void SetCurrentState(SpearState state)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnRaised()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnRaisedCancelled()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "HitAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterRecoverSpearMultiplier")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(BearSpearItem), Member = "MaybeEnableStaminaRecharge")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnter_None()
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterSetSpearMultiplier")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void OnEnter_Setting()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnter_Raised()
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterRecoverSpearMultiplier")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim_Cancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void OnEnter_Recovering()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnExit_None()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnExit_Setting()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnExit_Raised()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnExit_Recovering()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsEquipped()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public BearSpearItem()
	{
	}
}
