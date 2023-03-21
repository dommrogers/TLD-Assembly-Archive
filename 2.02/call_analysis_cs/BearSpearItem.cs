using System;
using System.Globalization;
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	[CallsUnknownMethods(Count = 2)]
	private float GetDamageDealt(BaseAi bai)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private float GetBleedOutMinutes(BaseAi bai)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "IsDamageFatal")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsDamageFatal(BaseAi bai, float damageDealt)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "OnSpearHit")]
	[Calls(Type = typeof(BaseAi), Member = "IsDamageFatal")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(BearSpearItem), Member = "GetAngleBetweenSpearAndBearHeadings")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "IsLastEncounter")]
	private void OnAiCollidedWithSpear(BaseAi bai, Vector3 spearForward, LocalizedDamage localizedDamage)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BearSpearItem), Member = "Break")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	private void OnStruggleHitEnd()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 14)]
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

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "HitAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "Magnitude")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "CanBeHitBySpear")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private float DistanceToNearestSpearable()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 17)]
	private static Vector3 UpdateHudBearSpearSprite(GameObject hudObject, UISprite sprite, Vector3 viewportSpearLocation, float size, bool isSpearInsideTarget, Color insideColor, Color outsideColor)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeCollideWithSpear")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "CanBeHitBySpear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public void UpdateCollision(BaseAi bai)
	{
	}

	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[Calls(Type = typeof(BearSpearItem), Member = "IsEquipped")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Update_SpearRaised()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Raised")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[Calls(Type = typeof(BearSpearItem), Member = "IsEquipped")]
	[Calls(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
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

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float GetActionElapsedInSeconds()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool CanStartZoom()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[CallsUnknownMethods(Count = 5)]
	public void ZoomStart()
	{
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public SpearState GetCurrentSpearState()
	{
		return default(SpearState);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpearAttackTooLate")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CallsUnknownMethods(Count = 3)]
	public float GetAngleBetweenSpearAndBearHeadings(BaseAi bai, Vector3 spearForward)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void RestoreYawPitchLimits()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Recovering")]
	public void ZoomEnd()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update_SpearRaised")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	public void CancelAction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CallsUnknownMethods(Count = 5)]
	public void HitAction()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
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
	[CallerCount(Count = 2)]
	private void OnRaised()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnRaisedCancelled()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[Calls(Type = typeof(BearSpearItem), Member = "MaybeEnableStaminaRecharge")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "HitAction")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterRecoverSpearMultiplier")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetHipAndShoulderOffsetLayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	private void OnEnter_None()
	{
	}

	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "ZoomStart")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterSetSpearMultiplier")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void OnEnter_Setting()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	private void OnEnter_Raised()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetParameterRecoverSpearMultiplier")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim_Cancel")]
	private void OnEnter_Recovering()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnExit_None()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnExit_Setting()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnExit_Raised()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnExit_Recovering()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnEnter_None")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update_SpearRaised")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsEquipped()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BearSpearItem()
	{
	}
}
