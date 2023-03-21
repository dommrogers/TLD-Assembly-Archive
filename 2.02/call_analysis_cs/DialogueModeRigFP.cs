using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
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
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 2)]
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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003CLoadAnimations_003Ed__31(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 40)]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "AbortLoad")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "AbortLoad")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "AbortLoad")]
		[Calls(Type = typeof(CinematicAssets), Member = "ReParentProp")]
		[Calls(Type = typeof(CinematicAssets), Member = "LoadProps")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "RetrieveLoadedAnimators")]
		[Calls(Type = typeof(CinematicAssets), Member = "ReParentProp")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 10)]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "GePrefabPath")]
		[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "GetBundleFilename")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
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
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void UpdateFromUnderCrosshair()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueOptionsAnimationTree), Member = "UpdateClosestToCenter")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateClosestToCenter()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdleUI")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "ProcessInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetMouseButtonDown")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	private void ProcessSelectionConfirm()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLineComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateStart")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "StopPreviousAudio")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnEnter_DialogueModeStateIdle()
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetCameraFov")]
	private void Update_DialogueModeStateIdle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueOptionsAnimationTree), Member = "UpdateClosestToCenter")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateFromUnderCrosshair")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ProcessSelectionConfirm")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Update_DialogueModeStateIdleUI()
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = "OnExecute")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	public void OnSpeech(string meta, Action onStatementFinish, string subtitlesText, IDialogueActor dialogueActor, VoiceOverItem voiceOverItem)
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultTimelineNameForDialogueLineFromLocId")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetFaceStateKeyForState")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultStateNameForDialogueLineFromLocId")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetFirstStateKeyForState")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultAudioStartForDialogueLineFromLocId")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void MaybeAutoAssignDialogueAnimationAndAudio(DialogueStatement dialogueStatement, string locId)
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Dialogue_Cinematic), Member = "OnExecute")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceSavedPosition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CinematicManager), Member = "MaybeSetFadedOutOnLoad")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void OnCinematicPlay(DialogueAnimationState dialogueAnimationState, string audioStart, string audioEnd, Action onCinematicFinish, TextAsset subtitleAsset)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Dialogue_TimelineCinematic), Member = "OnExecute")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	public void OnTimelinePlay(DialogueTimelineScript dialogueTimelineScript, Action onCinematicFinish)
	{
	}

	[CallerCount(Count = 0)]
	public bool CanApplyCameraMotionToJoint()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[CalledBy(Type = typeof(Action_SetDialogueFraming), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_setframing")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnTimelinePlay")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	public void ReplaceCameraFraming(string cameraFraming)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void ReplaceSavedPosition(string cameraFraming)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsUnknownMethods(Count = 2)]
	private float ComputeSubtitleDurationInSeconds(string text)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsAnimationLoadingRequired")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsAnimationAlreadyLoaded")]
	private string GetBundleFilename(string stateKey)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsAnimationLoadingRequired")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsAnimationAlreadyLoaded")]
	private string GePrefabPath(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetBundleFilename")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GePrefabPath")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private bool IsAnimationAlreadyLoaded(string stateKey)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GePrefabPath")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetBundleFilename")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private bool IsAnimationLoadingRequired()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	private void AbortLoad()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	private IEnumerator LoadAnimations(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool AreAssetsReady()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	private void RetrieveLoadedAnimators(string errorPath)
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "LoadAnimations")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnTimelinePlay")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[Calls(Type = typeof(TimelineRef), Member = "LoadForPlayerDirector")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GePrefabPath")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetBundleFilename")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
	private void OnEnter_DialogueModeStateLoadSequence()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "TimelineIndividualLineCompleted")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTimeline")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool ShouldSupressBreathFXForTimeline()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static string GetDefaultStateNameForDialogueLineFromLocId(string localizationId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public static string GetDefaultTimelineNameForDialogueLineFromLocId(string localizationId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public static string GetDefaultLocIdForDialogueLineFromTimeline(string timelineName)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public static string GetDefaultAudioStartForDialogueLineFromLocId(string localizationId)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	private void PlayCinematic()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PlayCinematic")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PlayAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallsUnknownMethods(Count = 10)]
	private void OnEnter_DialogueModeStatePlayCinematic()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetHudModeForCinematic()
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetOnGoingStateDuration")]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(Utils), Member = "GetNextSkipTime")]
	[Calls(Type = typeof(CinematicManager), Member = "GetAdjustedSkipTimeAndTryToSeekAudio")]
	[Calls(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[Calls(Type = typeof(CinematicManager), Member = "TryGetTimeFromAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnCinematicDone")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetSubtitleFrame")]
	[Calls(Type = typeof(CinematicManager), Member = "UpdateAnimDrivenEffects")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Reset")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetCameraFov")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetHudModeForCinematic")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsFPHPlayingIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsFPHPlayingIdle")]
	private void Update_DialogueModeStatePlayCinematic()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallsUnknownMethods(Count = 2)]
	private void OnCinematicDone()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicDone")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	private void OnEnter_DialogueModeStatePlayCinematicComplete()
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsNPCStatePlaying")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "PlayDialogueAnimation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "PlayDialogueAnimation")]
	[CallsUnknownMethods(Count = 2)]
	private string GetTriggeredByName(string stateKey)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	private string GetTriggerIdle(string stateKey)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetStateIdle(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsUnknownMethods(Count = 2)]
	private int GetLayerIndex(string stateKey)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsAnimationRequested()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayVoiceWithPositionTracking")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[CallsUnknownMethods(Count = 12)]
	private void PlayAudio(string audioEventStart, string audioEventStop)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredLocalPosition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCharacterDesiredPosition")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private void LerpCameraFramingToDesired(float normalizedProgress)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLineComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LerpCameraFramingToDesired")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	private void RecenterCameraToDesired()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLineComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsTransitionDone")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredLocalPosition")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCharacterDesiredPosition")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	private bool IsCameraCentered()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetTriggeredByName")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetTriggeredByName")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 24)]
	private void PlayDialogueAnimation()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_CameraControl")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallerCount(Count = 4)]
	private bool IsFPHPlayingIdle()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	private bool IsTransitionDone()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsFPHPlayingIdle")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 4)]
	private void Update_CameraControl()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	private float GetOnGoingStateDuration()
	{
		return default(float);
	}

	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LateUpdate")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[Calls(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
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
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PlayAudio")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PlayDialogueAnimation")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void OnEnter_DialogueModeStatePlayLine()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnNextDialogueRequested")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ProcessAfterDuration")]
	[CallsUnknownMethods(Count = 2)]
	private void DoNextStatement()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DoNextStatement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	private void OnNextDialogueRequested()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DoNextStatement")]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessAfterDuration()
	{
	}

	[CallerCount(Count = 0)]
	private float GetCinematicDuration()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void MaybeUpdateIndividualLineDuration()
	{
	}

	[Calls(Type = typeof(CinematicManager), Member = "TryGetTimeFromAudio")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DoNextStatement")]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "StopPreviousAudio")]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetCameraFov")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsFPHPlayingIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetOnGoingStateDuration")]
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

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallsUnknownMethods(Count = 9)]
	public void AssignTimelineOverride(string trackName, GameObject target)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(TimelineRef), Member = "IsLoaded")]
	[Calls(Type = typeof(TimelineRef), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	private void OnEnter_DialogueModeStateTimeline()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallAnalysisFailed]
	private void Update_DialogueModeStateTimeline()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	private void TimelineIndividualLineCompleted()
	{
	}

	[CallerCount(Count = 0)]
	private void OnTimelineStopped()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerStartedDialogue")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallsUnknownMethods(Count = 74)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCharacterDesiredPosition")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	private void OnEnter_DialogueModeStateTransitionIn()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	private void MaybeStowItemInHand()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsNPCReady()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private bool AreHandsReady()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnItemInHandStowed()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredLocalPosition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCharacterDesiredPosition")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	private void Update_DialogueModeStateTransitionIn()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private static void LerpPlayer(float progress, Vector3 originalPlayerPosition, Quaternion originalCameraRotation, Vector3 originalLocalCameraPosition, float originalFov, Vector3 desiredPlayerPosition, Quaternion desiredCameraRotation, Vector3 desireedLocalCameraPosition, float desiredFov)
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerEndedDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void OnEnter_DialogueModeStateTransitionOut()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetHipAndShoulderOffsetLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	private void Update_DialogueModeStateTransitionOut()
	{
	}

	[Calls(Type = typeof(DialogueOptionsAnimationTree), Member = "InstantiateLabels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetNPCAnimator")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	public void SetAnimationParameter_IsInDialogue(bool isInDialogue)
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetCameraFov")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTimeline")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsNPCStatePlaying")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsNPCStatePlaying")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LateSynchronizeAnimators")]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDialogueTreeFinished")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(DialogueTree), Member = "remove_OnDialogueStarted")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueTree), Member = "remove_OnDialogueFinished")]
	public void OnPlayerEndedDialogue()
	{
	}

	[CallerCount(Count = 0)]
	public void SetExitRequestedAction(Action onExitRequested)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueTree), Member = "add_OnDialogueFinished")]
	[Calls(Type = typeof(DialogueTree), Member = "add_OnDialogueStarted")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "StartDialogueTree")]
	[CallsUnknownMethods(Count = 14)]
	public void OnPlayerStartedDialogue()
	{
	}

	[CallerCount(Count = 0)]
	public void SetDialogueController(DialogueTreeController dialogTreeController)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetGroundPlayerOnEnd(bool groundPlayer)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetNameIDFromDescID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ResetDialogueController()
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "OnPhonePickupComplete")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnPlayerStartedDialogue")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RequestExitDialogue()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsInTransition()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsInIdle()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool CanShowDialogueUI()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectWithConstraints")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public bool RespectContrainsts()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	public void SetFilter(List<DialogueOptionTopic> filter, bool clearFilter)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnButtonSelected")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void OnChoiceSelected(int choiceIndex)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(CellToilet), Member = "Update")]
	public void SetOnDialogueEndsAction(Action onDialogueEnds)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCurrentTimelineTime")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetSubtitleFrame")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallsUnknownMethods(Count = 54)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
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
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LogChoices")]
	public bool MaybeGetAssignedChoiceCategory(int choiceIndex, string locId, out Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		System.Runtime.CompilerServices.Unsafe.As<Dialogue_MultipleChoiceNode.ChoiceCategory, @null>(ref category) = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetChoiceInfo")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_assign")]
	[CallsUnknownMethods(Count = 8)]
	public bool AssignCategory(int choiceIndex, Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		return default(bool);
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAssignedSlot")]
	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_logchoices")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "MaybeGetAssignedChoiceCategory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void LogChoices()
	{
	}

	[CallerCount(Count = 0)]
	public void ReplacePlayerExit(Vector3 playerPosition, Quaternion cameraRotation, Vector3 originalCameraLocalPos)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetChoiceInfo")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCategoryAssigned(int choiceIndex, Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LogChoices")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private DialogueSequenceFP GetAssignedSlot(int choiceIndex)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignCategory")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCategoryAssigned")]
	[CallsUnknownMethods(Count = 3)]
	private DialogueChoiceInfo GetChoiceInfo(int choiceIndex)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLineComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsNPCStatePlaying(int hashState, int layer)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTimeline")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueTreeChoices")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDestroy")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoicesAfterFilterChange")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	private void EnableDialogueSequenceFP(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetPitchLimitFromBase")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	private void LimitCameraRotation()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDestroy")]
	[Calls(Type = typeof(CinematicAssets), Member = "UnloadProps")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UnloadAnimations()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "UpdateText")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetupNormalUILabelText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAvailableSlotForCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAvailableSlotForCategory")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetChoiceEnabled")]
	private DialogueSequenceFP AssignChoiceToCategorySlot(Dialogue_MultipleChoiceNode.ChoiceCategory category, string dialogueChoiceText, int choiceIndex, float textSize)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignHiddenChoiceToCategorySlot")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignHiddenChoiceToCategorySlot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	private DialogueSequenceFP GetAvailableSlotForCategory(Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private Dialogue_MultipleChoiceNode.ChoiceCategory GetFallbackSlotCategory(Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		return default(Dialogue_MultipleChoiceNode.ChoiceCategory);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CallsUnknownMethods(Count = 4)]
	private DialogueChoiceCategoryConfiguration GetCategoryConfiguration(Dialogue_MultipleChoiceNode.ChoiceCategory choiceCategory)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAvailableSlotForCategory")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAvailableSlotForCategory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AssignHiddenChoiceToCategorySlot(Dialogue_MultipleChoiceNode.ChoiceCategory category, string dialogueChoiceText, int choiceIndex)
	{
	}

	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueTreeChoices")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdle")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCategoryConfiguration")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCategoryConfiguration")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoicesAfterFilterChange")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "AssignHiddenChoiceToCategorySlot")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "MaybeGetAssignedChoiceCategory")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetChoiceEnabled")]
	[Calls(Type = typeof(FontManager), Member = "ResetCurrentFonts")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	private void UpdateChoiceAssignment()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocString")]
	internal void SetDialogueTreeChoices(List<Dialogue_MultipleChoiceNode.Choice> dialogueChoices, int loopBackIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsChoiceAcceptedByFilter(DialogueOptionTopic topic)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	private uint PostAudioEvent(string soundID, GameObject go)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	private void StopPreviousAudio()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematicComplete")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTimeline")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	public void SetDialogueModeState(DialogueModeState dialogueModeState)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallsUnknownMethods(Count = 4)]
	public Animator GetNPCAnimator()
	{
		return null;
	}

	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ReplaceFPController(DialogueControllerMode dialogueControllerMode)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDestroy")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(CinematicAssets), Member = "UseLoadedControllerAndResumeState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[Calls(Type = typeof(CinematicAssets), Member = "RestoreOriginalControllerAndResumeState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	private void ReplaceAnimControllerAndResumeState(DialogueControllerMode dialogueControllerMode)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(CinematicManager), Member = "CheckAnimationRestored")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[Calls(Type = typeof(CinematicManager), Member = "CheckAnimationRestored")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	private void CheckLastAnimationRestore()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdle")]
	private void SetCameraFov()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsStatePlaying(int stateHash)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnNextDialogueRequested")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetTriggerIdle")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetTriggerIdle")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 21)]
	private void ReturnToIdleAnimation()
	{
	}

	[CallerCount(Count = 0)]
	private void OnEnter_DialogueModeStateEnd()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "StopPreviousAudio")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	private void ExitDialogueMode()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[Calls(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(CinematicManager), Member = "ClearSavedAnimationState")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	private void OnEnter_DialogueModeStateStart()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateNone")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateNone")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	private void DisableDialogue()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	private void Update_DialogueModeStateEnd()
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnEnter_DialogueModeStateNone()
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Update_DialogueModeStateNone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	private void Update_DialogueModeStateStart()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpCameraFramingToDesired")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CallsUnknownMethods(Count = 7)]
	private Vector3 GetCharacterDesiredPosition()
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpCameraFramingToDesired")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	private Quaternion GetCameraDesiredRotation()
	{
		return default(Quaternion);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private Vector3 GetReferenceCameraForward()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Vector3 GetReferenceCameraRight()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpCameraFramingToDesired")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CallsUnknownMethods(Count = 3)]
	private Vector3 GetCameraDesiredLocalPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 2)]
	private int GetCurrentNPCIdleStateHash()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SerializeAll")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private List<IdlePropInfo> GetCurrentIdlePropInfos()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "RestoreCurrentIdleDialogueModeRigFp")]
	[CallsUnknownMethods(Count = 9)]
	private void RestoreCurrentPermamentPropIdle(CinematicAssets.PermanentPropInfo permanentProp, List<IdlePropInfo> currentIdlePropInfos)
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "RestoreCurrentPermamentPropIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
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

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCurrentIdlePropInfos")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCurrentNPCIdleStateHash")]
	[Calls(Type = typeof(DialogueModeRigFPSaveData), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RestoreCurrentIdleDialogueModeRigFp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	public static void QuitGame()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_SetDialogueFraming), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayAnimationState), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_setframing")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_setanimationparameter")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_setanimationstate")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "DeserializeAll")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static DialogueModeRigFP FindDialogueModeRigFp(string NPC_MissionId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public DialogueModeRigFP()
	{
	}
}
