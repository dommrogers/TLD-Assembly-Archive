using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class Phone : MonoBehaviour
{
	public class PhoneSaveData
	{
		public string m_MissionId;

		public bool m_HasStartedRinging;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

	public LocalizedString m_LocalizedDisplayName;

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

	public string m_DisplayName
	{
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	public void Start()
	{
	}

	[Calls(Type = typeof(Phone), Member = "UpdateAudio")]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Phone), Member = "GetRingCycleCount")]
	public string GetMissionObjectId()
	{
		return null;
	}

	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(Phone), Member = "StartRinging")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateShortPause")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	private void StartSingleRing()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRingAudio")]
	[CalledBy(Type = typeof(Phone), Member = "StartShortPause")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateRinging")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateShortPause")]
	[CalledBy(Type = typeof(Phone), Member = "StartWaitingNextCall")]
	[CallsUnknownMethods(Count = 1)]
	private void HideClosedCaptions()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallerCount(Count = 3)]
	private void MaybeAssignDTController()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public string GetDebugText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[CalledBy(Type = typeof(Phone), Member = "Start")]
	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Phone), Member = "StopPhoneRingAudio")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	public void StartRinging()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "StopRinging")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Phone), Member = "StopPhoneRingAudio")]
	public void StopRinging()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CalledBy(Type = typeof(Phone), Member = "StartRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	[CallsUnknownMethods(Count = 2)]
	private void StopPhoneRingAudio()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsRinging()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Phone), Member = "StopRinging")]
	[Calls(Type = typeof(Phone), Member = "OnPhonePickup")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[CallsUnknownMethods(Count = 1)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsInConversation()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PhoneManager), Member = "GetRingCycleCount")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetRingCycleCount()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "OnPhonePickupComplete")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CalledBy(Type = typeof(Phone), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 8)]
	private void OnPhonePickup()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Phone), Member = "OnPhonePickup")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ProcessInteraction")]
	private void OnPhonePickupComplete()
	{
	}

	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "OnPhoneHangupComplete")]
	[CallsUnknownMethods(Count = 8)]
	private void OnPhoneHangup()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangup")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PhoneManager), Member = "SelectNextDialogueTree")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void OnPhoneHangupComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsUnknownMethods(Count = 2)]
	private void StartShortPause()
	{
	}

	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateRinging()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int RollRingCount()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateShortPause()
	{
	}

	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 3)]
	private void StartWaitingNextCall()
	{
	}

	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void UpdateWaitingNextCall()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(Phone), Member = "UpdateShortPause")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateAudio()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[CallsUnknownMethods(Count = 5)]
	public static Phone GetPhone(string missionId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_PhoneStartRinging), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_phone_startringing")]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static void StartPhoneRinging(string missionId)
	{
	}

	[CalledBy(Type = typeof(Action_PhoneStopRinging), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_phone_stopringing")]
	[Calls(Type = typeof(Phone), Member = "StopRinging")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PhoneManager), Member = "StopRinging")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	public static void StopPhoneRinging(string missionId)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Phone), Member = "Awake")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "AssignTimelineOverride")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "AssignBindingInfo")]
	[Calls(Type = typeof(Phone), Member = "AssignBindingInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetNPCAnimator")]
	private void AssignBindingOverrides()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetTrackBindingInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AssignBindingInfo(AnimatedInteraction animatedInteraction, Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Phone()
	{
	}
}
