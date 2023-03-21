using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.Logging;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class LoadScene : LockedInteraction
{
	private static readonly LogFilter s_LogFilter;

	private const float WAIT_ALLOW_SAVE_TIME_LIMIT = 5f;

	public string m_SceneToLoad;

	public string m_ExitPointName;

	public bool m_Active;

	public bool m_SceneCanBeInstanced;

	public string m_SoundDuringFadeOut;

	public string m_SoundDuringFadeIn;

	public LocalizedString m_LocalizedTransitionType;

	public bool m_TransitionOnContact;

	public LoadSceneParent m_LoadSceneParent;

	public AnimatedInteraction m_AnimatedInteraction;

	public Animator m_AnimatedObjectAnimator;

	public string m_AnimatedObjectTrackName;

	public string m_SceneLocationLocIDToShow;

	public bool m_Explored;

	public static List<LoadScene> m_LoadScenesList;

	private string m_GUID;

	private bool m_StartHasBeenCalled;

	private bool m_FadeOutStarted;

	private bool m_HasDoneAnimatedInteraction;

	private bool m_ActivateWhenPlayerTouchGround;

	private bool m_WaitingToAllowSave;

	private float m_WaitingToAllowSaveTimer;

	private static LoadSceneSaveDataProxy m_LoadSceneSaveDataProxy;

	private LoadingZone _003CPartnerLoadingZone_003Ek__BackingField;

	public LoadingZone PartnerLoadingZone
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public override bool CanInteract
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseHoldInteraction), Member = "get_CanInteract")]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LockedInteraction), Member = "Awake")]
	protected override void Awake()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AssignBindingOverrides()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadScene), Member = "GetSceneToLoad")]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadSceneParent), Member = "Start")]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	protected override void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(LoadScene), Member = "PerformSceneLoad")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFailedSaveNotification")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameManager), Member = "OnGameQuit")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameManager), Member = "OnGameQuit")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	private void ExitToMainMenu()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(LoadScene), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Lock), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Lock), Member = "Deserialize")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(LoadScene), Member = "MarkExplored")]
	[Calls(Type = typeof(SaveGameSlots), Member = "AddGUIDToPrevSceneSave")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public static void MaybeAddGUIDToPrevSceneSave()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoadScene), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 7)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(LoadScene), Member = "Deserialize")]
	[Calls(Type = typeof(LoadScene), Member = "Deserialize")]
	[Calls(Type = typeof(LoadScene), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadScene), Member = "FindLoadSceneByGuid")]
	[Calls(Type = typeof(LoadScene), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoadScene), Member = "FindLoadSceneByPosition")]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_jump_to_loadingzone")]
	[CalledBy(Type = typeof(LoadScene), Member = "Update")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_jump_to_interior")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(LoadingZone), Member = "PerformInteraction")]
	[Calls(Type = typeof(LoadScene), Member = "PerformSceneLoad")]
	[CalledBy(Type = typeof(LoadScene), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(AchievementManager), Member = "ExploredNewInterior")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "IsOutDoorsScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(LoadScene), Member = "MarkExplored")]
	[Calls(Type = typeof(LoadScene), Member = "GetSceneToLoad")]
	public void Activate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetGUID()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[CalledBy(Type = typeof(LoadScene), Member = "MaybeAddGUIDToPrevSceneSave")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LoadScene), Member = "MarkBrothersExplored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadSceneParent), Member = "MarkChildrenExplored")]
	public void MarkExplored()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformSceneLoad")]
	[CalledBy(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[CalledBy(Type = typeof(LoadScene), Member = "Start")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	public string GetSceneToLoad()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public override void InitializeInteraction()
	{
	}

	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[Calls(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformHold()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void AnimatedInteractionDone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "EndHold")]
	protected override void EndHold()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void LoadLevelWhenFadeOutComplete()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[CalledBy(Type = typeof(LoadScene), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "LoadScene")]
	[Calls(Type = typeof(LoadScene), Member = "GetSceneToLoad")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void PerformSceneLoad()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsUnknownMethods(Count = 1)]
	private void HolsterItemInHands()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(LoadScene), Member = "MarkExplored")]
	[CallsUnknownMethods(Count = 4)]
	private void MarkBrothersExplored()
	{
	}

	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static LoadScene FindLoadSceneByGuid(string guid)
	{
		return null;
	}

	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private static LoadScene FindLoadSceneByPosition(LoadSceneSaveDataProxy proxy)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public LoadScene()
	{
	}
}
