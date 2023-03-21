using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Interface.PanelRequest;
using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;
using TLD.AddressableAssets;
using TLD.GameplayTags;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class Panel_Loading : Panel_AutoReferenced
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
		[CallerCount(Count = 99)]
		public HintQueueEntry(string text, string title)
		{
		}
	}

	private sealed class _003CCaptureScreenCoroutine_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private Panel_Loading _003Cloading_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 53)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 53)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCaptureScreenCoroutine_003Ed__71(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
		[CallsUnknownMethods(Count = 6)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
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

	public GameplayTag m_UseTwoSecondFadeInDelay;

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

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Actions> m_ActionsPanel;

	private PanelReference<Panel_Subtitles> m_SubtitlesPanel;

	private PanelReference<Panel_OptionsMenu> m_OptionsPanel;

	private PanelReference<Panel_Debug> m_DebugPanel;

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
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[CallsUnknownMethods(Count = 1)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(Panel_Loading), Member = "RefreshAsyncSceneLoadRecord")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetPressAnyKeyString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "CompareSceneNames")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(Panel_Loading), Member = "RefreshAsyncSceneLoadRecord")]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "ForceGC")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_Loading), Member = "SetRandomQuoteActive")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 8)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasFinishedHolding()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "CompareSceneNames")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(Panel_Loading), Member = "RefreshAsyncSceneLoadRecord")]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool HasFinishedLoading()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CCaptureScreenCoroutine_003Ed__71))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public static IEnumerator CaptureScreenCoroutine()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "ResetBackgrounds")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(GameManager), Member = "MatchesMainMenuSceneName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[Calls(Type = typeof(Panel_HUD), Member = "ClearWarningMessage")]
	[Calls(Type = typeof(Panel_Loading), Member = "FindBackgroundAndLoadingText")]
	[Calls(Type = typeof(Panel_Loading), Member = "SetLoadingScreenText")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Loading), Member = "SelectLoadingAnimation")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "InitFadeOutCapture")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetBatchAsyncPanels_Internal")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 14)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	private void FindBackgroundAndLoadingText()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private string FindChallengeOrSurvivalText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool HasFoundLoadingBackground()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool HasFoundLoadingText()
	{
		return false;
	}

	[CalledBy(Type = typeof(Action_SetLoadScreenBackgroundOrText), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoadingScreenData), Member = "GetRandomNoRepeat")]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetBackgroundData(LoadingScreenData data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoadingScreenData), Member = "GetRandomNoRepeat")]
	[CallsUnknownMethods(Count = 2)]
	public void SetTextData(LoadingScreenData data)
	{
	}

	[CallerCount(Count = 27)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_IsDone")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public bool IsLoading()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsShowingQuote")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "CanShowLocationReveal")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "IsEnabled")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(InputManager), Member = "Process")]
	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool IsShowingQuote()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnQuoteFinished()
	{
	}

	[CalledBy(Type = typeof(Action_QueueLoadScreenHint), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Loading), Member = "ShowHintLabel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void QueueHintLabel(string textLocId, string titleLocId = "")
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "QueueHintLabel")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "OnHintFinished")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ShowHintLabel(HintQueueEntry hint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Loading), Member = "ShowHintLabel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnHintFinished()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsHintQueueFull()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public void ForceCustomLoadScreen(string textLocId)
	{
	}

	[CallerCount(Count = 0)]
	public void ForceMinHoldTime(float minHoldTime)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetMinHoldTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 2)]
	public void OnScreenBackgroundTransitionFinished()
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsChallengeActive")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 16)]
	private void SetLoadingScreenText()
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 19)]
	private void SetRandomQuoteActive()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void MaybePlayAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "CompareSceneNames")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(Panel_Loading), Member = "RefreshAsyncSceneLoadRecord")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool AsyncLoadsComplete()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void SelectLoadingAnimation()
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "OnDisable")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "HasFinishedLoading")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "AsyncLoadsComplete")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneByName")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshAsyncSceneLoadRecord()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool ShouldCaptureScreen()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void StartCapture(Action OnCaptureFinish)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateCaptureForTransition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	public void DoCaptureScreen()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void CaptureStarted()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	public Panel_Loading()
	{
	}
}
