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
using TLD.AddressableAssets;
using TLD.Interactions;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Timeline;

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

		[CallsUnknownMethods(Count = 8)]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SerializeAll")]
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
		[CallerCount(Count = 6)]
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
		[CallerCount(Count = 6)]
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
		[CallerCount(Count = 6)]
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
		[CallerCount(Count = 6)]
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
		public CinematicMoment()
		{
		}
	}

	private sealed class _003CLoadAnimations_003Ed__250 : IEnumerator<object>, IEnumerator, IDisposable
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
			[CallerCount(Count = 44)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		public _003CLoadAnimations_003Ed__250(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(DialogueModeRigFP), Member = "AbortLoad")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "AbortLoad")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "AbortLoad")]
		[Calls(Type = typeof(CinematicAssets), Member = "ReParentProp")]
		[Calls(Type = typeof(CinematicAssets), Member = "ReParentProp")]
		[Calls(Type = typeof(CinematicAssets), Member = "LoadProps")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "RetrieveLoadedAnimators")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsUnknownMethods(Count = 11)]
		[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "GePrefabPath")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "GetBundleFilename")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
		[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private PanelReference<Panel_Loading> m_Loading;

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

	private PlayerControlMode m_RestorePlayerControlMode;

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

	private PanelReference<Panel_HUD> m_HUD;

	private const string SUBTITLE_PREFIX = "SUBTITLE_";

	private const string ANIMATION_STATE_PREFIX = "Dia_";

	private const string TIMELINE_PREFIX = "Dia_";

	private const string AUDIO_START_PREFIX = "Play_SndVO";

	private AssetReferenceTimeline m_TimelineRef;

	private AssetReferenceTimeline m_RequestedTimelineRef;

	private TimelineAsset m_LoadedTimeline;

	private bool m_LoadTimelineCompleted;

	private bool m_LoadTimelineFailed;

	private bool m_LerpCameraOffset;

	private bool m_ResetAimingModeRequested;

	private bool m_DisableBreathFXForTimeline;

	private HudDisplayMode m_RestoreHudDisplayMode;

	private bool m_DelaySubtitles;

	private const HudDisplayMode CINEMATIC_HUD_MODE = HudDisplayMode.Subtitles;

	private PanelReference<Panel_Subtitles> m_Subtitles;

	private bool m_IsTimelinePlaying;

	private bool m_StopRequested;

	private List<TLD_TimelineDirector.BindingInfo> m_TimelineBindingOverrides;

	private bool m_HandsReady;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueOptionsAnimationTree), Member = "InstantiateLabels")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetNPCAnimator")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	public void SetAnimationParameter_IsInDialogue(bool isInDialogue)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetCameraFov")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsNPCStatePlaying")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTimeline")]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LateSynchronizeAnimators")]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDialogueTreeFinished")]
	[Calls(Type = typeof(DialogueTree), Member = "remove_OnDialogueFinished")]
	[Calls(Type = typeof(DialogueTree), Member = "remove_OnDialogueStarted")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[CallerCount(Count = 1)]
	public void OnPlayerEndedDialogue()
	{
	}

	[CallerCount(Count = 0)]
	public void SetExitRequestedAction(Action onExitRequested)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DialogueTree), Member = "add_OnDialogueFinished")]
	[Calls(Type = typeof(DialogueTree), Member = "add_OnDialogueStarted")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "StartDialogueTree")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public void ResetDialogueController()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetNameIDFromDescID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[CallerCount(Count = 0)]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "OnPhonePickupComplete")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnPlayerStartedDialogue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void PerformInteraction()
	{
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 5)]
	public bool RespectContrainsts()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetFilter(List<DialogueOptionTopic> filter, bool clearFilter)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnButtonSelected")]
	[CallsUnknownMethods(Count = 2)]
	public void OnChoiceSelected(int choiceIndex)
	{
	}

	[CallerCount(Count = 0)]
	public void SetOnDialogueEndsAction(Action onDialogueEnds)
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCurrentTimelineTime")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LogChoices")]
	public bool MaybeGetAssignedChoiceCategory(int choiceIndex, string locId, out Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		System.Runtime.CompilerServices.Unsafe.As<Dialogue_MultipleChoiceNode.ChoiceCategory, @null>(ref category) = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetChoiceInfo")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_assign")]
	[CallsUnknownMethods(Count = 6)]
	public bool AssignCategory(int choiceIndex, Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_logchoices")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAssignedSlot")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "MaybeGetAssignedChoiceCategory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public void LogChoices()
	{
	}

	[CallerCount(Count = 0)]
	public void ReplacePlayerExit(Vector3 playerPosition, Quaternion cameraRotation, Vector3 originalCameraLocalPos)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetChoiceInfo")]
	private void OnCategoryAssigned(int choiceIndex, Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LogChoices")]
	[CallsUnknownMethods(Count = 3)]
	private DialogueSequenceFP GetAssignedSlot(int choiceIndex)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignCategory")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCategoryAssigned")]
	private DialogueChoiceInfo GetChoiceInfo(int choiceIndex)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLineComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	private bool IsNPCStatePlaying(int hashState, int layer)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTimeline")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoicesAfterFilterChange")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueTreeChoices")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDestroy")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	private void EnableDialogueSequenceFP(bool enabled)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	private void LimitCameraRotation()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[Calls(Type = typeof(CinematicAssets), Member = "UnloadProps")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDestroy")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UnloadAnimations()
	{
	}

	[Calls(Type = typeof(DialogueSequenceFP), Member = "UpdateText")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetupNormalUILabelText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetChoiceEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAvailableSlotForCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAvailableSlotForCategory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private DialogueSequenceFP AssignChoiceToCategorySlot(Dialogue_MultipleChoiceNode.ChoiceCategory category, string dialogueChoiceText, int choiceIndex, float textSize)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignHiddenChoiceToCategorySlot")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignHiddenChoiceToCategorySlot")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CallsUnknownMethods(Count = 4)]
	private DialogueChoiceCategoryConfiguration GetCategoryConfiguration(Dialogue_MultipleChoiceNode.ChoiceCategory choiceCategory)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAvailableSlotForCategory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetAvailableSlotForCategory")]
	private void AssignHiddenChoiceToCategorySlot(Dialogue_MultipleChoiceNode.ChoiceCategory category, string dialogueChoiceText, int choiceIndex)
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCategoryConfiguration")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoicesAfterFilterChange")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueTreeChoices")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCategoryConfiguration")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "MaybeGetAssignedChoiceCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "AssignHiddenChoiceToCategorySlot")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetChoiceEnabled")]
	[Calls(Type = typeof(FontManager), Member = "ResetFontsForCharacterSet")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private void UpdateChoiceAssignment()
	{
	}

	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocString")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	internal void SetDialogueTreeChoices(List<Dialogue_MultipleChoiceNode.Choice> dialogueChoices, int loopBackIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsChoiceAcceptedByFilter(DialogueOptionTopic topic)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 1)]
	private uint PostAudioEvent(string soundID, GameObject go)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopPreviousAudio()
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematicComplete")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTimeline")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	public void SetDialogueModeState(DialogueModeState dialogueModeState)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[CalledBy(Type = typeof(Phone), Member = "Awake")]
	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallsUnknownMethods(Count = 3)]
	public Animator GetNPCAnimator()
	{
		return null;
	}

	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ReplaceFPController(DialogueControllerMode dialogueControllerMode)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnDestroy")]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[Calls(Type = typeof(CinematicAssets), Member = "UseLoadedControllerAndResumeState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[Calls(Type = typeof(CinematicAssets), Member = "RestoreOriginalControllerAndResumeState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ReplaceAnimControllerAndResumeState(DialogueControllerMode dialogueControllerMode)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(CinematicManager), Member = "CheckAnimationRestored")]
	[Calls(Type = typeof(CinematicManager), Member = "CheckAnimationRestored")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void CheckLastAnimationRestore()
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CallsUnknownMethods(Count = 2)]
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

	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetTriggerIdle")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnNextDialogueRequested")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetTriggerIdle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void ReturnToIdleAnimation()
	{
	}

	[CallerCount(Count = 0)]
	private void OnEnter_DialogueModeStateEnd()
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "StopPreviousAudio")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void ExitDialogueMode()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[Calls(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(CinematicManager), Member = "ClearSavedAnimationState")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	private void OnEnter_DialogueModeStateStart()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateNone")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateNone")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DisableDialogue()
	{
	}

	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DisableDialogue")]
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

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpCameraFramingToDesired")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	private Vector3 GetCharacterDesiredPosition()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpCameraFramingToDesired")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	private Quaternion GetCameraDesiredRotation()
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 2)]
	private Vector3 GetReferenceCameraForward()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsUnknownMethods(Count = 2)]
	private Vector3 GetReferenceCameraRight()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LerpCameraFramingToDesired")]
	private Vector3 GetCameraDesiredLocalPosition()
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private int GetCurrentNPCIdleStateHash()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 15)]
	private List<IdlePropInfo> GetCurrentIdlePropInfos()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "RestoreCurrentIdleDialogueModeRigFp")]
	[CallsUnknownMethods(Count = 9)]
	private void RestoreCurrentPermamentPropIdle(CinematicAssets.PermanentPropInfo permanentProp, List<IdlePropInfo> currentIdlePropInfos)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "DeserializeAll")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RestoreCurrentPermamentPropIdle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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
	public static DialogueModeRigFP GetCurrent()
	{
		return null;
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCurrentIdlePropInfos")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFPSaveData), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCurrentNPCIdleStateHash")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RestoreCurrentIdleDialogueModeRigFp")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[CallerCount(Count = 2)]
	public static void QuitGame()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_SetDialogueFraming), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayAnimationState), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_setanimationparameter")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_setanimationstate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_setframing")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "DeserializeAll")]
	public static DialogueModeRigFP FindDialogueModeRigFp(string NPC_MissionId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	private void UpdateChoicesAfterFilterChange()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdleUI")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void UpdateFromUnderCrosshair()
	{
	}

	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetMouseButtonDown")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	private void ProcessSelectionConfirm()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLineComplete")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "StopPreviousAudio")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateStart")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LimitCameraRotation")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	private void OnEnter_DialogueModeStateIdle()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
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
	public void Update_DialogueModeStateIdleUI()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = "OnExecute")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	public void OnSpeech(string meta, Action onStatementFinish, string subtitlesText, IDialogueActor dialogueActor, VoiceOverItem voiceOverItem)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetFirstStateKeyForState")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultStateNameForDialogueLineFromLocId")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultAudioStartForDialogueLineFromLocId")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetFaceStateKeyForState")]
	private void MaybeAutoAssignDialogueAnimationAndAudio(DialogueStatement dialogueStatement, string locId)
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceSavedPosition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Dialogue_Cinematic), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(CinematicManager), Member = "MaybeSetFadedOutOnLoad")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	public void OnCinematicPlay(DialogueAnimationState dialogueAnimationState, string audioStart, string audioEnd, Action onCinematicFinish, TextAsset subtitleAsset)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Dialogue_TimelineCinematic), Member = "OnExecute")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[CallerCount(Count = 1)]
	public void OnTimelinePlay(DialogueTimelineScript dialogueTimelineScript, Action onCinematicFinish)
	{
	}

	[CallerCount(Count = 0)]
	public bool CanApplyCameraMotionToJoint()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_SetDialogueFraming), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dialogue_setframing")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnTimelinePlay")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	public void ReplaceCameraFraming(string cameraFraming)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void ReplaceSavedPosition(string cameraFraming)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsUnknownMethods(Count = 1)]
	private float ComputeSubtitleDurationInSeconds(string text)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsAnimationAlreadyLoaded")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsAnimationLoadingRequired")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	private string GetBundleFilename(string stateKey)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsAnimationLoadingRequired")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsAnimationAlreadyLoaded")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	private string GePrefabPath(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetBundleFilename")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GePrefabPath")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool IsAnimationAlreadyLoaded(string stateKey)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetBundleFilename")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GePrefabPath")]
	private bool IsAnimationLoadingRequired()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	private void AbortLoad()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[IteratorStateMachine(typeof(_003CLoadAnimations_003Ed__250))]
	[CallerCount(Count = 1)]
	private IEnumerator LoadAnimations(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool AreAssetsReady()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 9)]
	private void RetrieveLoadedAnimators(string errorPath)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "LoadTimeline")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnTimelinePlay")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UnloadTimeline")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsAnimationLoadingRequired")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LoadAnimations")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnter_DialogueModeStateLoadSequence()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "TimelineIndividualLineCompleted")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTimeline")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	private void Update_DialogueModeStateLoadSequence()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "get_IsLoaded")]
	[CallsUnknownMethods(Count = 1)]
	private void OnLoadTimelineCompleted(AssetReferenceTimeline result)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateLoadSequence")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void UnloadTimeline()
	{
	}

	[CallerCount(Count = 0)]
	private bool IsTimelineRequested()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool ShouldSupressBreathFXForTimeline()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public static string GetDefaultStateNameForDialogueLineFromLocId(string localizationId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public static string GetDefaultTimelineNameForDialogueLineFromLocId(string localizationId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetDefaultLocIdForDialogueLineFromTimeline(string timelineName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
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

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PlayCinematic")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PlayAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnter_DialogueModeStatePlayCinematic()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetHudModeForCinematic()
	{
	}

	[Calls(Type = typeof(CinematicManager), Member = "GetAdjustedSkipTimeAndTryToSeekAudio")]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[Calls(Type = typeof(Utils), Member = "GetNextSkipTime")]
	[Calls(Type = typeof(CinematicManager), Member = "TryGetTimeFromAudio")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsFPHPlayingIdle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnCinematicDone")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetOnGoingStateDuration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetStandardAimingMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetCameraFov")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetHudModeForCinematic")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[Calls(Type = typeof(CinematicManager), Member = "UpdateAnimDrivenEffects")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsFPHPlayingIdle")]
	private void Update_DialogueModeStatePlayCinematic()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallsUnknownMethods(Count = 1)]
	private void OnCinematicDone()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicDone")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	private void OnEnter_DialogueModeStatePlayCinematicComplete()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsNPCStatePlaying")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UnloadTimeline")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	private void Update_DialogueModeStatePlayCinematicComplete()
	{
	}

	[CallerCount(Count = 0)]
	public void DialogueNext()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetAudioDurationRealtimeSeconds(float duration)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "PlayDialogueAnimation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "PlayDialogueAnimation")]
	[CallsUnknownMethods(Count = 1)]
	private string GetTriggeredByName(string stateKey)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	private string GetTriggerIdle(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsUnknownMethods(Count = 1)]
	private string GetStateIdle(string stateKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsUnknownMethods(Count = 1)]
	private int GetLayerIndex(string stateKey)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsAnimationRequested()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayVoiceWithPositionTracking")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallerCount(Count = 2)]
	private void PlayAudio(string audioEventStart, string audioEventStop)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredLocalPosition")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCharacterDesiredPosition")]
	private void LerpCameraFramingToDesired(float normalizedProgress)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLineComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LerpCameraFramingToDesired")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	private void RecenterCameraToDesired()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLineComplete")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsTransitionDone")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematicComplete")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredLocalPosition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCharacterDesiredPosition")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	private bool IsCameraCentered()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetTriggeredByName")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetTriggeredByName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	private void PlayDialogueAnimation()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_CameraControl")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
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
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsFPHPlayingIdle")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 3)]
	private void Update_CameraControl()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	private float GetOnGoingStateDuration()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LateUpdate")]
	[Calls(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[Calls(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PlayAudio")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "PlayDialogueAnimation")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void OnEnter_DialogueModeStatePlayLine()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ProcessAfterDuration")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnNextDialogueRequested")]
	private void DoNextStatement()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DoNextStatement")]
	[CallsUnknownMethods(Count = 1)]
	private void OnNextDialogueRequested()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DoNextStatement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	private void ProcessAfterDuration()
	{
	}

	[CallerCount(Count = 0)]
	private float GetCinematicDuration()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeUpdateIndividualLineDuration()
	{
	}

	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "StopPreviousAudio")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(CinematicManager), Member = "TryGetTimeFromAudio")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DoNextStatement")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsCameraCentered")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetCameraFov")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetOnGoingStateDuration")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "IsFPHPlayingIdle")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RecenterCameraToDesired")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private static void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Phone), Member = "Awake")]
	[CalledBy(Type = typeof(Phone), Member = "AssignBindingOverrides")]
	[CallsUnknownMethods(Count = 7)]
	public void AssignTimelineOverride(string trackName, GameObject target)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateLoadSequence")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void OnEnter_DialogueModeStateTimeline()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
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

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerStartedDialogue")]
	private void OnEnter_DialogueModeStateTransitionIn()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeStowItemInHand()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	private bool IsNPCReady()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private bool AreHandsReady()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private void OnItemInHandStowed()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredLocalPosition")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCameraDesiredRotation")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetCharacterDesiredPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationUtils), Member = "IsAnyLayerInAnimationTransition")]
	private void Update_DialogueModeStateTransitionIn()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	private static void LerpPlayer(float progress, Vector3 originalPlayerPosition, Quaternion originalCameraRotation, Vector3 originalLocalCameraPosition, float originalFov, Vector3 desiredPlayerPosition, Quaternion desiredCameraRotation, Vector3 desireedLocalCameraPosition, float desiredFov)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "EnableDialogueSequenceFP")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnPlayerEndedDialogue")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueModeState")]
	private void OnEnter_DialogueModeStateTransitionOut()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "LerpPlayer")]
	private void Update_DialogueModeStateTransitionOut()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	public DialogueModeRigFP()
	{
	}
}
