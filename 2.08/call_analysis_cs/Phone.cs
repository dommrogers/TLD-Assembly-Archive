using System;
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Phone), Member = "UpdateAudio")]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "GetRingCycleCount")]
	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[CallerCount(Count = 8)]
	public string GetMissionObjectId()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateShortPause")]
	[CalledBy(Type = typeof(Phone), Member = "StartRinging")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	private void StartSingleRing()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRingAudio")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(Phone), Member = "StartWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateShortPause")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Phone), Member = "StartShortPause")]
	[CallsUnknownMethods(Count = 1)]
	private void HideClosedCaptions()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Phone), Member = "StartRinging")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	private void MaybeAssignDTController()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public string GetDebugText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Phone), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[CalledBy(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(Phone), Member = "StopPhoneRingAudio")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 3)]
	public void StartRinging()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[CalledBy(Type = typeof(Phone), Member = "PerformInteraction")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	public void StopRinging()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CalledBy(Type = typeof(Phone), Member = "StartRinging")]
	private void StopPhoneRingAudio()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsRinging()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Phone), Member = "StopRinging")]
	[Calls(Type = typeof(Phone), Member = "OnPhonePickup")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public bool IsInConversation()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	public int GetRingCycleCount()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Phone), Member = "PerformInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnPhonePickup()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 1)]
	private void OnPhonePickupComplete()
	{
	}

	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(PhoneManager), Member = "SelectNextDialogueTree")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnPhoneHangup()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PhoneManager), Member = "SelectNextDialogueTree")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
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
		return default(int);
	}

	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	private void UpdateShortPause()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsUnknownMethods(Count = 1)]
	private void StartWaitingNextCall()
	{
	}

	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	private void UpdateWaitingNextCall()
	{
	}

	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	private void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsUnknownMethods(Count = 2)]
	private static void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[CalledBy(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	public static Phone GetPhone(string missionId)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_phone_startringing")]
	[CalledBy(Type = typeof(Action_PhoneStartRinging), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	public static void StartPhoneRinging(string missionId)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_phone_stopringing")]
	[CalledBy(Type = typeof(Action_PhoneStopRinging), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Phone), Member = "StopRinging")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void StopPhoneRinging(string missionId)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetNPCAnimator")]
	[Calls(Type = typeof(Phone), Member = "AssignBindingInfo")]
	[Calls(Type = typeof(Phone), Member = "AssignBindingInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Phone), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	private void AssignBindingOverrides()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetTrackBindingInfo")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AssignBindingInfo(AnimatedInteraction animatedInteraction, Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	public Phone()
	{
	}
}
