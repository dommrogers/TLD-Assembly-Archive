using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_GenericProgressBar : Panel_Base
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
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 5)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "SetStatusBarWidgetAlpha")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "UpdateProgressBarInterface")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Show")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Show")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFadingOutStatusBars()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ForceFadeOutComplete()
	{
	}

	[CalledBy(Type = typeof(RockCache), Member = "OnBuild")]
	[CalledBy(Type = typeof(RockCache), Member = "OnDismantle")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCallback")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "UseTool")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRefuel")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseSmashableItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OpenAndUseFoodInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DrinkFromWaterSupply")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseWaterPurificationItem")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TakeWater")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "StartFishing")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(WolfDen), Member = "OnStartFire")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	public void Launch(string name, float seconds, float minutes, float randomFailureThreshold, string audioName, string voiceName, bool supressHeavyBreathing, bool skipRestoreInHands, OnExitDelegate del)
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsUnknownMethods(Count = 1)]
	public float GetSliderValue()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "UpdateFishingTime")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	public bool IsPaused()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 5)]
	public void Pause()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	public void Resume()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ItemProgressBarCheck")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	public bool CanUserCancelAction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	private void InitializeProgressBar()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void StopProgressBarAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Cancel")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "DoClickHoldCancel")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateProgressBarInterface")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateProgressBarInterface")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "OnCancel")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(OnExitDelegate), Member = "Invoke")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	private void ProgressBarEnded(bool success, bool playerCancel)
	{
	}

	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateProgressBarInterface()
	{
	}

	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Hunger), Member = "ItemBeingEatenAffectsThirst")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Hunger), Member = "ItemBeingEatenAffectsThirst")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "AreSubtitlesVisible")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateActiveBars()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreTimeOfDay()
	{
	}

	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void AccelerateTimeOfDay(float seconds, float minutes)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 2)]
	private void ResumeAcceleratedTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 2)]
	private void PauseAcceleratedTimeOfDay()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void SetStatusBarWidgetAlpha(float alpha)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Panel_GenericProgressBar()
	{
	}
}
