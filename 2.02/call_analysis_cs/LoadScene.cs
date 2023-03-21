using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
	public string m_SceneToLoad;

	public string m_ExitPointName;

	public bool m_Active;

	public bool m_SceneCanBeInstanced;

	public string m_SoundDuringFadeOut;

	public string m_SoundDuringFadeIn;

	public LocalizedString m_LocalizedTransitionType;

	public bool m_TransitionOnContact;

	public LoadingZone m_PartnerLoadingZone;

	public LoadSceneParent m_LoadSceneParent;

	public AnimatedInteraction m_AnimatedInteraction;

	public Animator m_AnimatedObjectAnimator;

	public string m_AnimatedObjectTrackName;

	public string m_SceneLocationLocIDToShow;

	public bool m_FadeOutStarted;

	public bool m_Explored;

	public static List<LoadScene> m_LoadScenesList;

	private Lock m_Lock;

	private string m_GUID;

	private bool m_StartHasBeenCalled;

	private bool m_IsBeingInteractedWith;

	private float m_InteractTimer;

	private PlayerControlMode m_previousControlMode;

	private bool m_ActivateWhenPlayerTouchGround;

	private static LoadSceneSaveDataProxy m_LoadSceneSaveDataProxy;

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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void AssignBindingOverrides()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(LoadScene), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger")]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[Calls(Type = typeof(LoadSceneParent), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "GetGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(LoadScene), Member = "Cancel")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(LoadScene), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Lock), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadScene), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Lock), Member = "Deserialize")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(SaveGameSlots), Member = "AddGUIDToPrevSceneSave")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(LoadScene), Member = "MarkExplored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	public static void MaybeAddGUIDToPrevSceneSave()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoadScene), Member = "Serialize")]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(LoadScene), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(LoadScene), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(LoadScene), Member = "Deserialize")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadScene), Member = "FindLoadSceneByGuid")]
	[Calls(Type = typeof(LoadScene), Member = "Deserialize")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoadScene), Member = "FindLoadSceneByPosition")]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(LoadScene), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CalledBy(Type = typeof(LoadingZone), Member = "Activate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_jump_to_interior")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(LoadScene), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(LoadScene), Member = "Cancel")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsOutDoorsScene")]
	[Calls(Type = typeof(LoadScene), Member = "GetSceneToLoad")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(LoadScene), Member = "LoadLevelWhenFadeOutComplete")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	public void Activate()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string GetGUID()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadScene), Member = "MarkBrothersExplored")]
	[Calls(Type = typeof(LoadSceneParent), Member = "MarkChildrenExplored")]
	[CalledBy(Type = typeof(LoadScene), Member = "MaybeAddGUIDToPrevSceneSave")]
	[CalledBy(Type = typeof(LoadScene), Member = "LoadLevelWhenFadeOutComplete")]
	[CallsUnknownMethods(Count = 1)]
	public void MarkExplored()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetHoverText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessLoadSceneInteraction")]
	[Calls(Type = typeof(Lock), Member = "ForceLockBegin")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ForceLock()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[CalledBy(Type = typeof(LoadScene), Member = "LoadLevelWhenFadeOutComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	public string GetSceneToLoad()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadScene), Member = "StartInteractInternal")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CalledBy(Type = typeof(LoadScene), Member = "OnLockBroken")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessLoadSceneInteraction")]
	[CallsUnknownMethods(Count = 8)]
	public void StartInteract()
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(LoadScene), Member = "StartInteract")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void StartInteractInternal()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelLoadScene")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CalledBy(Type = typeof(LoadScene), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	public void Cancel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ProgressBarStarted()
	{
	}

	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[Calls(Type = typeof(GameManager), Member = "LoadScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(LoadScene), Member = "GetSceneToLoad")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(AchievementManager), Member = "ExploredNewInterior")]
	[Calls(Type = typeof(LoadScene), Member = "MarkExplored")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "StripOptFromSceneName")]
	private void LoadLevelWhenFadeOutComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsUnknownMethods(Count = 2)]
	private void HolsterItemInHands()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(LoadScene), Member = "MarkExplored")]
	[CallsUnknownMethods(Count = 7)]
	private void MarkBrothersExplored()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoadScene), Member = "StartInteract")]
	private void OnLockBroken()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	private static LoadScene FindLoadSceneByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 7)]
	private static LoadScene FindLoadSceneByPosition(LoadSceneSaveDataProxy proxy)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LoadScene()
	{
	}
}
