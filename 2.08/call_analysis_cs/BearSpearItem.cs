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
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetDamageDealt(BaseAi bai)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private float GetBleedOutMinutes(BaseAi bai)
	{
		return default(float);
	}

	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private bool IsDamageFatal(BaseAi bai, float damageDealt)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "OnSpearHit")]
	[Calls(Type = typeof(BearSpearItem), Member = "IsDamageFatal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(BearSpearItem), Member = "GetAngleBetweenSpearAndBearHeadings")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnAiCollidedWithSpear(BaseAi bai, Vector3 spearForward, LocalizedDamage localizedDamage)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearSpearItem), Member = "Break")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	private void OnStruggleHitEnd()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	private void Break()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	private bool IsSpearHitLethal()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "HitAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "CanBeHitBySpear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	private float DistanceToNearestSpearable()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeCollideWithSpear")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "CanBeHitBySpear")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public void UpdateCollision(BaseAi bai)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[Calls(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BearSpearItem), Member = "IsEquipped")]
	private void Update_SpearRaised()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Raised")]
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
	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	public void ZoomEnd()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update_SpearRaised")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[CallerCount(Count = 2)]
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

	[CallsUnknownMethods(Count = 44)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
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
	[CalledBy(Type = typeof(BearSpearItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim_Cancel")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterRecoverSpearMultiplier")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Raised")]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "HitAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterRecoverSpearMultiplier")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BearSpearItem), Member = "MaybeEnableStaminaRecharge")]
	private void OnEnter_None()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterSetSpearMultiplier")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private void OnEnter_Setting()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnEnter_Raised()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterRecoverSpearMultiplier")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim_Cancel")]
	[CallsUnknownMethods(Count = 4)]
	private void OnEnter_Recovering()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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
	[CallsUnknownMethods(Count = 1)]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnDestroy")]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update_SpearRaised")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsEquipped()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public BearSpearItem()
	{
	}
}
