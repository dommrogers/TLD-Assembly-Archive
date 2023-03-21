using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_GenericProgressBar : Panel_AutoReferenced
{
	public ButtonLegendContainer m_ButtonLegendContainer;

	public OnExitDelegate m_handler;

	public Color m_FailedColor;

	public UISprite m_SpriteForground;

	public Transform m_CenterLocation;

	public Transform m_GearItemLocation;

	public GameObject m_EatingObjects;

	public GameObject m_DrinkingObjects;

	public UIWidget m_StatusBarWidget;

	public float m_StatusBarFadeTime;

	public UISlider m_Slider;

	public UIWidget m_SubtitleAltStatusBarWidget;

	public GameObject m_SubtitleAltEatingObjects;

	public GameObject m_SubtitleAltDrinkingObjects;

	private PanelReference<Panel_Diagnosis> m_Diagnosis;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	private PanelReference<Panel_Repair> m_Repair;

	private PanelReference<Panel_Subtitles> m_Subtitles;

	private Color m_OriginalColor;

	private float m_RandomFailureThreshold;

	private float m_ProgressBarDurationSeconds;

	private float m_ProgressBarElapsedSeconds;

	private bool m_DisplayFailMessage;

	private float m_DisplayFailMessageTime;

	private float m_DisplayFailMessageLifetime;

	private uint m_AudioID;

	private uint m_VoiceID;

	private bool m_SkipRestoreInHands;

	private bool m_TimeAccelerated;

	private float m_DayLengthScaleOriginal;

	private float m_DayLengthScaleAccelerated;

	private UILabel m_ProgressBarNameLabel;

	private float m_StatusBarFadeTimeRemaining;

	private bool m_ShowedHungerThisCycle;

	private bool m_ShowedThirstThisCycle;

	private bool m_MarkForCancel;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "UpdateProgressBarInterface")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "SetStatusBarWidgetAlpha")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFadingOutStatusBars()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ForceFadeOutComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Launch(string name, float seconds, float minutes, float randomFailureThreshold, AK.Wwise.Event audioEvent, string voiceName, bool supressHeavyBreathing, bool skipRestoreInHands, OnExitDelegate del)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	public void Launch(string name, float seconds, float minutes, float randomFailureThreshold, string audioName, string voiceName, bool supressHeavyBreathing, bool skipRestoreInHands, OnExitDelegate del)
	{
	}

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "InitializeProgressBar")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Launch(string name, float seconds, float minutes, float randomFailureThreshold, bool skipRestoreInHands, OnExitDelegate del)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void PlayAudio(AK.Wwise.Event audioEvent, string voiceName, bool supressHeavyBreathing)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	private void PlayAudio(string audioName, string voiceName, bool supressHeavyBreathing)
	{
	}

	[CallerCount(Count = 0)]
	public void MarkForCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Cancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void SetNameLabel(string name)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetSliderValue()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "UpdateFishingTime")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsPaused()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void Pause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void Resume()
	{
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ItemProgressBarCheck")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanUserCancelAction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeProgressBar()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopProgressBarAudio()
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Cancel")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateProgressBarInterface")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "DoClickHoldCancel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ProgressBarEnded(bool success, bool playerCancel)
	{
	}

	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateProgressBarInterface()
	{
	}

	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "AreSubtitlesVisible")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Hunger), Member = "ItemBeingEatenAffectsThirst")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 15)]
	private void UpdateActiveBars()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsUnknownMethods(Count = 1)]
	private void AccelerateTimeOfDay(float seconds, float minutes)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 2)]
	private void ResumeAcceleratedTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 2)]
	private void PauseAcceleratedTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void SetStatusBarWidgetAlpha(float alpha)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_GenericProgressBar()
	{
	}
}
