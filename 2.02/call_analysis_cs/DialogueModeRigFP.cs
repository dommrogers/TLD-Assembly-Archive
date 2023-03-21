using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class DialogueModeRigFP : MonoBehaviour
{
	public struct IdlePropInfo
	{
		public CinematicAssets.PermanentPropId m_PermanentPropId;

		public int m_CurrentIdleStateHash;
	}

	public struct AssignedChoiceCategoryInfo
	{
		public string m_LocId;

		public Dialogue_MultipleChoiceNode.ChoiceCategory m_AssignedCategory;
	}

	public class DialogueModeRigFPSaveData
	{
		public string m_NPC_MissionId;

		public int m_CurrentIdleStateHash;

		public string m_CurrentCameraFramingName;

		public List<IdlePropInfo> m_CurrentPermanentPropIdles;

		public AssignedChoiceCategoryInfo[] m_CurrentAssignedChoiceCategoryInfo;

		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SerializeAll")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		public DialogueModeRigFPSaveData()
		{
		}
	}

	public enum DialogueModeState
	{
		DialogueModeStateNone,
		DialogueModeStateTransitionIn,
		DialogueModeStateStart,
		DialogueModeStateIdle,
		DialogueModeStateLoadSequence,
		DialogueModeStatePlayLine,
		DialogueModeStatePlayCinematic,
		DialogueModeStatePlayLineComplete,
		DialogueModeStatePlayCinematicComplete,
		DialogueModeStateTransitionOut,
		DialogueModeStateEnd,
		DialogueModeStateTimeline
	}

	public enum DialogueControllerMode
	{
		OriginalController,
		LoadedController
	}

	[Serializable]
	public class DialogueChoiceCategoryConfiguration
	{
		public Dialogue_MultipleChoiceNode.ChoiceCategory m_Category;

		public Color m_NormalTextColor;

		public Color m_TextHoveredColor;

		public float m_Scale;

		public Texture2D m_ForegroundImage;

		public Texture2D m_BackgroundImage;

		[CallerCount(Count = 0)]
		public DialogueChoiceCategoryConfiguration()
		{
		}
	}

	public class DialogueChoiceInfo
	{
		public string m_Text;

		public string m_LocId;

		public Dialogue_MultipleChoiceNode.ChoiceCategory m_OriginalSlotCategory;

		public DialogueOptionTopic m_Topic;

		public int m_ChoiceIndex;

		public bool m_IsHidden;

		public float m_TextSize;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public DialogueChoiceInfo()
		{
		}
	}

	[Serializable]
	public class IdleMatchingInfo
	{
		public string m_MainIdle;

		public string m_DialogueIdle;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public IdleMatchingInfo()
		{
		}
	}

	[Serializable]
	public class CameraFramingInfo
	{
		public GameObject m_CharacterPlayerDummy;

		public GameObject m_CameraPlayerDummy;

		public string m_Name;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public CameraFramingInfo()
		{
		}
	}

	public class DialogueStatement
	{
		public string m_StateName;

		public string m_StateKey;

		public float m_Duration;

		public float m_AfterDuration;

		public float m_ElapsedTime;

		public string m_DialogueActorName;

		public string m_SubtitlesText;

		public bool m_IsUnknownSpeaker;

		public string m_LocId;

		public string m_AudioEventStart;

		public string m_AudioEventStop;

		public bool m_IsCinematic;

		public string m_FaceStateKey;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public DialogueStatement()
		{
		}
	}

	public class CinematicMoment
	{
		public string m_StateName;

		public string m_StateKey;

		public float m_Duration;

		public float m_ElapsedTime;

		public string m_AudioEventStart;

		public string m_AudioEventStop;

		public Utils.Subtitle[] m_Subtitles;

		public uint m_NumSubtitles;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public CinematicMoment()
		{
		}
	}

	private sealed class _003CLoadAnimations_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DialogueModeRigFP _003C_003E4__this;

		public string stateKey;

		private string _003CassetBundleFilename_003E5__2;

		private string _003CprefabPath_003E5__3;

		private AssetBundleRefRequest _003Crequest_003E5__4;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CLoadAnimations_003Ed__31(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "GetBundleFilename")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "GePrefabPath")]
		[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "RetrieveLoadedAnimators")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(CinematicAssets), Member = "LoadProps")]
		[Calls(Type = typeof(CinematicAssets), Member = "ReParentProp")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "AbortLoad")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 40)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private const string SUBTITLE_PREFIX = "SUBTITLE_";

	private const string ANIMATION_STATE_PREFIX = "Dia_";

	private const string TIMELINE_PREFIX = "Dia_";

	private const string AUDIO_START_PREFIX = "Play_SndVO";

	private TimelineRef m_TimelineRef;

	private TimelineRef m_RequestedTimelineRef;

	private bool m_LoadTimelineCompleted;

	private bool m_LoadTimelineFailed;

	private bool m_LerpCameraOffset;

	private bool m_ResetAimingModeRequested;

	private bool m_DisableBreathFXForTimeline;

	private HudDisplayMode m_RestoreHudDisplayMode;

	private bool m_DelaySubtitles;

	private const HudDisplayMode CINEMATIC_HUD_MODE = HudDisplayMode.Subtitles;

	private bool m_IsTimelinePlaying;

	private bool m_StopRequested;

	private List<TLD_TimelineDirector.BindingInfo> m_TimelineBindingOverrides;

	private bool m_HandsReady;

	public DialogueCategoriesConfiguration m_DialogueCategoriesConfigurations;

	public GameObject m_DialogueOptionsAnimationTreePrefab;

	public GameObject m_DialogueOptionsAnimationTreeParent;

	public GameObject m_LabelDialogPrefab;

	public List<CameraFramingInfo> m_CameraFramingInfoList;

	public GameObject m_CharacterPlayerDummy;

	public GameObject m_CameraPlayerDummy;

	public GameObject m_AudioEmitterNode;

	public DialogueTreeController m_DefaultDialogueTree;

	public Animator m_CurrentNPCAnimator;

	public string m_KnowledgeDescLocID;

	public string m_DisplayName;

	public string m_OptionalUnknownDisplayName;

	public List<CinematicAssets.PermanentPropInfo> m_PermanentProps;

	public CharacterController m_CurrentNPCCharacterController;

	public bool m_IndividualLineAnimationRequired;

	public float m_Fov;

	public float m_TransitionDurationSeconds;

	public Vector2 m_PitchLimitDegrees;

	public Vector2 m_YawLimitDegrees;

	public float m_NPCInteractionConeAngleDegrees;

	public float m_StrafingDistanceLimitMeters;

	public bool m_SkipPlayerInTransition;

	public bool m_SkipPlayerOutTransition;

	public bool m_UseTimelineForSpeech;

	public string m_DefaultFramingNonStory;

	public string m_DefaultAnimationStateNonStory;

	public bool m_GroundPlayerOnEnd;

	private GameObject m_DialogueSequenceListParent;

	private List<DialogueSequenceFP> m_DialogueSequenceList;

	private List<DialogueChoiceInfo> m_DialogueChoiceInfo;

	private float m_TransitionElapsedTimeSeconds;

	private Vector3 m_OriginalPlayerPos;

	private Vector3 m_OriginalCameraLocalPos;

	private Quaternion m_OriginalCameraPlayerRotation;

	private Vector2 m_TransitionStartCameraPlayerAngle;

	private Vector3 m_TransitionStartPlayerPosition;

	private Vector3 m_TransitionStartLocalCameraPosition;

	private float m_OriginalCameraFov;

	private Vector2 m_StartPitchLimit;

	private Vector2 m_StartYawLimit;

	private Vector3 m_EndDialoguePlayerPos;

	private Vector3 m_EndDialogueCameraLocalPos;

	private Quaternion m_EndDialoguePlayerRotation;

	private DialogueModeState m_DialogueModeState;

	private Animator m_LoadedNPCAnimator;

	private Animator m_LoadedFPHAnimator;

	private PlayEventMonitor m_PlayEventMonitor;

	private Animator m_CurrentFPHAnimator;

	private DialogueStatement m_DialogueStatement;

	private string m_CameraFramingIn;

	private float m_CameraFramingInTransitionDurationSeconds;

	private string m_CameraFramingOut;

	private float m_CameraFramingOutTransitionDurationSeconds;

	private PlayerControlMode m_DesiredTimelineControlMode;

	private string m_DialogueExitPoint;

	private DialogueTreeController m_DialogueTreeController;

	private RuntimeAnimatorController m_OriginalNPCRuntimeAnimatorController;

	private RuntimeAnimatorController m_OriginalFPHRuntimeAnimatorController;

	private Action m_OnStatementFinish;

	private Action m_OnCinematicFinish;

	private const string DEFAULT_PLAYER_ACTOR_NAME = "Mackenzie";

	private bool m_LoadingRequested;

	private string m_LoadedAssetBundleFilename;

	private string m_LoadedPrefabPath;

	private string m_AnimState_Idle;

	private static DialogueModeRigFP m_Current;

	private DialogueModeState m_PendingDialogueModeState;

	private DialogueOptionsAnimationTree m_DialogueOptionsAnimationTree;

	private DialogueControllerMode m_DialogueControllerMode;

	private bool m_AnimationsLoadingComplete;

	private AssetBundleRef m_AssetBundle;

	private GameObject m_AnimationsAsset;

	private int m_NPCBaseLayerIndex;

	private int m_NPCHeadLayerIndex;

	private int m_NPCFaceLayerIndex;

	private CinematicAssets m_DialogueAssets;

	private float m_CurrentTime;

	private float m_CurrentAnimationTime;

	private List<DialogueOptionTopic> m_CurrentFilter;

	private bool m_FilterHasChanged;

	private int m_DialogueStartedCount;

	private PlayerAnimation.CameraLayer m_CameraLayerBeforeDialogue;

	private int m_OnGoingAnimationState;

	private string m_OnGoingAnimationStateName;

	private string m_OnGoingAnimationStateKey;

	private bool m_AnimationRequested;

	private bool m_NextDialogueRequested;

	private float m_OnGoingAnimationDuration;

	private uint m_AudioID;

	private string m_AudioEventStop;

	private string m_AudioEventStart;

	private Action m_OnExitRequestedAction;

	private int m_AnimParameter_Is_InDialogue;

	private string m_NPC_MissionId;

	private bool m_RecenterCameraRequested;

	private string m_CurrentCameraFramingName;

	private NPC_Animation m_NPC_AnimationComponent;

	private CinematicMoment m_CinematicMoment;

	private bool m_CurrentFPHAnimatorPlaying;

	private bool m_ShowDialogueUI;

	private int m_PendingIdleHash;

	private int m_PendingIdleLayer;

	private bool m_IsIdlePending;

	private string m_OnGoingAnimationTrigger;

	private bool m_IsCinematicOnGoing;

	private float m_AudioDurationRealtimeSeconds;

	private float m_AfterDurationTimer;

	private bool m_PlaySequenceCompleteReady;

	private bool m_LerpCameraValuesInitialized;

	private string m_OnGoingFaceAnimationTrigger;

	private string m_OnGoingFaceAnimationStateKey;

	private bool m_FadedOutOnExit;

	public static bool s_DebugDialogue;

	private static List<DialogueModeRigFP> s_DialogueModeRigFPs;

	private bool m_EnableExitUI;

	private bool m_ExitDialoguePending;

	private Action m_OnDialogueEndsAction;

	private AssignedChoiceCategoryInfo[] m_CurrentAssignedChoiceCategoryInfo;

	private bool m_CanApplyCameraMotionToJoint;

	private float m_CurrentTransitionDurationSeconds;

	private const int MAX_CHOICES_COUNT = 32;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	private void UpdateChoicesAfterFilterChange()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdleUI")]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateFromUnderCrosshair()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueOptionsAnimationTree), Member = "UpdateClosestToCenter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateClosestToCenter()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdleUI")]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(InputManager), Member = "GetMouseButtonDown")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "ProcessInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessSelectionConfirm()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLineComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateStart")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "StopPreviousAudio")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private void OnEnter_DialogueModeStateIdle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetCameraFov")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update_DialogueModeStateIdle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueOptionsAnimationTree), Member = "UpdateClosestToCenter")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateFromUnderCrosshair")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ProcessSelectionConfirm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Update_DialogueModeStateIdleUI()
	{
	}

	[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public void OnSpeech(string meta, Action onStatementFinish, string subtitlesText, IDialogueActor dialogueActor, VoiceOverItem voiceOverItem)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultAudioStartForDialogueLineFromLocId")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultStateNameForDialogueLineFromLocId")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetFirstStateKeyForState")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetFaceStateKeyForState")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultTimelineNameForDialogueLineFromLocId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	private void MaybeAutoAssignDialogueAnimationAndAudio(DialogueStatement dialogueStatement, string locId)
	{
	}

	[CalledBy(Type = typeof(Dialogue_Cinematic), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(CinematicManager), Member = "MaybeSetFadedOutOnLoad")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceSavedPosition")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	public void OnCinematicPlay(DialogueAnimationState dialogueAnimationState, string audioStart, string audioEnd, Action onCinematicFinish, TextAsset subtitleAsset)
	{
	}

	[CalledBy(Type = typeof(Dialogue_TimelineCinematic), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnTimelinePlay(DialogueTimelineScript dialogueTimelineScript, Action onCinematicFinish)
	{
	}

	[CallerCount(Count = 0)]
	public bool CanApplyCameraMotionToJoint()
	{
		return false;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnTimelinePlay")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_setframing")]
	[CalledBy(Type = typeof(Action_SetDialogueFraming), Member = "OnExecute")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void ReplaceCameraFraming(string cameraFraming)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void ReplaceSavedPosition(string cameraFraming)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float ComputeSubtitleDurationInSeconds(string text)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsAnimationAlreadyLoaded")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsAnimationLoadingRequired")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string GetBundleFilename(string stateKey)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsAnimationAlreadyLoaded")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsAnimationLoadingRequired")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string GePrefabPath(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetBundleFilename")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GePrefabPath")]
	private bool IsAnimationAlreadyLoaded(string stateKey)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetBundleFilename")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GePrefabPath")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsAnimationLoadingRequired()
	{
		return false;
	}

	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void AbortLoad()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator LoadAnimations(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool AreAssetsReady()
	{
		return false;
	}

	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private void RetrieveLoadedAnimators(string errorPath)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnTimelinePlay")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetBundleFilename")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GePrefabPath")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LoadAnimations")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(TimelineRef), Member = "LoadForPlayerDirector")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	private void OnEnter_DialogueModeStateLoadSequence()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTimeline")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "TimelineIndividualLineCompleted")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update_DialogueModeStateLoadSequence()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnLoadTimelineCompleted()
	{
	}

	[CallerCount(Count = 0)]
	private void OnLoadTimelineFailed()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool IsTimelineRequested()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool ShouldSupressBreathFXForTimeline()
	{
		return false;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static string GetDefaultStateNameForDialogueLineFromLocId(string localizationId)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static string GetDefaultTimelineNameForDialogueLineFromLocId(string localizationId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static string GetDefaultLocIdForDialogueLineFromTimeline(string timelineName)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static string GetDefaultAudioStartForDialogueLineFromLocId(string localizationId)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	[CallerCount(Count = 1)]
	private void PlayCinematic()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PlayCinematic")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PlayAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void OnEnter_DialogueModeStatePlayCinematic()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetHudModeForCinematic()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetHudModeForCinematic")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Reset")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetCameraFov")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsFPHPlayingIdle")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(CinematicManager), Member = "UpdateAnimDrivenEffects")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[Calls(Type = typeof(Utils), Member = "GetSubtitleFrame")]
	[Calls(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetOnGoingStateDuration")]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(Utils), Member = "GetNextSkipTime")]
	[Calls(Type = typeof(CinematicManager), Member = "GetAdjustedSkipTimeAndTryToSeekAudio")]
	[Calls(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[Calls(Type = typeof(CinematicManager), Member = "TryGetTimeFromAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnCinematicDone")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 30)]
	private void Update_DialogueModeStatePlayCinematic()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematicComplete")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnCinematicDone()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicDone")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private void OnEnter_DialogueModeStatePlayCinematicComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsNPCStatePlaying")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update_DialogueModeStatePlayCinematicComplete()
	{
	}

	[CallerCount(Count = 0)]
	public void DialogueNext()
	{
	}

	[CallerCount(Count = 0)]
	public void SetAudioDurationRealtimeSeconds(float duration)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "PlayDialogueAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string GetTriggeredByName(string stateKey)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string GetTriggerIdle(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string GetStateIdle(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int GetLayerIndex(string stateKey)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsAnimationRequested()
	{
		return false;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayVoiceWithPositionTracking")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void PlayAudio(string audioEventStart, string audioEventStop)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCharacterDesiredPosition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredLocalPosition")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 18)]
	private void LerpCameraFramingToDesired(float normalizedProgress)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLineComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LerpCameraFramingToDesired")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RecenterCameraToDesired()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsTransitionDone")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLineComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCharacterDesiredPosition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredLocalPosition")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 15)]
	private bool IsCameraCentered()
	{
		return false;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetTriggeredByName")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	private void PlayDialogueAnimation()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_CameraControl")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsFPHPlayingIdle()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	private bool IsTransitionDone()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsFPHPlayingIdle")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Update_CameraControl()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private float GetOnGoingStateDuration()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private void LateSynchronizeAnimators(float currentTime, int stateHash)
	{
	}

	[CallerCount(Count = 0)]
	private void OnCurrentFPHAnimatorStoppedPlaying()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsCinematicOrNotAnimatedStatement()
	{
		return false;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PlayDialogueAnimation")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PlayAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private void OnEnter_DialogueModeStatePlayLine()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnNextDialogueRequested")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ProcessAfterDuration")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void DoNextStatement()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DoNextStatement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnNextDialogueRequested()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DoNextStatement")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessAfterDuration()
	{
	}

	[CallerCount(Count = 0)]
	private float GetCinematicDuration()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeUpdateIndividualLineDuration()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetCameraFov")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsFPHPlayingIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetOnGoingStateDuration")]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(CinematicManager), Member = "TryGetTimeFromAudio")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "StopPreviousAudio")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DoNextStatement")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 20)]
	private void Update_DialogueModeStatePlayLine()
	{
	}

	[CallerCount(Count = 0)]
	private void OnEnter_DialogueModeStatePlayLineComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsNPCStatePlaying")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	private void Update_DialogueModeStatePlayLineComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void AssignTimelineOverride(string trackName, GameObject target)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(TimelineRef), Member = "IsLoaded")]
	[Calls(Type = typeof(TimelineRef), Member = "PlayTimeline")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void OnEnter_DialogueModeStateTimeline()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallerCount(Count = 1)]
	private void Update_DialogueModeStateTimeline()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void TimelineIndividualLineCompleted()
	{
	}

	[CallerCount(Count = 0)]
	private void OnTimelineStopped()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerStartedDialogue")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCharacterDesiredPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "MaybeStowItemInHand")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 74)]
	private void OnEnter_DialogueModeStateTransitionIn()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeStowItemInHand()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsNPCReady()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool AreHandsReady()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnItemInHandStowed()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCharacterDesiredPosition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredLocalPosition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	private void Update_DialogueModeStateTransitionIn()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 20)]
	private static void LerpPlayer(float progress, Vector3 originalPlayerPosition, Quaternion originalCameraRotation, Vector3 originalLocalCameraPosition, float originalFov, Vector3 desiredPlayerPosition, Quaternion desiredCameraRotation, Vector3 desireedLocalCameraPosition, float desiredFov)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerEndedDialogue")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 23)]
	private void OnEnter_DialogueModeStateTransitionOut()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetHipAndShoulderOffsetLayer")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void Update_DialogueModeStateTransitionOut()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetNPCAnimator")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(DialogueOptionsAnimationTree), Member = "InstantiateLabels")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 27)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void SetAnimationParameter_IsInDialogue(bool isInDialogue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTimeline")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsNPCStatePlaying")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetCameraFov")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LateSynchronizeAnimators")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 21)]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDialogueTreeFinished")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[Calls(Type = typeof(DialogueTree), Member = "remove_OnDialogueFinished")]
	[Calls(Type = typeof(DialogueTree), Member = "remove_OnDialogueStarted")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public void OnPlayerEndedDialogue()
	{
	}

	[CallerCount(Count = 0)]
	public void SetExitRequestedAction(Action onExitRequested)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "StartDialogueTree")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueTree), Member = "add_OnDialogueFinished")]
	[Calls(Type = typeof(DialogueTree), Member = "add_OnDialogueStarted")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public void OnPlayerStartedDialogue()
	{
	}

	[CallerCount(Count = 0)]
	public void SetDialogueController(DialogueTreeController dialogTreeController)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetGroundPlayerOnEnd(bool groundPlayer)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetNameIDFromDescID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ResetDialogueController()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "OnPhonePickupComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnPlayerStartedDialogue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool ProcessInteraction()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RequestExitDialogue()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsInTransition()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsInIdle()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool CanShowDialogueUI()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectWithConstraints")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public bool RespectContrainsts()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetFilter(List<DialogueOptionTopic> filter, bool clearFilter)
	{
	}

	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnButtonSelected")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnChoiceSelected(int choiceIndex)
	{
	}

	[CalledBy(Type = typeof(CellToilet), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetOnDialogueEndsAction(Action onDialogueEnds)
	{
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCurrentTimelineTime")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetSubtitleFrame")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 54)]
	public string GetDebugDialogueText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void ShowDialogueUI(bool showDialogueUI)
	{
	}

	[CallerCount(Count = 0)]
	public void EnableExitUI(bool enableExitUI)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsExitUIEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LogChoices")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 5)]
	public bool MaybeGetAssignedChoiceCategory(int choiceIndex, string locId, out Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		category = default(Dialogue_MultipleChoiceNode.ChoiceCategory);
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_assign")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetChoiceInfo")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public bool AssignCategory(int choiceIndex, Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_logchoices")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "MaybeGetAssignedChoiceCategory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAssignedSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 27)]
	public void LogChoices()
	{
	}

	[CallerCount(Count = 0)]
	public void ReplacePlayerExit(Vector3 playerPosition, Quaternion cameraRotation, Vector3 originalCameraLocalPos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetChoiceInfo")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void OnCategoryAssigned(int choiceIndex, Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LogChoices")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private DialogueSequenceFP GetAssignedSlot(int choiceIndex)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignCategory")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCategoryAssigned")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private DialogueChoiceInfo GetChoiceInfo(int choiceIndex)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLineComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsNPCStatePlaying(int hashState, int layer)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ExtractNPCMissionId()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnPlayerEndedDialogue")]
	private void OnDialogueTreeFinished(DialogueTree obj)
	{
	}

	[CallerCount(Count = 0)]
	private void OnDialogueTreeStarted(DialogueTree obj)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoicesAfterFilterChange")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTimeline")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDestroy")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueTreeChoices")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void EnableDialogueSequenceFP(bool enabled)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetPitchLimitFromBase")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void LimitCameraRotation()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDestroy")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicAssets), Member = "UnloadProps")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UnloadAnimations()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAvailableSlotForCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetChoiceEnabled")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetupNormalUILabelText")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "UpdateText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	private DialogueSequenceFP AssignChoiceToCategorySlot(Dialogue_MultipleChoiceNode.ChoiceCategory category, string dialogueChoiceText, int choiceIndex, float textSize)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignHiddenChoiceToCategorySlot")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private DialogueSequenceFP GetAvailableSlotForCategory(Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private Dialogue_MultipleChoiceNode.ChoiceCategory GetFallbackSlotCategory(Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		return default(Dialogue_MultipleChoiceNode.ChoiceCategory);
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private DialogueChoiceCategoryConfiguration GetCategoryConfiguration(Dialogue_MultipleChoiceNode.ChoiceCategory choiceCategory)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAvailableSlotForCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void AssignHiddenChoiceToCategorySlot(Dialogue_MultipleChoiceNode.ChoiceCategory category, string dialogueChoiceText, int choiceIndex)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoicesAfterFilterChange")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueTreeChoices")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FontManager), Member = "ResetCurrentFonts")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetChoiceEnabled")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "AssignHiddenChoiceToCategorySlot")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "MaybeGetAssignedChoiceCategory")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCategoryConfiguration")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private void UpdateChoiceAssignment()
	{
	}

	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocString")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	internal void SetDialogueTreeChoices(List<Dialogue_MultipleChoiceNode.Choice> dialogueChoices, int loopBackIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsChoiceAcceptedByFilter(DialogueOptionTopic topic)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private uint PostAudioEvent(string soundID, GameObject go)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void StopPreviousAudio()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTimeline")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematicComplete")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	public void SetDialogueModeState(DialogueModeState dialogueModeState)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public Animator GetNPCAnimator()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ReplaceFPController(DialogueControllerMode dialogueControllerMode)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDestroy")]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicAssets), Member = "RestoreOriginalControllerAndResumeState")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(CinematicAssets), Member = "UseLoadedControllerAndResumeState")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void ReplaceAnimControllerAndResumeState(DialogueControllerMode dialogueControllerMode)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CinematicManager), Member = "CheckAnimationRestored")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void CheckLastAnimationRestore()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetCameraFov()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsStatePlaying(int stateHash)
	{
		return false;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnNextDialogueRequested")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetTriggerIdle")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 21)]
	private void ReturnToIdleAnimation()
	{
	}

	[CallerCount(Count = 0)]
	private void OnEnter_DialogueModeStateEnd()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "StopPreviousAudio")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	private void ExitDialogueMode()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CinematicManager), Member = "ClearSavedAnimationState")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private void OnEnter_DialogueModeStateStart()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateNone")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateNone")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DisableDialogue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update_DialogueModeStateEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	private void OnEnter_DialogueModeStateNone()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	private void Update_DialogueModeStateNone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	private void Update_DialogueModeStateStart()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpCameraFramingToDesired")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private Vector3 GetCharacterDesiredPosition()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpCameraFramingToDesired")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private Quaternion GetCameraDesiredRotation()
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Vector3 GetReferenceCameraForward()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Vector3 GetReferenceCameraRight()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpCameraFramingToDesired")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private Vector3 GetCameraDesiredLocalPosition()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int GetCurrentNPCIdleStateHash()
	{
		return 0;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	private List<IdlePropInfo> GetCurrentIdlePropInfos()
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "RestoreCurrentIdleDialogueModeRigFp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void RestoreCurrentPermamentPropIdle(CinematicAssets.PermanentPropInfo permanentProp, List<IdlePropInfo> currentIdlePropInfos)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RestoreCurrentPermamentPropIdle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void RestoreCurrentIdleDialogueModeRigFp(int currentNpcIdleStateHash, List<IdlePropInfo> currentIdlePropInfos)
	{
	}

	[CallerCount(Count = 0)]
	private void RequestCameraTransition(float transitionDurationSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DialogueModeRigFP GetCurrent()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFPSaveData), Member = ".ctor")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCurrentNPCIdleStateHash")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCurrentIdlePropInfos")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 34)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RestoreCurrentIdleDialogueModeRigFp")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void QuitGame()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_setanimationstate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_setanimationparameter")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_setframing")]
	[CalledBy(Type = typeof(Action_PlayAnimationState), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetDialogueFraming), Member = "OnExecute")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static DialogueModeRigFP FindDialogueModeRigFp(string NPC_MissionId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	public DialogueModeRigFP()
	{
	}
}
