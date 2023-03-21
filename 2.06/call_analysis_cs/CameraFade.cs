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

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(CameraFade), Member = "NotifyFadeFinish")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(CameraFade), Member = "GetHUD")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void UpdateFade()
	{
	}

	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void NotifyFadeFinish()
	{
	}

	[CalledBy(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[CalledBy(TypeFullName = "JumpManager.<OnSavingCoroutine>d__38", Member = "MoveNext")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(Inventory), Member = "ShouldMakeItemInHandsActive")]
	[CalledBy(TypeFullName = "SaveGameSystem.<SaveScreenshotDataCoroutine>d__115", Member = "MoveNext")]
	[CallerCount(Count = 5)]
	public static float GetFadeAlpha()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[CalledBy(Type = typeof(CinematicManager), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateBlurEffect")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CameraFade), Member = "GetHUD")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void BashFadeAlpha(float alpha)
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CallerCount(Count = 5)]
	public static void ClearPendingCallbacks()
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourCameraEffects), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[CalledBy(Type = typeof(CameraFade), Member = "ForceScreenOverlayColor")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnMovieStop")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CameraFade), Member = "GetHUD")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetScreenOverlayColor(Color newScreenOverlayColor)
	{
	}

	[CallerCount(Count = 44)]
	[Calls(Type = typeof(CameraFade), Member = "GetHUD")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetConditionLabelDepth")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(CameraFade), Member = "NotifyFadeFinish")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void StartAlphaFade(Color newScreenOverlayColor, bool isFadeIn, float fadeDuration, float delay, Action OnFadeFinish)
	{
	}

	[CallerCount(Count = 0)]
	public static void SetTargetFadeScreenOverlayColor(Color newScreenOverlayColor, bool isFadeIn)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "ShouldFreezeMovement")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fade_out")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(Condition_IsCameraFadeActive), Member = "OnCheck")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CallerCount(Count = 12)]
	public static bool IsFadingOut()
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fade_in")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CalledBy(TypeFullName = "SaveGameSystem.<SaveScreenshotDataCoroutine>d__115", Member = "MoveNext")]
	[CalledBy(Type = typeof(Condition_IsCameraFadeActive), Member = "OnCheck")]
	[CallerCount(Count = 6)]
	public static bool IsFadingIn()
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnCreditsEnd")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	public static void BlackOutScreen()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	public static void ForceScreenOverlayColor(Color color)
	{
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallerCount(Count = 2)]
	public static float GetTargetAlpha()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float GetStartAlpha()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CameraFade), Member = "UpdateFade")]
	[CalledBy(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[CalledBy(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	private static Panel_HUD GetHUD()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public CameraFade()
	{
	}
}
