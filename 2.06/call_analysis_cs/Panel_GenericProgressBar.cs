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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "SetStatusBarWidgetAlpha")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "UpdateProgressBarInterface")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	private void Update()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFadingOutStatusBars()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ForceFadeOutComplete()
	{
	}

	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DrinkFromWaterSupply")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void Launch(string name, float seconds, float minutes, float randomFailureThreshold, AK.Wwise.Event audioEvent, string voiceName, bool supressHeavyBreathing, bool skipRestoreInHands, OnExitDelegate del)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void Launch(string name, float seconds, float minutes, float randomFailureThreshold, string audioName, string voiceName, bool supressHeavyBreathing, bool skipRestoreInHands, OnExitDelegate del)
	{
	}

	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCallback")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "UseTool")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TakeWater")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseSmashableItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OpenAndUseFoodInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseWaterPurificationItem")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRefuel")]
	[CalledBy(Type = typeof(RockCache), Member = "OnDismantle")]
	[CalledBy(Type = typeof(RockCache), Member = "OnBuild")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "StartFishing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "InitializeProgressBar")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "PerformInteraction")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CalledBy(Type = typeof(WolfDen), Member = "OnStartFire")]
	private void Launch(string name, float seconds, float minutes, float randomFailureThreshold, bool skipRestoreInHands, OnExitDelegate del)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
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

	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireAudio")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public float GetSliderValue()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "UpdateFishingTime")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	public bool IsPaused()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 4)]
	public void Pause()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	public void Resume()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ItemProgressBarCheck")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	public bool CanUserCancelAction()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeProgressBar()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	private void StopProgressBarAudio()
	{
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "DoClickHoldCancel")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateProgressBarInterface")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateProgressBarInterface")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Cancel")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "OnCancel")]
	private void ProgressBarEnded(bool success, bool playerCancel)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void UpdateProgressBarInterface()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Hunger), Member = "ItemBeingEatenAffectsThirst")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "AreSubtitlesVisible")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hunger), Member = "ItemBeingEatenAffectsThirst")]
	private void UpdateActiveBars()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	private void RestoreTimeOfDay()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetStatusBarWidgetAlpha(float alpha)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public Panel_GenericProgressBar()
	{
	}
}
