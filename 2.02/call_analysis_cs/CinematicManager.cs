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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsUnknownMethods(Count = 4)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(CinematicManager), Member = "UpdateAnimDrivenEffects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CinematicManager), Member = "UnLockPlayer")]
	[Calls(Type = typeof(CinematicManager), Member = "LockPlayer")]
	[Calls(Type = typeof(CinematicTrack), Member = "Update")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CinematicManager), Member = "IsPlaying")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsNPC")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public bool IsReady()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsLoading()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CinematicManager), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateAnimDrivenEffects()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void LockPlayer()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void UnLockPlayer()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CinematicManager), Member = "ClearSavedAnimationState")]
	[Calls(Type = typeof(CinematicTrack), Member = "Play")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterNPC")]
	[CallsUnknownMethods(Count = 3)]
	private void StartMasterTrack(CinematicTrack cinematic)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void AudioSeek(int audioMs, string audioEventStart, uint audioId, GameObject audioEmitterNode)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void MaybeSetFadedOutOnLoad(FPAnimationState fpAnimationState)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterNPC")]
	[CallsUnknownMethods(Count = 1)]
	public static void MaybeSetFadedOutOnLoad(DialogueAnimationState dialogueAnimationState)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CinematicTrack), Member = "CreateFPCinematicTrack")]
	public static CinematicTrack StartMasterFP(FPAnimationState fpAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, CinematicTrack.OnEnterPlaying onEnterPlaying, bool shouldLockPlayer)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(CinematicTrack), Member = "CreateNPCCinematicTrack")]
	[Calls(Type = typeof(CinematicManager), Member = "MaybeSetFadedOutOnLoad")]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[CallsUnknownMethods(Count = 4)]
	public static void StartMasterNPC(DialogueAnimationState npcAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, bool shouldLockPlayer)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "SwapNPCController")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "UseLoadedControllerAndResumeState")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "RestoreOriginalControllerAndResumeState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CinematicManager), Member = "SaveAnimationState")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CinematicManager), Member = "RestoreAnimationState")]
	public static void SwitchControllerAndResumeState(Animator animatorSource, RuntimeAnimatorController targetController)
	{
	}

	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearParametersCache")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceFPController")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[CalledBy(Type = typeof(CinematicTrack._003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	public static void SwapFPController(Animator fpAnimator, RuntimeAnimatorController controller)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 3)]
	public static void SwitchController(Animator animatorSource, RuntimeAnimatorController targetController)
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	public static void ClearSavedAnimationState()
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[Calls(Type = typeof(AnimationUtils), Member = "GetValueIn01")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 14)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static void SaveAnimationState(Animator animatorSource)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CallsUnknownMethods(Count = 13)]
	public static void RestoreAnimationState(Animator animatorSource)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static void CheckAnimationRestored(Animator animatorSource)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[CalledBy(Type = typeof(CinematicManager), Member = "UpdateAnimDrivenEffects")]
	[CallsUnknownMethods(Count = 9)]
	public static void UpdateFadeAndBlur(GameObject effectsBone, float maxBlurSize)
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public static float GetAdjustedSkipTimeAndTryToSeekAudio(float cinematicDuration, float currentAnimationTime, float audioDuration, string audioStart, uint audioId, GameObject audioEmitterNode)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(CinematicManager), Member = "GetMovieTimeFromAnimationTime")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(CinematicManager), Member = "GetMovieTimeFromAnimationTime")]
	[Calls(Type = typeof(MoviePlayer), Member = "Seek")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CallsUnknownMethods(Count = 2)]
	public static void MaybeSeekMovie(float cinematicDuration, float currentAnimationTime)
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CalledBy(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static float GetMovieTimeFromAnimationTime(float animationTime)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float GetAnimationTimeWhenMoviePlayStarted()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetAnimationTimeWhenMoviePlayStarted(float animationTime)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update_VOPlaying")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	public static bool TryGetTimeFromAudio(float cinematicDuration, float audioDuration, float currentAnimationTime, uint audioID, out float newAnimationTime)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref newAnimationTime) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public CinematicManager()
	{
	}
}
