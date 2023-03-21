using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class CinematicManager : MonoBehaviour
{
	public static bool s_IsCutsceneActive;

	private bool m_HasLockedPlayer;

	private PlayerControlMode m_ControlModeToRestore;

	private List<CinematicTrack> m_CinematicTracks;

	private GameObject m_CameraEffectsBone;

	private static float s_AnimationTimeWhenMoviePlayStarted;

	private static Dictionary<Animator, float[]> s_AnimationTimeArrayDict;

	private static Dictionary<Animator, int[]> s_StateHashArrayDict;

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(CinematicTrack), Member = "Update")]
	[Calls(Type = typeof(CinematicManager), Member = "LockPlayer")]
	[Calls(Type = typeof(CinematicManager), Member = "UnLockPlayer")]
	[Calls(Type = typeof(CinematicManager), Member = "IsPlaying")]
	[Calls(Type = typeof(CinematicManager), Member = "UpdateAnimDrivenEffects")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsNPC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CinematicTrack), Member = "LoadAnimations")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	public void StartLoading(CinematicTrack track, string assetBundleFilemame, string prefabPath)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsReady()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsLoading()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CinematicManager), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	public void UpdateAnimDrivenEffects()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsUnknownMethods(Count = 2)]
	private void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void LockPlayer()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UnLockPlayer()
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterNPC")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[Calls(Type = typeof(CinematicTrack), Member = "Play")]
	[Calls(Type = typeof(CinematicManager), Member = "ClearSavedAnimationState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void StartMasterTrack(CinematicTrack cinematic)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	private static void AudioSeek(int audioMs, string audioEventStart, uint audioId, GameObject audioEmitterNode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsUnknownMethods(Count = 1)]
	public static void MaybeSetFadedOutOnLoad(FPAnimationState fpAnimationState)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterNPC")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	public static void MaybeSetFadedOutOnLoad(DialogueAnimationState dialogueAnimationState)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(CinematicTrack), Member = "CreateFPCinematicTrack")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	public static CinematicTrack StartMasterFP(FPAnimationState fpAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, CinematicTrack.OnEnterPlaying onEnterPlaying, bool shouldLockPlayer)
	{
		return null;
	}

	[Calls(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[Calls(Type = typeof(CinematicManager), Member = "MaybeSetFadedOutOnLoad")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CinematicTrack), Member = ".ctor")]
	public static void StartMasterNPC(DialogueAnimationState npcAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, bool shouldLockPlayer)
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "SwapNPCController")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "RestoreOriginalControllerAndResumeState")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "UseLoadedControllerAndResumeState")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CinematicManager), Member = "SaveAnimationState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CinematicManager), Member = "RestoreAnimationState")]
	public static void SwitchControllerAndResumeState(Animator animatorSource, RuntimeAnimatorController targetController)
	{
	}

	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceFPController")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(CinematicTrack._003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	public static void SwapFPController(Animator fpAnimator, RuntimeAnimatorController controller)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	public static void SwitchController(Animator animatorSource, RuntimeAnimatorController targetController)
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearSavedAnimationState()
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(AnimationUtils), Member = "GetValueIn01")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static void SaveAnimationState(Animator animatorSource)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CallsUnknownMethods(Count = 4)]
	public static void RestoreAnimationState(Animator animatorSource)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static void CheckAnimationRestored(Animator animatorSource)
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "UpdateAnimDrivenEffects")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[CallsUnknownMethods(Count = 5)]
	public static void UpdateFadeAndBlur(GameObject effectsBone, float maxBlurSize)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	public static float GetAdjustedSkipTimeAndTryToSeekAudio(float cinematicDuration, float currentAnimationTime, float audioDuration, string audioStart, uint audioId, GameObject audioEmitterNode)
	{
		return default(float);
	}

	[Calls(Type = typeof(MoviePlayer), Member = "Seek")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(CinematicManager), Member = "GetMovieTimeFromAnimationTime")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(CinematicManager), Member = "GetMovieTimeFromAnimationTime")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CallsUnknownMethods(Count = 2)]
	public static void MaybeSeekMovie(float cinematicDuration, float currentAnimationTime)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CalledBy(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[CalledBy(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	public static float GetMovieTimeFromAnimationTime(float animationTime)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float GetAnimationTimeWhenMoviePlayStarted()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static void SetAnimationTimeWhenMoviePlayStarted(float animationTime)
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update_VOPlaying")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	public static bool TryGetTimeFromAudio(float cinematicDuration, float audioDuration, float currentAnimationTime, uint audioID, out float newAnimationTime)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref newAnimationTime) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public CinematicManager()
	{
	}
}
