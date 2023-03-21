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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[Calls(Type = typeof(Phone), Member = "UpdateAudio")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
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
	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Phone), Member = "GetRingCycleCount")]
	public string GetMissionObjectId()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateShortPause")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CalledBy(Type = typeof(Phone), Member = "StartRinging")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	private void StartSingleRing()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(Phone), Member = "StartWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateShortPause")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRingAudio")]
	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Phone), Member = "StartShortPause")]
	private void HideClosedCaptions()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "StartRinging")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	private void MaybeAssignDTController()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CallsUnknownMethods(Count = 26)]
	public string GetDebugText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[CalledBy(Type = typeof(Phone), Member = "Start")]
	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(Phone), Member = "StopPhoneRingAudio")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void StartRinging()
	{
	}

	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[CalledBy(Type = typeof(Phone), Member = "PerformInteraction")]
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

	[Calls(Type = typeof(Phone), Member = "OnPhonePickup")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Phone), Member = "StopRinging")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	public void PerformInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CalledBy(Type = typeof(Phone), Member = "PerformInteraction")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PerformInteraction")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[CallsUnknownMethods(Count = 2)]
	private void OnPhonePickup()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PerformInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnPhonePickupComplete()
	{
	}

	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PhoneManager), Member = "SelectNextDialogueTree")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnPhoneHangup()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "SelectNextDialogueTree")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsUnknownMethods(Count = 2)]
	private void OnPhoneHangupComplete()
	{
	}

	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StartShortPause()
	{
	}

	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void UpdateRinging()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int RollRingCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateShortPause()
	{
	}

	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 1)]
	private void StartWaitingNextCall()
	{
	}

	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	private void UpdateWaitingNextCall()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
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

	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	public static Phone GetPhone(string missionId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_phone_startringing")]
	[CalledBy(Type = typeof(Action_PhoneStartRinging), Member = "OnExecute")]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void StartPhoneRinging(string missionId)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "StopRinging")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_phone_stopringing")]
	[CalledBy(Type = typeof(Action_PhoneStopRinging), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	public static void StopPhoneRinging(string missionId)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Phone), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "AssignBindingInfo")]
	[Calls(Type = typeof(Phone), Member = "AssignBindingInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetNPCAnimator")]
	private void AssignBindingOverrides()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetTrackBindingInfo")]
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
