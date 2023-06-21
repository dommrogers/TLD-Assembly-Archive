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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(TorchItem), Member = "StopIgniteLoop")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(TorchItem), Member = "Ignite")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Utils), Member = "EnableRendering")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeAdjustHeatSource")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(TorchItem), Member = "UpdateLightPosition")]
	[Calls(Type = typeof(TorchItem), Member = "GetGearItem")]
	[Calls(Type = typeof(TorchItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(GearItem), Member = "set_CurrentHP")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
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

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[Calls(Type = typeof(TorchItem), Member = "Ignite")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorchItem), Member = "Ignite")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	public void Ignite()
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void Ignite(string igniteAudio)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallsUnknownMethods(Count = 2)]
	private void OnIgniteComplete()
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "IgniteFromSource")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "StartTorchIgnite")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TorchItem), Member = "GetGearItem")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void IgniteDelayed(float delaySeconds, string igniteAudio, bool isFire)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[CallsUnknownMethods(Count = 5)]
	public void IgniteAfterDelay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorchItem), Member = "IgniteDelayed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void IgniteFromSource(GameObject source)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 5)]
	public void CancelIgnite()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsSetToIgniteAfterDelay()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TorchItem), Member = "GetGearItem")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ExtinguishDelayed()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnExtinguishCompleteCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Extinguish")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void ExtinguishAfterDelayStarted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[CallsUnknownMethods(Count = 3)]
	public void CancelExtinguish()
	{
	}

	[CallerCount(Count = 0)]
	public bool CanBeLit()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsBurning()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsExtinguishing()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsBurnedOut()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsFresh()
	{
		return false;
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
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Rigidbody), Member = "get_drag")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Rigidbody), Member = "get_angularDrag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	public void OnCollisionStay(Collision collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "PrepareForThrow")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Drop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "DisableRendering")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DisableRendering(int numFrames)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void EnableCollisionAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorchItem), Member = "DisableRendering")]
	public void PrepareForThrow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[CallsUnknownMethods(Count = 1)]
	public void DestroyHeatSource()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void HideEffects(bool hide)
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(Wind), Member = "TooWindyForPlayerAction")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AttemptToLight()
	{
	}

	[CallerCount(Count = 0)]
	public void ForceExtinguish()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(TorchIntensity), Member = "Update")]
	[CallerCount(Count = 2)]
	public float GetBurnProgress()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateTorchAudioPosition()
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 17)]
	private void UpdateLightPosition()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopBurningAudioLoop()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnDroppedInWater")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void Extinguish(TorchState newState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsIgnitedFromFire()
	{
		return false;
	}

	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CallerCount(Count = 2)]
	public float GetModifiedBurnLifetimeMinutes()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	public void OnDroppedInWater()
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "OnDestroy")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnDisable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StopAudioForEquippedItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopLoopingAudio()
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "Awake")]
	[CalledBy(Type = typeof(TorchItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CalledBy(Type = typeof(TorchItem), Member = "PauseLight")]
	[CalledBy(Type = typeof(TorchItem), Member = "ResumeLight")]
	[CalledBy(Type = typeof(TorchItem), Member = "Extinguish")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ResumeLight")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(TorchItem), Member = "GetGearItem")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void SetState(TorchState state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private bool ShouldBlowOut()
	{
		return false;
	}

	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorchItem), Member = "StopLoopingAudio")]
	[Calls(Type = typeof(HashSet<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorchItem), Member = "StopLoopingAudio")]
	[Calls(Type = typeof(HashSet<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(TorchItem), Member = "ExtinguishDelayed")]
	[CalledBy(Type = typeof(TorchItem), Member = "SetState")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent")]
	private GearItem GetGearItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CalledBy(Type = typeof(TorchItem), Member = "Extinguish")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "get_radius")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "GetRadius")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 14)]
	private void MaybeEnableNavMeshObstacle(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public TorchItem()
	{
	}
}
