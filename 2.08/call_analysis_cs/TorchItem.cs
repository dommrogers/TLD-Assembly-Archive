using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AI;

public class TorchItem : MonoBehaviour
{
	public static HashSet<TorchItem> s_Torches;

	public float m_BurnLifetimeMinutes;

	public float m_ExtinguishTime;

	public bool m_CanBeRelit;

	public bool m_CanBeHolstered;

	public float m_LightRepositionRate;

	public float m_LightHeightOffset;

	public GameObject m_TorchMeshGameObject;

	public GameObject m_TorchBurntMeshGameObject;

	public GameObject m_FXGameObject;

	public string m_IgniteAudio;

	public string m_ExtinguishAudio;

	public string m_BlownOutAudio;

	public string m_BurnOutAudio;

	public string m_LoopWithoutIgniteAudio;

	public string m_CollideAudio;

	public float m_ThrowForce;

	public float m_ThrowTorque;

	public float m_WindSpeedCannotIgnite;

	public float m_WindSpeedExtinguish;

	public float m_StaminaDrainPerSecond;

	public float m_ReduceLifetimeMinutesPerSwing;

	public string m_RadialSpriteName;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_TorchLight> m_TorchLight;

	public TorchIntensity m_IntensityComponent;

	public float velDamp;

	public float aVelDamp;

	public bool m_CanThrow;

	public bool m_Thrown;

	public float m_ElapsedBurnMinutes;

	public Color m_Color;

	private TorchState m_State;

	private TorchState m_PreviousState;

	private HeatSource m_HeatSource;

	private GameObject m_LightPosOriginalObject;

	private Light m_LightIndoor;

	private Light m_LightOutdoor;

	private float m_LightOffsetY;

	private uint m_IgniteAudioID;

	private float m_DragIncreaseAfterCollision;

	private bool m_RenderingDisabled;

	private float m_RenderingDisabledNumFramesLeft;

	private bool m_PlayCollisonAudio;

	private bool m_IgniteAfterDelay;

	private float m_ElapsedIgniteDelaySeconds;

	private float m_IgniteDelaySeconds;

	private uint m_IgniteLoop;

	private bool m_IgniteFromFire;

	private bool m_ExtinguishAfterDelay;

	private float m_ElapsedExtinguishDelaySeconds;

	private GearItem m_GearItem;

	private Rigidbody m_Rigidbody;

	private NavMeshObstacle m_NavMeshObstacle;

	private static TorchItemSaveDataProxy m_TorchItemSaveDataProxy;

	private bool m_FlareIsPaused;

	private const float DRAG_STATIONARY_LIMIT = 5000f;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[Calls(Type = typeof(TorchItem), Member = "MaybeAdjustHeatSource")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(TorchItem), Member = "UpdateLightPosition")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TorchItem), Member = "GetGearItem")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(TorchItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Utils), Member = "EnableRendering")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(TorchItem), Member = "Ignite")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(TorchItem), Member = "StopIgniteLoop")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TorchItem), Member = "Ignite")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorchItem), Member = "Ignite")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	public void Ignite()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CalledBy(Type = typeof(TorchItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Ignite(string igniteAudio)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallsUnknownMethods(Count = 2)]
	private void OnIgniteComplete()
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "StartTorchIgnite")]
	[CalledBy(Type = typeof(TorchItem), Member = "IgniteFromSource")]
	[Calls(Type = typeof(TorchItem), Member = "GetGearItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	public void IgniteDelayed(float delaySeconds, string igniteAudio, bool isFire)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void IgniteAfterDelay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TorchItem), Member = "IgniteDelayed")]
	[CallsUnknownMethods(Count = 3)]
	public void IgniteFromSource(GameObject source)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	public void CancelIgnite()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsSetToIgniteAfterDelay()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[Calls(Type = typeof(TorchItem), Member = "GetGearItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	public void ExtinguishDelayed()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnExtinguishCompleteCallback()
	{
	}

	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Extinguish")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ExtinguishAfterDelayStarted()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[CallsUnknownMethods(Count = 3)]
	public void CancelExtinguish()
	{
	}

	[CallerCount(Count = 0)]
	public bool CanBeLit()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsBurning()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsExtinguishing()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsBurnedOut()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsFresh()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	public void PauseLight()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	public void ResumeLight()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsPaused()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Rigidbody), Member = "get_angularDrag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Rigidbody), Member = "get_drag")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	public void OnCollisionStay(Collision collisionInfo)
	{
	}

	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(TorchItem), Member = "PrepareForThrow")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Drop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DisableRendering")]
	public void DisableRendering(int numFrames)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void EnableCollisionAudio()
	{
	}

	[Calls(Type = typeof(TorchItem), Member = "DisableRendering")]
	[CallerCount(Count = 0)]
	public void PrepareForThrow()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DestroyHeatSource()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[CallsUnknownMethods(Count = 2)]
	public void HideEffects(bool hide)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "TooWindyForPlayerAction")]
	public void AttemptToLight()
	{
	}

	[CallerCount(Count = 0)]
	public void ForceExtinguish()
	{
	}

	[CalledBy(Type = typeof(TorchIntensity), Member = "Update")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	public float GetBurnProgress()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void UpdateTorchAudioPosition()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CallsUnknownMethods(Count = 17)]
	private void UpdateLightPosition()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopBurningAudioLoop()
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnDroppedInWater")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	public void Extinguish(TorchState newState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsIgnitedFromFire()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	public float GetModifiedBurnLifetimeMinutes()
	{
		return default(float);
	}

	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[CallerCount(Count = 0)]
	public void OnDroppedInWater()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnDestroy")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnDisable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StopAudioForEquippedItem")]
	public void StopLoopingAudio()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ResumeLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[CalledBy(Type = typeof(TorchItem), Member = "Extinguish")]
	[CalledBy(Type = typeof(TorchItem), Member = "ResumeLight")]
	[CalledBy(Type = typeof(TorchItem), Member = "PauseLight")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CalledBy(Type = typeof(TorchItem), Member = "Deserialize")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TorchItem), Member = "GetGearItem")]
	[CalledBy(Type = typeof(TorchItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(TorchItem), Member = "Awake")]
	[CalledBy(Type = typeof(TorchItem), Member = "Deserialize")]
	private void SetState(TorchState state)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	private bool ShouldBlowOut()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	private void MaybeAdjustHeatSource()
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopIgniteLoop()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorchItem), Member = "StopLoopingAudio")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorchItem), Member = "StopLoopingAudio")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "SetState")]
	[CalledBy(Type = typeof(TorchItem), Member = "ExtinguishDelayed")]
	[CalledBy(Type = typeof(TorchItem), Member = "IgniteDelayed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	private GearItem GetGearItem()
	{
		return null;
	}

	[Calls(Type = typeof(MoveAgent), Member = "GetRadius")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(TorchItem), Member = "Extinguish")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CalledBy(Type = typeof(TorchItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NavMeshObstacle), Member = "get_radius")]
	private void MaybeEnableNavMeshObstacle(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public TorchItem()
	{
	}
}
