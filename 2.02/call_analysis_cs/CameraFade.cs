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

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(CameraFade), Member = "NotifyFadeFinish")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	public static void UpdateFade()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void NotifyFadeFinish()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fade_in")]
	[CalledBy(Type = typeof(SaveGameSystem._003CSaveScreenshotDataCoroutine_003Ed__57), Member = "MoveNext")]
	[CalledBy(Type = typeof(Inventory), Member = "ShouldMakeItemInHandsActive")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(JumpManager._003COnSavingCoroutine_003Ed__37), Member = "MoveNext")]
	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fade_out")]
	[CalledBy(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(GearMessage), Member = "AddJournalMessage")]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "InitFadeOutCapture")]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "MaybeInitFadeOut")]
	[CalledBy(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[CalledBy(Type = typeof(CameraEffects), Member = "UpdateEffectParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	public static float GetFadeAlpha()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateBlurEffect")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "End")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(CinematicManager), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	public static void BashFadeAlpha(float alpha)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	public static void ClearPendingCallbacks()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CameraFade), Member = "ForceScreenOverlayColor")]
	[CalledBy(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	[CalledBy(Type = typeof(PlayableBehaviourCameraEffects), Member = "ProcessFrame")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	public static void SetScreenOverlayColor(Color newScreenOverlayColor)
	{
	}

	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraFade), Member = "NotifyFadeFinish")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(Panel_HUD), Member = "SetConditionLabelDepth")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public static void StartAlphaFade(Color newScreenOverlayColor, bool isFadeIn, float fadeDuration, float delay, Action OnFadeFinish)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetTargetFadeScreenOverlayColor(Color newScreenOverlayColor, bool isFadeIn)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CalledBy(Type = typeof(Condition_IsCameraFadeActive), Member = "OnCheck")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fade_out")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "ShouldFreezeMovement")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	public static bool IsFadingOut()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Condition_IsCameraFadeActive), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_IsCameraFadeActive), Member = "OnCheck")]
	[CalledBy(Type = typeof(SaveGameSystem._003CSaveScreenshotDataCoroutine_003Ed__57), Member = "MoveNext")]
	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fade_in")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	public static bool IsFadingIn()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnMovieComplete")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	public static void BlackOutScreen()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[CallerCount(Count = 0)]
	public static void ForceScreenOverlayColor(Color color)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	public static float GetTargetAlpha()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float GetStartAlpha()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CameraFade()
	{
	}
}
