using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

public class CameraFade : MonoBehaviour
{
	private static bool m_FadeCompleted;

	private static float m_TimeStartFade;

	private static Color m_CurrentScreenOverlayColor;

	private static Color m_TargetScreenOverlayColor;

	private static Color m_StartScreenOverlayColor;

	private static Color m_DeltaColor;

	private static Action m_OnFadeFinish;

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(CameraFade), Member = "NotifyFadeFinish")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public static void UpdateFade()
	{
	}

	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void NotifyFadeFinish()
	{
	}

	[CalledBy(Type = typeof(CameraEffects), Member = "UpdateEffectParameters")]
	[CalledBy(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "MaybeInitFadeOut")]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "InitFadeOutCapture")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddJournalMessage")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fade_in")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fade_out")]
	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[CalledBy(TypeFullName = "JumpManager.<OnSavingCoroutine>d__37", Member = "MoveNext")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(Inventory), Member = "ShouldMakeItemInHandsActive")]
	[CalledBy(TypeFullName = "SaveGameSystem.<SaveScreenshotDataCoroutine>d__57", Member = "MoveNext")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float GetFadeAlpha()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(CinematicManager), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "End")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateBlurEffect")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void BashFadeAlpha(float alpha)
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ClearPendingCallbacks()
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourCameraEffects), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[CalledBy(Type = typeof(CameraFade), Member = "ForceScreenOverlayColor")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetScreenOverlayColor(Color newScreenOverlayColor)
	{
	}

	[CallerCount(Count = 44)]
	[Calls(Type = typeof(Panel_HUD), Member = "SetConditionLabelDepth")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(CameraFade), Member = "NotifyFadeFinish")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void StartAlphaFade(Color newScreenOverlayColor, bool isFadeIn, float fadeDuration, float delay, Action OnFadeFinish)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetTargetFadeScreenOverlayColor(Color newScreenOverlayColor, bool isFadeIn)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "ShouldFreezeMovement")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fade_out")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(Condition_IsCameraFadeActive), Member = "OnCheck")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsFadingOut()
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fade_in")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CalledBy(TypeFullName = "SaveGameSystem.<SaveScreenshotDataCoroutine>d__57", Member = "MoveNext")]
	[CalledBy(Type = typeof(Condition_IsCameraFadeActive), Member = "OnCheck")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsFadingIn()
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnMovieComplete")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void BlackOutScreen()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ForceScreenOverlayColor(Color color)
	{
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float GetTargetAlpha()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float GetStartAlpha()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CameraFade()
	{
	}
}
