using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AI;

public class FlareItem : MonoBehaviour
{
	public static HashSet<FlareItem> s_Flares;

	public FlareType m_Type;

	public float m_BurnLifetimeMinutes;

	public float m_LightRepositionRate;

	public float m_LightHeightOffset;

	public float m_IgniteDelaySeconds;

	public string m_IgniteAudio;

	public string m_BurnOutAudio;

	public string m_LoopWithoutIgniteAudio;

	public string m_CollideAudio;

	public float m_ThrowForce;

	public float m_ThrowTorque;

	public float m_StaminaDrainPerSecond;

	public float m_ReduceLifetimeMinutesPerSwing;

	private PanelReference<Panel_HUD> m_HUD;

	public string m_RadialSpriteName;

	public bool m_RuinedByWater;

	public FlareIntensity m_IntensityComponent;

	public float velDamp;

	public float aVelDamp;

	public bool m_CanThrow;

	public bool m_Thrown;

	public Color m_Color;

	private FlareState m_State;

	private FlareState m_PreviousState;

	private float m_ElapsedBurnMinutes;

	private GameObject m_FXGameObject;

	private HeatSource m_HeatSource;

	private GameObject m_FlareCapMeshObject;

	private MeshRenderer m_FlareCapMeshObjectMeshRenderer;

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

	private float m_IgniteDelay;

	private GearItem m_GearItem;

	private Rigidbody m_Rigidbody;

	private bool m_IgitePending;

	private NavMeshObstacle m_NavMeshObstacle;

	private static FlareItemSaveDataProxy m_FlareItemSaveDataProxy;

	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsUnknownMethods(Count = 17)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(FlareItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(FlareItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(FlareItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(FlareItem), Member = "UpdateLightPosition")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "EnableRendering")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(FlareItem), Member = "Ignite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallsUnknownMethods(Count = 17)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FlareItem), Member = "Ignite")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(FlareItem), Member = "MaybeEnableNavMeshObstacle")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Ignite()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(FlareItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(FlareItem), Member = "MaybeEnableNavMeshObstacle")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	public void Ignite(string igniteAudio)
	{
	}

	[CalledBy(Type = typeof(FlareItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(FlareItem), Member = "Ignite")]
	[CalledBy(Type = typeof(FlareItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[Calls(Type = typeof(MoveAgent), Member = "GetRadius")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "get_radius")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Rigidbody), Member = "get_velocity")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeEnableNavMeshObstacle(bool enable)
	{
	}

	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnIgniteComplete()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallsUnknownMethods(Count = 8)]
	public void IgniteDelayed()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void IgniteAfterDelay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[CallsUnknownMethods(Count = 3)]
	public void CancelIgnite()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void ForcePaused()
	{
	}

	[CallerCount(Count = 0)]
	public void PauseLight()
	{
	}

	[CallerCount(Count = 0)]
	public void ResumeLight()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsBurning()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsPaused()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Rigidbody), Member = "get_angularDrag")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody), Member = "get_drag")]
	public void OnCollisionStay(Collision collisionInfo)
	{
	}

	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[CalledBy(Type = typeof(FlareItem), Member = "PrepareForThrow")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "DisableRendering")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Drop")]
	public void DisableRendering(int numFrames)
	{
	}

	[CallerCount(Count = 0)]
	public void EnableCollisionAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlareItem), Member = "DisableRendering")]
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
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void HideEffects(bool hide)
	{
	}

	[CallerCount(Count = 0)]
	public void ForceExtinguish()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(FlareIntensity), Member = "Update")]
	public float GetNormalizedBurnTimeLeft()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	public float GetModifiedBurnLifetimeMinutes()
	{
		return default(float);
	}

	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[CallerCount(Count = 0)]
	public void OnDroppedInWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	public void ForceBurnout()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopLoopingAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateFlareAudioPosition()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 15)]
	private void UpdateLightPosition()
	{
	}

	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(FlareItem), Member = "ForceBurnout")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnDroppedInWater")]
	[Calls(Type = typeof(FlareItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	private void BurnOut()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void SetState(FlareState state)
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
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	public FlareItem()
	{
	}
}
