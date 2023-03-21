using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Interface.PanelRequest;
using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using SpecialEvents;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel_Loading : Panel_Base
{
	public enum LoadingAnimationSelection
	{
		Random,
		Linear,
		Static
	}

	public struct HintQueueEntry
	{
		public string Text;

		public string Title;

		[DeduplicatedMethod]
		[CallerCount(Count = 67)]
		public HintQueueEntry(string text, string title)
		{
		}
	}

	private sealed class _003CCaptureScreenCoroutine_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCaptureScreenCoroutine_003Ed__65(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
		[CallsUnknownMethods(Count = 14)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private const int DELAY_HIDE_PANEL_FRAMES = 8;

	public static bool s_Debug;

	public GameObject m_HintsBackgroundParent;

	public UISprite m_Background;

	public UILabel m_SceneLabel;

	public UILabel m_GameModeLabel;

	public UILabel m_ContinueLabel;

	public GameObject m_Quotes;

	public GameObject m_Animations;

	public float m_FadeDurationSeconds;

	public string m_Audio;

	public UITexture m_BackgroundTexture;

	public TLDBehaviourTreeOwner m_LoadingScreenBehaviourTree;

	public UILabel m_CustomLoadScreenLabel;

	public GameObject m_NonCustomElements;

	public UILabel m_DebugText;

	private float m_QuoteFadeFromBlackTime;

	private float m_QuoteVisibleOnScreenAfterFadeInStarts;

	public Action m_CallbackAfterLoad;

	public bool m_ShowQuoteAfterLoad;

	public bool m_HoldScreenAfterLoad;

	public bool m_HoldFadeAfterLoad;

	public string m_CommandToRunAfterLoad;

	public bool m_SaveAfterLoad;

	public LoadingScreenInfo m_Info;

	public UILabel m_Label_Hint;

	public UILabel m_Label_HintTitle;

	public TLDBehaviourTreeOwner m_HintsBehaviourTree;

	public int m_HintQueueMaxSize;

	public UIPanel m_NowhereToHideGroup;

	private ILoadPanelRequest m_LoadPanelRequest;

	private bool m_ShowHints;

	private float m_LabelLoadingAlpha;

	private float m_LabelContinueAlpha;

	private float m_BackgroundTextureAlpha;

	private float m_MinHoldTime;

	private bool m_ContinueToGame;

	private uint m_AudioID;

	private UILabel m_ActiveQuoteLabel;

	private float m_StartLoadingTimeSeconds;

	private bool m_HasLoggedLoadingTime;

	private float m_DelayHideUntilFrame;

	private bool m_LoadingMainMenu;

	private LoadingAnimation[] m_LoadingAnimations;

	private GameObject m_CurrentLoadingAnimation;

	private int m_CurrentLoadingAnimationIndex;

	private LoadingAnimationSelection m_LoadingAnimationSelection;

	private LoadingScreenData m_BackgroundData;

	private LoadingScreenData m_TextData;

	private string m_BackgroundSprite;

	private string m_LoadScreenTextLocID;

	private List<HintQueueEntry> m_HintQueue;

	private int m_HintIndex;

	private string m_CustomLoadScreenLocID;

	private CaptureScreenTransition m_captureTransition;

	public static bool m_EnableCaptureScreenTransition;

	private static List<string> m_AsyncScenesRemoveList;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsUnknownMethods(Count = 1)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(Panel_Loading), Member = "RefreshAsyncSceneLoadRecord")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_Loading), Member = "SetRandomQuoteActive")]
	[Calls(Type = typeof(GameManager), Member = "ForceGC")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(Utils), Member = "GetPressAnyKeyString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "OnUpdate")]
	[Calls(Type = typeof(Panel_Loading), Member = "HasFinishedLoading")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "ForceGC")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasFinishedHolding()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[Calls(Type = typeof(Panel_Loading), Member = "RefreshAsyncSceneLoadRecord")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	private bool HasFinishedLoading()
	{
		return default(bool);
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static IEnumerator CaptureScreenCoroutine()
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "SetBackgroundAlpha")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "InitBackgroundTweenAlpha")]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Loading), Member = "SelectLoadingAnimation")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Panel_Loading), Member = "ForceCustomLoadScreen")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanelsAsync")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsUnknownMethods(Count = 43)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[Calls(Type = typeof(Panel_Loading), Member = "FindBackgroundAndLoadingText")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "ResetBackgrounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "RegisterAnySpawnWildlifeGuid")]
	[Calls(Type = typeof(SnowShelterManager), Member = "RegisterAnySnowShelterGuid")]
	[Calls(Type = typeof(LeanToManager), Member = "RegisterAnyLeanToGuid")]
	[Calls(Type = typeof(RockCacheManager), Member = "RegisterAnyRockCacheGuid")]
	[Calls(Type = typeof(Panel_Loading), Member = "SetLoadingScreenText")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(MissionServicesManager), Member = "PostSceneLoadCo")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "ResetBackgrounds")]
	[Calls(Type = typeof(LightingManager), Member = "RemoveAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[Calls(Type = typeof(Panel_HUD), Member = "ClearWarningMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void FindBackgroundAndLoadingText()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private string FindChallengeOrSurvivalText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool HasFoundLoadingBackground()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool HasFoundLoadingText()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(LoadingScreenData), Member = "GetRandomNoRepeat")]
	[Calls(Type = typeof(Utils), Member = "GetLoadingBackgroundTexture")]
	[CalledBy(Type = typeof(Action_SetLoadScreenBackgroundOrText), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 7)]
	public void SetBackgroundData(LoadingScreenData data)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LoadingScreenData), Member = "GetRandomNoRepeat")]
	[CalledBy(Type = typeof(Action_SetLoadScreenBackgroundOrText), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 7)]
	public void SetTextData(LoadingScreenData data)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(AsyncOperation), Member = "get_isDone")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	public bool IsLoading()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsShowingQuote")]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "CanShowLocationReveal")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "IsEnabled")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(InputManager), Member = "Process")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsShowingQuote()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnQuoteFinished()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsHintQueueFull")]
	[Calls(Type = typeof(Panel_Loading), Member = "ShowHintLabel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Action_QueueLoadScreenHint), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 7)]
	public void QueueHintLabel(string textLocId, string titleLocId = "")
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "OnHintFinished")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "QueueHintLabel")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void ShowHintLabel(HintQueueEntry hint)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Loading), Member = "ShowHintLabel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnHintFinished()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition_HintQueueFull), Member = "OnCheck")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "QueueHintLabel")]
	public bool IsHintQueueFull()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	public void ForceCustomLoadScreen(string textLocId)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_ForceCustomLoadScreen), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetLoadScreenBackgroundOrText), Member = "OnExecute")]
	public void ForceMinHoldTime(float minHoldTime)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetMinHoldTime()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	public void OnScreenBackgroundTransitionFinished()
	{
	}

	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsChallengeActive")]
	private void SetLoadingScreenText()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CallsUnknownMethods(Count = 36)]
	private void SetRandomQuoteActive()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void MaybePlayAudio()
	{
	}

	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Loading), Member = "RefreshAsyncSceneLoadRecord")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	private bool AsyncLoadsComplete()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public LoadingAnimation[] GetPossibleLoadingAnimations()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetLoadingAnimationSelection(LoadingAnimationSelection selection, int index = -1)
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	private void SelectLoadingAnimation()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "AsyncLoadsComplete")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "HasFinishedLoading")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "OnDisable")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneByName")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void RefreshAsyncSceneLoadRecord()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool ShouldCaptureScreen()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void StartCapture(Action OnCaptureFinish)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateCaptureForTransition()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 4)]
	public void DoCaptureScreen()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void CaptureStarted()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 19)]
	public Panel_Loading()
	{
	}
}
