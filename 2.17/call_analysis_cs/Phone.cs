using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.UI.Generics;
using UnityEngine;

public class Phone : MonoBehaviour
{
	public class PhoneSaveData
	{
		public string m_MissionId;

		public bool m_HasStartedRinging;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public PhoneSaveData()
		{
		}
	}

	private enum RingingState
	{
		NotRinging,
		SingleRing,
		ShortPause,
		WaitingNextCall,
		RingingLoop
	}

	public string m_PickUpReceiverAudio;

	public string m_RingingAudio;

	public string m_RingingClosedCaptionID;

	public float m_MinDistanceToPlayerForCaptions;

	public bool m_LoopAudio;

	public int m_RingCountMin;

	public int m_RingCountMax;

	public float m_ShortPauseDurationSeconds;

	public float m_NextCallDurationSeconds;

	public DTContainer m_DTContainer;

	public DialogueModeRigFP m_DialogueMode;

	public AnimatedInteraction m_PickupAnimatedInteraction;

	public AnimatedInteraction m_HangupAnimatedInteraction;

	public string m_TimelinePhoneTrackName;

	public NPCVoice m_NPCVoice;

	public string m_NPCVoiceTrackName;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Subtitles> m_Subtitles;

	private uint m_RingingAudioInstance;

	private int m_RolledRingCount;

	private MissionObjectIdentifier m_MissionObjectIdentifier;

	private bool m_HasStartedRinging;

	private RingingState m_RingingState;

	private static float s_CurrentPhoneRingDurationRealtimeSeconds;

	private float m_TimeElapsed;

	private int m_CurrentRingIndex;

	private int m_RingCycleCount;

	private bool m_IsShowingClosedCaptions;

	private HeldItemInPlacementZone m_HeldItemInPlacementZone;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetComponentOnSelfOrParent")]
	[Calls(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[Calls(Type = typeof(Phone), Member = "UpdateAudio")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	[CalledBy(Type = typeof(Phone), Member = "GetRingCycleCount")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public string GetMissionObjectId()
	{
		return null;
	}

	[CalledBy(Type = typeof(Phone), Member = "StartRinging")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateShortPause")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void StartSingleRing()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRingAudio")]
	[CalledBy(Type = typeof(Phone), Member = "StartShortPause")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateRinging")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateShortPause")]
	[CalledBy(Type = typeof(Phone), Member = "StartWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsUnknownMethods(Count = 1)]
	private void HideClosedCaptions()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "StartRinging")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 15)]
	private void MaybeAssignDTController()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 25)]
	public string GetDebugText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Phone), Member = "Start")]
	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[CalledBy(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Phone), Member = "StopPhoneRingAudio")]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void StartRinging()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	public void StopRinging()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "StartRinging")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	private void StopPhoneRingAudio()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsRinging()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Phone), Member = "StopRinging")]
	[Calls(Type = typeof(Phone), Member = "OnPhonePickup")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsInConversation()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	public int GetRingCycleCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Phone), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PerformInteraction")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnPhonePickup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PerformInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPhonePickupComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(PhoneManager), Member = "SelectNextDialogueTree")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnPhoneHangup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "SelectNextDialogueTree")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnPhoneHangupComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	private void StartShortPause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	private void UpdateRinging()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int RollRingCount()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateShortPause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void StartWaitingNextCall()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	private void UpdateWaitingNextCall()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsUnknownMethods(Count = 2)]
	private static void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Phone GetPhone(string missionId)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_phone_startringing")]
	[CalledBy(Type = typeof(Action_PhoneStartRinging), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[CallsUnknownMethods(Count = 1)]
	public static void StartPhoneRinging(string missionId)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_phone_stopringing")]
	[CalledBy(Type = typeof(Action_PhoneStopRinging), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "StopRinging")]
	[CallsUnknownMethods(Count = 1)]
	public static void StopPhoneRinging(string missionId)
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetNPCAnimator")]
	[Calls(Type = typeof(Phone), Member = "AssignBindingInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void AssignBindingOverrides()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetTrackBindingInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void AssignBindingInfo(AnimatedInteraction animatedInteraction, Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	public Phone()
	{
	}
}
