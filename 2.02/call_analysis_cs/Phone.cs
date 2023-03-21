using System.Collections.Generic;
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
		[CallerCount(Count = 7)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetComponentOnSelfOrParent")]
	[Calls(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[Calls(Type = typeof(Phone), Member = "UpdateAudio")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	[CalledBy(Type = typeof(Phone), Member = "GetRingCycleCount")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 18)]
	private void StartSingleRing()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRingAudio")]
	[CalledBy(Type = typeof(Phone), Member = "StartShortPause")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateRinging")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateShortPause")]
	[CalledBy(Type = typeof(Phone), Member = "StartWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void HideClosedCaptions()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "StartRinging")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	private void MaybeAssignDTController()
	{
	}

	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 26)]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void StartRinging()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Phone), Member = "StopPhoneRingAudio")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "StopRinging")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void StopRinging()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "StartRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StopPhoneRingAudio()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsRinging()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Phone), Member = "StopRinging")]
	[Calls(Type = typeof(Phone), Member = "OnPhonePickup")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool ProcessInteraction()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsInConversation()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetRingCycleCount")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetRingCycleCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Phone), Member = "ProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "OnPhonePickupComplete")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void OnPhonePickup()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "OnPhonePickup")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ProcessInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void OnPhonePickupComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "OnPhoneHangupComplete")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void OnPhoneHangup()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangup")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "SelectNextDialogueTree")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnPhoneHangupComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StartShortPause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateRinging()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int RollRingCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateShortPause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void StartWaitingNextCall()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateWaitingNextCall()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[Calls(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(Phone), Member = "UpdateShortPause")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Phone), Member = "HideClosedCaptions")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static Phone GetPhone(string missionId)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_phone_startringing")]
	[CalledBy(Type = typeof(Action_PhoneStartRinging), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "StartRinging")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void StartPhoneRinging(string missionId)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_phone_stopringing")]
	[CalledBy(Type = typeof(Action_PhoneStopRinging), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhoneManager), Member = "StopRinging")]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "StopRinging")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void StopPhoneRinging(string missionId)
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetNPCAnimator")]
	[Calls(Type = typeof(Phone), Member = "AssignBindingInfo")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "AssignTimelineOverride")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void AssignBindingOverrides()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetTrackBindingInfo")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private void AssignBindingInfo(AnimatedInteraction animatedInteraction, Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Phone()
	{
	}
}
