using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerInVehicle : MonoBehaviour
{
	public float m_TempIncrease;

	public float m_FOV;

	public Vector2 m_PitchLimitDegrees;

	public Vector2 m_YawLimitDegrees;

	public float m_FadeOutSeconds;

	public float m_FadeInSeconds;

	private float m_StartCameraFOV;

	private Quaternion m_StartCameraRotation;

	private bool m_InVehicle;

	private bool m_EnteringVehicle;

	private Vector2 m_StartPitchLimit;

	private Vector2 m_StartYawLimit;

	private float m_TimeLastVehicleInteraction;

	private VehicleDoor m_VehicleDoorUsed;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool BlockSavingWhileInside()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[CalledBy(Type = typeof(VehicleDoor), Member = "UpdateDoorInProgress")]
	[CalledBy(Type = typeof(VehicleDoor), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 12)]
	public void EnterVehicle(VehicleDoor vd)
	{
	}

	[CalledBy(Type = typeof(VehicleDoor), Member = "UpdateDoorInProgress")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(VehicleDoor), Member = "ProcessInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void ExitVehicle(VehicleDoor vd)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsInside()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsEntering()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public float GetTempIncrease()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenVehicleRest")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenVehicleRest")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public void OnBedroll(GearItem gi = null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasInteractedWithVehicleSince(float seconds)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "GetVehicleDoorFromCollider")]
	public void ForceIntoVehicleSilent(Vector3 cameraPos)
	{
	}

	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	public Vector3 GetDropItemLocationForLastDoor()
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public bool HasDropLocationForLastDoor()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void EnterVehicleAfterFadeOut()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CallsUnknownMethods(Count = 78)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ForceIntoVehicleSilent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void EnterVehicleCommon()
	{
	}

	[CallsUnknownMethods(Count = 78)]
	[Calls(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void ExitVehicleAfterFadeOut()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ForceIntoVehicleSilent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private VehicleDoor GetVehicleDoorFromCollider(Collider c)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayerInVehicle()
	{
	}
}
