using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingZone : MonoBehaviour
{
	public string m_SceneToLoad;

	public string m_ExitPointName;

	public bool m_SceneCanBeInstanced;

	public string m_SoundDuringFadeOut;

	public string m_SoundDuringFadeIn;

	public LocalizedString m_LocalizedTransitionType;

	public LoadScene m_PartnerLoadScene;

	public string m_SceneLocationLocIDToShow;

	public bool m_FadeOutStarted;

	private string m_GUID;

	private Vector3 m_Forward;

	private bool m_IsBeingInteractedWith;

	private float m_InteractTimer;

	private PlayerControlMode m_RestoreControlMode;

	public string m_TransitionType
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

	[Calls(Type = typeof(Utils), Member = "GetGuid")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(LoadingZone), Member = "Cancel")]
	[Calls(Type = typeof(LoadingZone), Member = "Cancel")]
	[Calls(Type = typeof(LoadingZone), Member = "Activate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	private void Update()
	{
	}

	[Calls(Type = typeof(LoadingZone), Member = "PlayFadeOutSound")]
	[CalledBy(Type = typeof(LoadingZone), Member = "Update")]
	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_jump_to_loadingzone")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	public void Activate()
	{
	}

	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	public string GetGUID()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public bool IsBeingInteractedWith()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 14)]
	public void StartInteract()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CalledBy(Type = typeof(LoadingZone), Member = "Update")]
	[CalledBy(Type = typeof(LoadingZone), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	public void Cancel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ProgressBarStarted()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(GameManager), Member = "LoadScene")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "StripOptFromSceneName")]
	private void LoadLevelWhenFadeOutComplete()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(LoadingZone), Member = "Activate")]
	private void PlayFadeOutSound()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void HolsterItemInHands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoadingZone), Member = "ComputeTriggerForwardDirection")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoadingZone), Member = "UpdateInLoadingZoneState")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(LoadingZone), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private void ComputeTriggerForwardDirection()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(LoadingZone), Member = "OnTriggerStay")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateInLoadingZoneState()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LoadingZone()
	{
	}
}
