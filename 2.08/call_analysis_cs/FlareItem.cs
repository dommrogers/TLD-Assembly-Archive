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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(FlareItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(FlareItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(FlareItem), Member = "UpdateLightPosition")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "EnableRendering")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(FlareItem), Member = "Ignite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	public void Update()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(FlareItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FlareItem), Member = "Ignite")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	public void Deserialize(string text)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Ignite()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(FlareItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[Calls(Type = typeof(FlareItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	public void Ignite(string igniteAudio)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(FlareItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(FlareItem), Member = "Ignite")]
	[CalledBy(Type = typeof(FlareItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[Calls(Type = typeof(MoveAgent), Member = "GetRadius")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "get_radius")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeEnableNavMeshObstacle(bool enable)
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
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void IgniteDelayed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[CallsUnknownMethods(Count = 3)]
	public void IgniteAfterDelay()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsBurning()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Rigidbody), Member = "get_angularDrag")]
	[Calls(Type = typeof(Rigidbody), Member = "get_drag")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	public void OnCollisionStay(Collision collisionInfo)
	{
	}

	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(Utils), Member = "DisableRendering")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(FlareItem), Member = "PrepareForThrow")]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	public float GetModifiedBurnLifetimeMinutes()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	public void OnDroppedInWater()
	{
	}

	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[CallsUnknownMethods(Count = 17)]
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
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[Calls(Type = typeof(FlareItem), Member = "MaybeEnableNavMeshObstacle")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	private void BurnOut()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SetState(FlareState state)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
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
