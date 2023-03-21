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
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected override void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	private void AssignBindingOverrides()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(LoadScene), Member = "GetSceneToLoad")]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger")]
	[Calls(Type = typeof(LoadSceneParent), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	protected override void Start()
	{
	}

	[CallsUnknownMethods(Count = 8)]
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(LoadScene), Member = "SerializeAll")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Lock), Member = "Serialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SaveGameSlots), Member = "AddGUIDToPrevSceneSave")]
	[Calls(Type = typeof(LoadScene), Member = "MarkExplored")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void MaybeAddGUIDToPrevSceneSave()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(LoadScene), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(LoadScene), Member = "Deserialize")]
	[Calls(Type = typeof(LoadScene), Member = "Deserialize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(LoadScene), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadScene), Member = "FindLoadSceneByPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadScene), Member = "FindLoadSceneByGuid")]
	[Calls(Type = typeof(LoadScene), Member = "Deserialize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(LoadingZone), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_jump_to_loadingzone")]
	[CalledBy(Type = typeof(LoadScene), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_jump_to_interior")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(LoadScene), Member = "Update")]
	[Calls(Type = typeof(LoadScene), Member = "PerformSceneLoad")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformInteraction")]
	[Calls(Type = typeof(AchievementManager), Member = "ExploredNewInterior")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
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

	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadScene), Member = "MaybeAddGUIDToPrevSceneSave")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadScene), Member = "MarkBrothersExplored")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LoadSceneParent), Member = "MarkChildrenExplored")]
	public void MarkExplored()
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(LoadScene), Member = "Start")]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformSceneLoad")]
	[CalledBy(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[CallsUnknownMethods(Count = 1)]
	public string GetSceneToLoad()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	public override void InitializeInteraction()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public override bool PerformHold()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void AnimatedInteractionDone()
	{
	}

	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(GameManager), Member = "LoadScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(LoadScene), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LoadScene), Member = "GetSceneToLoad")]
	private void PerformSceneLoad()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsUnknownMethods(Count = 1)]
	private void HolsterItemInHands()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LoadScene), Member = "MarkExplored")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void MarkBrothersExplored()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	private static LoadScene FindLoadSceneByGuid(string guid)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private static LoadScene FindLoadSceneByPosition(LoadSceneSaveDataProxy proxy)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public LoadScene()
	{
	}
}
