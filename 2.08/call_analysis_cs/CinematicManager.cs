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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsUnknownMethods(Count = 2)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(CinematicManager), Member = "IsPlaying")]
	[Calls(Type = typeof(CinematicManager), Member = "UpdateAnimDrivenEffects")]
	[Calls(Type = typeof(CinematicManager), Member = "LockPlayer")]
	[Calls(Type = typeof(CinematicTrack), Member = "Update")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CinematicManager), Member = "UnLockPlayer")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsNPC")]
	[Calls(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void LateUpdate()
	{
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void StartLoading(CinematicTrack track, string assetBundleFilemame, string prefabPath)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CallerCount(Count = 3)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(CinematicManager), Member = "UpdateFadeAndBlur")]
	[CallerCount(Count = 2)]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CinematicManager), Member = "ClearSavedAnimationState")]
	[Calls(Type = typeof(CinematicTrack), Member = "Play")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterNPC")]
	[CallsUnknownMethods(Count = 2)]
	private void StartMasterTrack(CinematicTrack cinematic)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	[CallerCount(Count = 0)]
	private static void AudioSeek(int audioMs, string audioEventStart, uint audioId, GameObject audioEmitterNode)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallerCount(Count = 0)]
	public static void MaybeSetFadedOutOnLoad(FPAnimationState fpAnimationState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsUnknownMethods(Count = 1)]
	public static void MaybeSetFadedOutOnLoad(DialogueAnimationState dialogueAnimationState)
	{
	}

	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CinematicTrack), Member = ".ctor")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	public static CinematicTrack StartMasterFP(FPAnimationState fpAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, CinematicTrack.OnEnterPlaying onEnterPlaying, bool shouldLockPlayer)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(CinematicTrack), Member = ".ctor")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[CallsUnknownMethods(Count = 1)]
	public static void StartMasterNPC(DialogueAnimationState npcAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, bool shouldLockPlayer)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP._003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "SwapNPCController")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "RestoreOriginalControllerAndResumeState")]
	[Calls(Type = typeof(CinematicManager), Member = "SaveAnimationState")]
	[Calls(Type = typeof(CinematicManager), Member = "RestoreAnimationState")]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchController")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(CinematicAssets), Member = "UseLoadedControllerAndResumeState")]
	public static void SwitchControllerAndResumeState(Animator animatorSource, RuntimeAnimatorController targetController)
	{
	}

	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CalledBy(Type = typeof(CinematicTrack._003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceFPController")]
	[CalledBy(Type = typeof(DialogueModeRigFP._003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearSavedAnimationState()
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[Calls(Type = typeof(AnimationUtils), Member = "GetValueIn01")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static void SaveAnimationState(Animator animatorSource)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CallsUnknownMethods(Count = 4)]
	public static void RestoreAnimationState(Animator animatorSource)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "CheckLastAnimationRestore")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void CheckAnimationRestored(Animator animatorSource)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[CalledBy(Type = typeof(CinematicManager), Member = "UpdateAnimDrivenEffects")]
	[CallsUnknownMethods(Count = 5)]
	public static void UpdateFadeAndBlur(GameObject effectsBone, float maxBlurSize)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	public static float GetAdjustedSkipTimeAndTryToSeekAudio(float cinematicDuration, float currentAnimationTime, float audioDuration, string audioStart, uint audioId, GameObject audioEmitterNode)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(MoviePlayer), Member = "Seek")]
	[Calls(Type = typeof(CinematicManager), Member = "GetMovieTimeFromAnimationTime")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsInitialized")]
	[Calls(Type = typeof(CinematicManager), Member = "GetMovieTimeFromAnimationTime")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
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
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CallerCount(Count = 4)]
	public static bool TryGetTimeFromAudio(float cinematicDuration, float audioDuration, float currentAnimationTime, uint audioID, out float newAnimationTime)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref newAnimationTime) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CinematicManager()
	{
	}
}
