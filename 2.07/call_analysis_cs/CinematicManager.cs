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

	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(CinematicManager), Member = "UpdateAnimDrivenEffects")]
	[Calls(Type = typeof(CinematicManager), Member = "IsPlaying")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(CinematicManager), Member = "LockPlayer")]
	[Calls(Type = typeof(CinematicTrack), Member = "Update")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CinematicManager), Member = "UnLockPlayer")]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsNPC")]
	[CallerCount(Count = 0)]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	public void StartLoading(CinematicTrack track, string assetBundleFilemame, string prefabPath)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[CallsUnknownMethods(Count = 4)]
	public bool IsReady()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CallsUnknownMethods(Count = 4)]
	public bool IsLoading()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CinematicManager), Member = "UpdateFadeAndBlur")]
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

	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterNPC")]
	[Calls(Type = typeof(CinematicTrack), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CinematicManager), Member = "ClearSavedAnimationState")]
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

	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void MaybeSetFadedOutOnLoad(DialogueAnimationState dialogueAnimationState)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(CinematicTrack), Member = ".ctor")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	public static CinematicTrack StartMasterFP(FPAnimationState fpAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, CinematicTrack.OnEnterPlaying onEnterPlaying, bool shouldLockPlayer)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CinematicTrack), Member = ".ctor")]
	public static void StartMasterNPC(DialogueAnimationState npcAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, bool shouldLockPlayer)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP._003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "RestoreOriginalControllerAndResumeState")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "SwapNPCController")]
	[Calls(Type = typeof(CinematicManager), Member = "RestoreAnimationState")]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchController")]
	[Calls(Type = typeof(CinematicManager), Member = "SaveAnimationState")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(CinematicAssets), Member = "UseLoadedControllerAndResumeState")]
	public static void SwitchControllerAndResumeState(Animator animatorSource, RuntimeAnimatorController targetController)
	{
	}

	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[CalledBy(Type = typeof(DialogueModeRigFP._003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceFPController")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CalledBy(Type = typeof(CinematicTrack._003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void SwapFPController(Animator fpAnimator, RuntimeAnimatorController controller)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CallsUnknownMethods(Count = 3)]
	public static void SwitchController(Animator animatorSource, RuntimeAnimatorController targetController)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static void ClearSavedAnimationState()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AnimationUtils), Member = "GetValueIn01")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CallsUnknownMethods(Count = 5)]
	public static void SaveAnimationState(Animator animatorSource)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public static void RestoreAnimationState(Animator animatorSource)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[CallsUnknownMethods(Count = 3)]
	public static void CheckAnimationRestored(Animator animatorSource)
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "UpdateAnimDrivenEffects")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	public static void UpdateFadeAndBlur(GameObject effectsBone, float maxBlurSize)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetAdjustedSkipTimeAndTryToSeekAudio(float cinematicDuration, float currentAnimationTime, float audioDuration, string audioStart, uint audioId, GameObject audioEmitterNode)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(MoviePlayer), Member = "Seek")]
	[Calls(Type = typeof(CinematicManager), Member = "GetMovieTimeFromAnimationTime")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CinematicManager), Member = "GetMovieTimeFromAnimationTime")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	public static void MaybeSeekMovie(float cinematicDuration, float currentAnimationTime)
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[CalledBy(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
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

	[CallerCount(Count = 4)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public CinematicManager()
	{
	}
}
