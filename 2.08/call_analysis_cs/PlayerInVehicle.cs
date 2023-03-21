using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class PlayerInVehicle : MonoBehaviour
{
	private PanelReference<Panel_Rest> m_Rest;

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

	private VehicleDoor m_VehicleDoorUsed;

	private bool _003CIsTransitioning_003Ek__BackingField;

	public bool IsTransitioning
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool BlockSavingWhileInside()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(VehicleDoor), Member = "PerformInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	public void EnterVehicle(VehicleDoor vd)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(VehicleDoor), Member = "PerformInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
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

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenVehicleRest")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenVehicleRest")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	public void OnBedroll(GearItem gi = null)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "GetVehicleDoorFromCollider")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void ForceIntoVehicleSilent(Vector3 cameraPos)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	public Vector3 GetDropItemLocationForLastDoor()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ForceIntoVehicleSilent")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void EnterVehicleCommon()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void ExitVehicleAfterFadeOut()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ForceIntoVehicleSilent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private VehicleDoor GetVehicleDoorFromCollider(Collider c)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnDoneTransitioning()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlayerInVehicle()
	{
	}
}
