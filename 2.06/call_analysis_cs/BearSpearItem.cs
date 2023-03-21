using System;
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(PlayerControlMode);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	[CallsUnknownMethods(Count = 1)]
	private float GetDamageDealt(BaseAi bai)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private float GetBleedOutMinutes(BaseAi bai)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsDamageFatal(BaseAi bai, float damageDealt)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BearSpearItem), Member = "IsDamageFatal")]
	[Calls(Type = typeof(BaseAi), Member = "OnSpearHit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(BearSpearItem), Member = "GetAngleBetweenSpearAndBearHeadings")]
	private void OnAiCollidedWithSpear(BaseAi bai, Vector3 spearForward, LocalizedDamage localizedDamage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(BearSpearItem), Member = "Break")]
	[CallsUnknownMethods(Count = 2)]
	private void OnStruggleHitEnd()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private void Break()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool IsSpearHitLethal()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "HitAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "CanBeHitBySpear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private float DistanceToNearestSpearable()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeCollideWithSpear")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "CanBeHitBySpear")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	public void UpdateCollision(BaseAi bai)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void Update_SpearRaised()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Raised")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearSpearItem), Member = "Update_SpearRaised")]
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsRaisedOrRaisingOrLowering()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetActionElapsedInSeconds()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool CanStartZoom()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	public bool CheckStaminaForRaising()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool CanEndZoom()
	{
		return default(bool);
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpearAttackTooLate")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public float GetAngleBetweenSpearAndBearHeadings(BaseAi bai, Vector3 spearForward)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[CallsUnknownMethods(Count = 1)]
	private void RestoreYawPitchLimits()
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Recovering")]
	[CallerCount(Count = 0)]
	public void ZoomEnd()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update_SpearRaised")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	public void CancelAction()
	{
	}

	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	public void HitAction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 44)]
	public string GetStateDebugString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearSpearItem), Member = "MaybeEnableStaminaRecharge")]
	public void OnDestroy()
	{
	}

	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Raised")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Recovering")]
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
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "HitAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[Calls(Type = typeof(BearSpearItem), Member = "MaybeEnableStaminaRecharge")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterRecoverSpearMultiplier")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	private void OnEnter_None()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterSetSpearMultiplier")]
	private void OnEnter_Setting()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnEnter_Raised()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterRecoverSpearMultiplier")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim_Cancel")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CallsUnknownMethods(Count = 9)]
	private void OnEnter_Recovering()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnExit_None()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsEquipped()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public BearSpearItem()
	{
	}
}
