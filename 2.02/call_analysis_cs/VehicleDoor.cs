using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class VehicleDoor : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public string m_OpenAudio;

	public string m_CloseAudio;

	public GameObject m_CameraDummy;

	public GameObject m_ExitPoint;

	public BoxCollider m_ItemDropBox;

	public Bed m_Bed;

	public bool m_BlockSavingWhileInside;

	private bool m_IsBeingInteractedWith;

	private float m_InteractTimer;

	private PlayerControlMode m_RestoreControlMode;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 12)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(VehicleDoor), Member = "Cancel")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "EnterVehicle")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "ExitVehicle")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VehicleDoor), Member = "Cancel")]
	public static void UpdateDoorInProgress()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public bool StartInteract()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(VehicleDoor), Member = "UpdateDoorInProgress")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CalledBy(Type = typeof(VehicleDoor), Member = "UpdateDoorInProgress")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	public void Cancel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ProgressBarStarted()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerInVehicle), Member = "EnterVehicle")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "ExitVehicle")]
	[CallsUnknownMethods(Count = 8)]
	public void ProcessInteraction()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetHoverText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public VehicleDoor()
	{
	}
}
