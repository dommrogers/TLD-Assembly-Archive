using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Audio;
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

	[Calls(Type = typeof(CameraFade), Member = "GetHUD")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(CameraFade), Member = "NotifyFadeFinish")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(CameraFade), Member = "NotifyFadeFinish")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	public static void UpdateFade()
	{
	}

	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void NotifyFadeFinish()
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(Inventory), Member = "ShouldMakeItemInHandsActive")]
	[CalledBy(Type = typeof(SaveGameSystem._003CSaveScreenshotDataCoroutine_003Ed__115), Member = "MoveNext")]
	public static float GetFadeAlpha()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateBlurEffect")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(CinematicManager), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[Calls(Type = typeof(CameraFade), Member = "GetHUD")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	public static void BashFadeAlpha(float alpha)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	public static void ClearPendingCallbacks()
	{
	}

	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnMovieStop")]
	[CalledBy(Type = typeof(CameraFade), Member = "ForceScreenOverlayColor")]
	[CalledBy(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	[CalledBy(Type = typeof(PlayableBehaviourCameraEffects), Member = "ProcessFrame")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraFade), Member = "GetHUD")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	public static void SetScreenOverlayColor(Color newScreenOverlayColor)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "NotifyFadeFinish")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(CameraFade), Member = "GetHUD")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 47)]
	[Calls(Type = typeof(Panel_HUD), Member = "SetConditionLabelDepth")]
	public static void StartAlphaFade(Color newScreenOverlayColor, bool isFadeIn, float fadeDuration, float delay, Action OnFadeFinish)
	{
	}

	[CallerCount(Count = 0)]
	public static void SetTargetFadeScreenOverlayColor(Color newScreenOverlayColor, bool isFadeIn)
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CalledBy(Type = typeof(Condition_IsCameraFadeActive), Member = "OnCheck")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "ShouldFreezeMovement")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fade_out")]
	public static bool IsFadingOut()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Condition_IsCameraFadeActive), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_IsCameraFadeActive), Member = "OnCheck")]
	[CalledBy(Type = typeof(SaveGameSystem._003CSaveScreenshotDataCoroutine_003Ed__115), Member = "MoveNext")]
	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fade_in")]
	[CallerCount(Count = 6)]
	public static bool IsFadingIn()
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnCreditsEnd")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "PlayMovie")]
	public static void BlackOutScreen()
	{
	}

	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[CallerCount(Count = 0)]
	public static void ForceScreenOverlayColor(Color color)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	public static float GetTargetAlpha()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float GetStartAlpha()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[CalledBy(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	private static Panel_HUD GetHUD()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CameraFade()
	{
	}
}
