using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Diagnosis : Panel_AutoReferenced
{
	[Serializable]
	public class OutlineInfoUI
	{
		public GameObject m_GameObject;

		public NPCAfflictions.UIOutlineType m_Outline;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public OutlineInfoUI()
		{
		}
	}

	[Serializable]
	public class RemedyUI
	{
		public UITexture m_Sprite;

		public UISprite m_Checkmark;

		public UILabel m_NumLabelItemsNeeded;

		public UILabel m_DisplayName;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public RemedyUI()
		{
		}
	}

	[Serializable]
	public class TreatmentUI
	{
		public RemedyUI m_Remedy1;

		public RemedyUI m_Remedy2;

		public RemedyUI m_SingleRemedy;

		public UILabel m_LabelPlus;

		public GameObject m_Background;

		public GameObject m_ObjectSelect;

		public GameObject m_ObjectSelected;

		public GenericButtonMouseSpawner m_MouseSelectionButtonSpawner;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public TreatmentUI()
		{
		}
	}

	[Serializable]
	public class ApplyTreatmentUI
	{
		public GameObject m_ApplyTreatmentButtonsRoot;

		public UILabel m_ApplyTreatmentLabel;

		public float m_LabelDisabledAlpha;

		[NonSerialized]
		public UIButton[] m_Buttons;

		[NonSerialized]
		public float m_LabelOriginalAlpha;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ApplyTreatmentUI()
		{
		}
	}

	private class AfflictionsAtLocation
	{
		public bool[] m_AfflictionsArray;

		public AfflictionBodyArea m_Location;

		[CallerCount(Count = 0)]
		public AfflictionsAtLocation(AfflictionBodyArea location)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public void AddAffliction(AfflictionType afflictionType)
		{
		}
	}

	public GameObject m_TimeWidgetPos;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public GameObject m_ClickBlocker;

	public string m_OpenFirstAidAudio;

	public string m_CloseFirstAidAudio;

	public UILabel m_LabelConditionPercent;

	public string[] m_ColdStatusLocIDs;

	public UILabel m_ColdStatusLabel;

	public UISprite m_SpriteStatusLine;

	public Color m_GoodHealthStatusColor;

	public float m_GoodHealthThreshold;

	public Color m_FairHealthStatusColor;

	public float m_FairHealthThreshold;

	public Color m_PoorHealthStatusColor;

	public float m_PoorHealthThreshold;

	public GameObject m_RightPageHealthyObject;

	public GameObject m_RightPageObject;

	public UILabel m_LabelCause;

	public UILabel m_LabelAfflictionDescription;

	public UILabel m_LabelAfflictionDescriptionNoRest;

	public UITexture[] m_SpriteListItemsNeeded;

	public UISprite[] m_CheckmarksItemsNeeded;

	public UILabel[] m_NumLabelItemsNeeded;

	public UILabel m_LabelWaterAmount;

	public UILabel m_altLabelWaterAmount;

	public Vector2 m_WaterAmountPixelOffset;

	public GameObject m_ObjectRestRemaining;

	public UILabel m_LabelRestRemaining;

	public UILabel m_LabelRestRequired;

	public UILabel[] m_LabelPlus;

	public GameObject m_ItemsNeededOnlyOneObj;

	public GameObject m_ItemsNeededMultipleObj;

	public GameObject m_TreatAfflictionObj;

	public GameObject m_SingleTreatmentBG;

	public GameObject m_MultipleTreatmentsBG;

	public TreatmentUI m_StandardTreatment;

	public TreatmentUI m_AlternateTreatment;

	public ScrollList m_ScrollListEffects;

	public GameObject m_ScrollbarObject;

	public GameObject m_SpecialTreatmentWindow;

	public UILabel m_LabelAfflictionName;

	public UILabel m_LabelSpecialTreatment;

	public UILabel m_LabelSpecialTreatmentDescription;

	public GameObject m_BuffWindow;

	public UISprite[] m_BodyIconList;

	public GameObject m_BodyIconActiveAnimationObj;

	public string m_BodyIconSpriteNameAffliction;

	public GameObject m_MultipleDosesObject;

	public GameObject m_ButtonBack;

	public Color m_ColorAffliction;

	public Color m_ColorNormal;

	public UISprite[] m_TintedSprites;

	public GameObject m_TreatmentButtonSingle;

	public GameObject m_TreatmentButtonMultiLeft;

	public GameObject m_TreatmentButtonMultiRight;

	public GameObject m_TreatmentSwapIndictorLeft;

	public GameObject m_TreatmentSwapIndictorRight;

	public UIWidget m_TreatmentWidgetSingle;

	public UIWidget m_TreatmentWidgetMultiLeft;

	public UIWidget m_TreatmentWidgetMultiRight;

	public UISprite m_TreatmentBorderSingle;

	public UISprite m_TreatmentBorderMultiLeft;

	public UISprite m_TreatmentBorderMultiRight;

	public UILabel m_TreatmentDontHaveItemsLabel;

	public UILabel m_UsedAntibioticsAlreadyLabel;

	public GameObject m_DoingTreatmentOverlay;

	public float m_DoingTreatmentAlpha;

	public float m_HasTreatmentAlpha;

	public float m_MissingTreatmentAlpha;

	public GameObject m_DurationWidgetParentObj;

	public UILabel m_DurationWidgetHoursLabel;

	public UILabel m_DurationWidgetMinutesLabel;

	public UISprite m_SelectStandardGamepadButtonSprite;

	public UISprite m_SelectAlternateGamepadButtonSprite;

	public List<OutlineInfoUI> m_OutlineInfos;

	public ApplyTreatmentUI m_ApplyTreatmentUI;

	private FirstAidKitButton[] m_FakButtons;

	private FirstAidKitButton m_SelectedFAKButton;

	private NPCAfflictionButton m_SelectedAffButton;

	public string m_TreatmentSuccessVO;

	private PanelReference<Panel_Clothing> m_Clothing;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private int m_BodyIconWidthOriginal;

	private int m_BodyIconHeightOriginal;

	private bool m_DoneFirstUpdate;

	private uint m_OpenCloseAudioID;

	private string m_ItemJustUsed;

	private List<NPCAffliction> m_AfflictionsLastFrame;

	private List<NPCAffliction> m_AfflictionsThisFrame;

	private List<FirstAidKitButton> m_FakList;

	private AfflictionsAtLocation[] m_AfflictionsAtLocationArray;

	private NPCStatusBar[] m_SatusBars;

	private NPC m_NPCComponent;

	private NPCAffliction m_AfflictionTreatedInProgress;

	private bool m_IsTreatmentInProgressSandard;

	private float m_TreatmentTotalWaterVolumeLiters;

	private bool m_IsWaterTreatmentInProgress;

	private float m_CurrentWaterTreatmentVolumeUsedLiters;

	private List<NPCAffliction> m_ScrollListAfflictions;

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AfflictionDiagnosed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshStatusLabels")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateScrollbar")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Input), Member = "GetAxis")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Input), Member = "GetAxis")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshRightPage")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "GetSliderValue")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyWaterTreatment")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCAffliction), Member = "UseWater")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	private void ApplyWaterTreatment(float progress)
	{
	}

	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void DoScrollUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsUnknownMethods(Count = 1)]
	public void DoScrollDown()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnScrollbarChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 1)]
	public void UseItem(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNextFAKItem")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectPrevFAKItem")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	public void SelectItem(FirstAidKitButton fakButton)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void UseSelectedItem()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AfflictionDiagnosed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshRightPage")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SelectNPCAffliction(NPCAfflictionButton affButton)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshTintedImages")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshRightPage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	public void RefreshAll()
	{
	}

	[CallerCount(Count = 0)]
	public bool TreatmentInProgress()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "OnDiagnoseIntroComplete")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(StatusBar), Member = "Update")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableOutline")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(BodyCarry), Member = "MaybeDrop")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "DisableAfflictionButtons")]
	public void Enable(bool enable, NPC npc)
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void OnBack()
	{
	}

	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "SelectItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void SelectPrevFAKItem(bool playAudio = true)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "SelectItem")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckIfSelectedItemUsedUp")]
	public void SelectNextFAKItem(bool playAudio = true)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public AfflictionType GetSelectedAfflictionType()
	{
		return default(AfflictionType);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshStatusLabels")]
	[CallsUnknownMethods(Count = 1)]
	public Color GetColorForStatusLine()
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSameAffliction(NPCAffliction afflictiona, NPCAffliction afflictionb)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSameAffliction(NPCAffliction afflictiona, NPCAfflictionButton afflictionButtonb)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[Calls(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPCAffliction), Member = "IsTreated")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ReplaceAnimation")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ReplaceAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PostTreatment(NPCAffliction affliction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ReplaceAnimation")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ReplaceAnimation")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeReplaceExitAnimation(NPCAffliction affliction)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "MaybeReplaceExitAnimation")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "MaybeReplaceExitAnimation")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	private void ReplaceAnimation(AssetReferenceTimeline timelineExitRef, AnimatedInteraction animatedInteraction)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[Calls(Type = typeof(NPCAffliction), Member = "GetTreatmentWaterVolumeLiters")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableApplyTreatmentUI")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ApplyStandardTreatment()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsWaterTreamentInProgress()
	{
		return default(bool);
	}

	[Calls(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[Calls(Type = typeof(NPCAffliction), Member = "UseWater")]
	[Calls(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	private void OnTreatmentComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Calls(Type = typeof(NPCAffliction), Member = "GetTreatmentWaterVolumeLiters")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void ApplyAlternateTreatment()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetColorForStatusLine")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void RefreshStatusLabels()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsUnknownMethods(Count = 22)]
	private void UpdateBodyIconActiveAnimation(int affLocation, AfflictionType afflictionType)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void DisableAfflictionButtons()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateBodyIconColors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAllButSelectedBodyIconColors()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void HideRightPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanSelectAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanSelectStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesInfo")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAlternateAfflictionsRemediesInfo")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNPCAffliction")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	private NPCAffliction GetSelectedAffliction()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void GatherStatusBars()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void HookupStatusBars()
	{
	}

	[Calls(Type = typeof(StatusBar), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void UpdateStatusBars()
	{
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesParams")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	private void GetAlternateAfflictionsRemediesInfo(out string[] altRemedySprites, out bool[] altRemedyComplete, out int[] altRemedyNumRequired)
	{
		altRemedySprites = null;
		altRemedyComplete = null;
		altRemedyNumRequired = null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesParams")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[CallerCount(Count = 0)]
	private void GetAfflictionsRemediesInfo(out string[] remedySprites, out bool[] remedyComplete, out int[] remedyNumRequired)
	{
		remedySprites = null;
		remedyComplete = null;
		remedyNumRequired = null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PlayerCanUseRemedy")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PlayerCanUseRemedy")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	private bool PlayerHasRemedy(AfflictionRemedy remedy, AfflictionDefinition afflictionDefinition)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	private bool PlayerCanUseRemedy(NPCAffliction npcAffliction, AfflictionRemedy afflictionRemedy1, bool remedy1Complete, AfflictionRemedy afflictionRemedy2, bool remedy2Complete)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshSelection")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanSelectStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[Calls(Type = typeof(NPCAffliction), Member = "IsTreated")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	private bool HasStandardTreatment(NPCAffliction npcAffliction)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshSelection")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(NPCAffliction), Member = "IsTreated")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanSelectAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	private bool HasAlternateTreatment(NPCAffliction npcAffliction)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	private void EnableMultipleRemedies(TreatmentUI ui, bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void EnableAlternateTreatment(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateRestUI(NPCAffliction affliction)
	{
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[CallerCount(Count = 0)]
	private bool CanSelectAlternateTreatment()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanSelectStandardTreatment()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "EnableMouseButton")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableMultipleRemedies")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableMultipleRemedies")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(NPCAffliction), Member = "GetWaterRequiredForTreatment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateStandardTreatmentUI(NPCAffliction affliction)
	{
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableMultipleRemedies")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableMultipleRemedies")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(NPCAffliction), Member = "GetWaterRequiredForTreatment")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "EnableMouseButton")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	private void UpdateAlternateTreatmentUI(NPCAffliction affliction)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAlternateAfflictionsRemediesInfo")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesInfo")]
	[CallsUnknownMethods(Count = 14)]
	private static void GetAfflictionsRemediesParams(out string[] remedySprites, out bool[] remedyComplete, out int[] remedyNumRequired, AfflictionRemedy afflictionRemedy1, AfflictionRemedy afflictionRemedy2, bool remedy1Complete, bool remedy2Complete)
	{
		remedySprites = null;
		remedyComplete = null;
		remedyNumRequired = null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNPCAffliction")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	private void RefreshRightPage()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void DisableMultiAndSingleTreatmentsBG()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void EnableMultiTreatmentBG()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private void EnableSingleTreatmentBG()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CallerCount(Count = 1)]
	private void EnableApplyTreatmentUI(bool canApplyTreatment)
	{
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(NPCAffliction), Member = "RequiresRemdy")]
	private bool CanApplyTreatment()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	private void RefreshSelection(NPCAffliction npcAffliction)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "EnableMouseButton")]
	private void EnableAlternateSelectionButtons(bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "EnableMouseButton")]
	[CallsUnknownMethods(Count = 1)]
	private void EnableStandardSelectionButtons(bool isEnabled)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void DisableTreatmentSelectionObjects()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	private void RefreshKit()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAllButSelectedBodyIconColors")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateBodyIconColors(NPCAfflictionButton afflictionButton, bool isButtonSelected, int bodyIconIndex)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 5)]
	private void AddAfflictionAtLocation(int bodyIconIndex, AfflictionBodyArea location, AfflictionType type)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckIfSelectedAfflictionHealed")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateBodyIconColors")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetupAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "AddAfflictionAtLocation")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 5)]
	private void RefreshScrollList()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	private void CheckIfSelectedAfflictionHealed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "SelectNextFAKItem")]
	[CallsUnknownMethods(Count = 1)]
	private void CheckIfSelectedItemUsedUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnBack")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	private void ExitInterface()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	public void UpdateWaterRemedyUI(float waterNeeded, RemedyUI ui, AfflictionType afflictionType)
	{
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[CallerCount(Count = 0)]
	public void SelectStandardTreatment()
	{
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[CallerCount(Count = 0)]
	public void SelectAlternateTreatment()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyTreatment()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateWaterRemedyUI")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateRemedyUI(RemedyUI ui, AfflictionRemedy remedy, bool itemNeeded, float waterNeeded, AfflictionType afflictionType)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateHasTreatments(bool hasMainTreatment, bool hasAltTreatment)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool HasAnyFirstAidItem()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool AfflictionTypeNeedsRestAfterItems(AfflictionType affType)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void ClearAfflictionsAtLocationArray()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateScrollbar()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshTintedImages()
	{
	}

	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	private void CheckForAfflictionListChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[CallsUnknownMethods(Count = 3)]
	private bool AfflictionListHasChanged()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "AfflictionListHasChanged")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NPCAffliction), Member = "IsTreated")]
	private void GetAllAfflictions(ref List<NPCAffliction> list)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private float GetColdPercent()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetConditionPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private float GetCriticalHP()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private float GetHP()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void EnableOutline(NPC npc)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void EnableApplyTreatmentButton(bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_Diagnosis()
	{
	}
}
