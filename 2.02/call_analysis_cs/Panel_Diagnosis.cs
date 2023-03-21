using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Diagnosis : Panel_Base
{
	[Serializable]
	public class OutlineInfoUI
	{
		public GameObject m_GameObject;

		public NPCAfflictions.UIOutlineType m_Outline;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 2)]
		public ApplyTreatmentUI()
		{
		}
	}

	private class AfflictionsAtLocation
	{
		public bool[] m_AfflictionsArray;

		public AfflictionBodyArea m_Location;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public AfflictionsAtLocation(AfflictionBodyArea location)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Input), Member = "GetAxis")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AfflictionDiagnosed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshRightPage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 100)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateScrollbar")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshStatusLabels")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[Calls(Type = typeof(Input), Member = "GetAxis")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyWaterTreatment")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
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

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void OnScrollbarChange()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 7)]
	public void UseItem(GearItem gi)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNextFAKItem")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectPrevFAKItem")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshKit")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	public void SelectItem(FirstAidKitButton fakButton)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void UseSelectedItem()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AfflictionDiagnosed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshRightPage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SelectNPCAffliction(NPCAfflictionButton affButton)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshTintedImages")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshKit")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshRightPage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
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
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "CanPlaySpecialUIEntrySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "OnDiagnoseIntroComplete")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(StatusBar), Member = "Update")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableOutline")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(BodyCarry), Member = "MaybeDrop")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "DisableAfflictionButtons")]
	public void Enable(bool enable, NPC npc)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	public void OnBack()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "SelectItem")]
	public void SelectPrevFAKItem(bool playAudio = true)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckIfSelectedItemUsedUp")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "SelectItem")]
	public void SelectNextFAKItem(bool playAudio = true)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public AfflictionType GetSelectedAfflictionType()
	{
		return default(AfflictionType);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Color GetColorForStatusLine()
	{
		return default(Color);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "AfflictionListHasChanged")]
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

	[Calls(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[Calls(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ReplaceAnimation")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ReplaceAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAffliction), Member = "IsTreated")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PostTreatment(NPCAffliction affliction)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ReplaceAnimation")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ReplaceAnimation")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeReplaceExitAnimation(NPCAffliction affliction)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "MaybeReplaceExitAnimation")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "MaybeReplaceExitAnimation")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	private void ReplaceAnimation(TimelineRef timelineExitRef, AnimatedInteraction animatedInteraction)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(NPCAffliction), Member = "GetTreatmentWaterVolumeLiters")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "IsWaterTreamentInProgress")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableApplyTreatmentUI")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void ApplyStandardTreatment()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsWaterTreamentInProgress()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[Calls(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[Calls(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[Calls(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(NPCAffliction), Member = "UseWater")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	private void OnTreatmentComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(NPCAffliction), Member = "GetTreatmentWaterVolumeLiters")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "IsWaterTreamentInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	private void ApplyAlternateTreatment()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void RefreshStatusLabels()
	{
	}

	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	private void UpdateBodyIconActiveAnimation(int affLocation, AfflictionType afflictionType)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DisableAfflictionButtons()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateBodyIconColors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateAllButSelectedBodyIconColors()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	private void HideRightPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanSelectAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAlternateAfflictionsRemediesInfo")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesInfo")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanSelectStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNPCAffliction")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	private NPCAffliction GetSelectedAffliction()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void GatherStatusBars()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void HookupStatusBars()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatusBar), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateStatusBars()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesParams")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[CallerCount(Count = 0)]
	private void GetAlternateAfflictionsRemediesInfo(out string[] altRemedySprites, out bool[] altRemedyComplete, out int[] altRemedyNumRequired)
	{
		altRemedySprites = null;
		altRemedyComplete = null;
		altRemedyNumRequired = null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesParams")]
	[CallsUnknownMethods(Count = 1)]
	private void GetAfflictionsRemediesInfo(out string[] remedySprites, out bool[] remedyComplete, out int[] remedyNumRequired)
	{
		remedySprites = null;
		remedyComplete = null;
		remedyNumRequired = null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PlayerCanUseRemedy")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PlayerCanUseRemedy")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool PlayerHasRemedy(AfflictionRemedy remedy, AfflictionDefinition afflictionDefinition)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	private bool PlayerCanUseRemedy(NPCAffliction npcAffliction, AfflictionRemedy afflictionRemedy1, bool remedy1Complete, AfflictionRemedy afflictionRemedy2, bool remedy2Complete)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshSelection")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanSelectStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerCanUseRemedy")]
	[Calls(Type = typeof(NPCAffliction), Member = "IsTreated")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	private bool HasStandardTreatment(NPCAffliction npcAffliction)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshSelection")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanSelectAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerCanUseRemedy")]
	[Calls(Type = typeof(NPCAffliction), Member = "IsTreated")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	private bool HasAlternateTreatment(NPCAffliction npcAffliction)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	private void EnableMultipleRemedies(TreatmentUI ui, bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void EnableAlternateTreatment(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	private void UpdateRestUI(NPCAffliction affliction)
	{
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
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

	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableMultipleRemedies")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableMultipleRemedies")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "EnableMouseButton")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(NPCAffliction), Member = "GetWaterRequiredForTreatment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateStandardTreatmentUI(NPCAffliction affliction)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableMultipleRemedies")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "EnableMouseButton")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableMultipleRemedies")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(NPCAffliction), Member = "GetWaterRequiredForTreatment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateAlternateTreatmentUI(NPCAffliction affliction)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAlternateAfflictionsRemediesInfo")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesInfo")]
	[CallsUnknownMethods(Count = 33)]
	private static void GetAfflictionsRemediesParams(out string[] remedySprites, out bool[] remedyComplete, out int[] remedyNumRequired, AfflictionRemedy afflictionRemedy1, AfflictionRemedy afflictionRemedy2, bool remedy1Complete, bool remedy2Complete)
	{
		remedySprites = null;
		remedyComplete = null;
		remedyNumRequired = null;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNPCAffliction")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallerCount(Count = 3)]
	[CallAnalysisFailed]
	private void RefreshRightPage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	private void DisableMultiAndSingleTreatmentsBG()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	private void EnableMultiTreatmentBG()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void EnableSingleTreatmentBG()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CallsUnknownMethods(Count = 2)]
	private void EnableApplyTreatmentUI(bool canApplyTreatment)
	{
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(NPCAffliction), Member = "RequiresRemdy")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	private bool CanApplyTreatment()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshSelection(NPCAffliction npcAffliction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "EnableMouseButton")]
	[CallsUnknownMethods(Count = 1)]
	private void EnableAlternateSelectionButtons(bool isEnabled)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "EnableMouseButton")]
	[CallerCount(Count = 0)]
	private void EnableStandardSelectionButtons(bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void DisableTreatmentSelectionObjects()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectItem")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshKit()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAllButSelectedBodyIconColors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	private void UpdateBodyIconColors(NPCAfflictionButton afflictionButton, bool isButtonSelected, int bodyIconIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 19)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void AddAfflictionAtLocation(int bodyIconIndex, AfflictionBodyArea location, AfflictionType type)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckIfSelectedAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateBodyIconColors")]
	[CallsUnknownMethods(Count = 60)]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetupAffliction")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "AddAfflictionAtLocation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	private void RefreshScrollList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 11)]
	private void CheckIfSelectedAfflictionHealed()
	{
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "SelectNextFAKItem")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void CheckIfSelectedItemUsedUp()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(NPCAfflictions), Member = "EndDiagnosing")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnBack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ExitInterface()
	{
	}

	[CallsUnknownMethods(Count = 45)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void UpdateWaterRemedyUI(float waterNeeded, RemedyUI ui, AfflictionType afflictionType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	public void SelectStandardTreatment()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	public void SelectAlternateTreatment()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	public void ApplyTreatment()
	{
	}

	[Calls(Type = typeof(AfflictionRemedy), Member = "GetDisplayName")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateWaterRemedyUI")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void UpdateRemedyUI(RemedyUI ui, AfflictionRemedy remedy, bool itemNeeded, float waterNeeded, AfflictionType afflictionType)
	{
	}

	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	private void UpdateHasTreatments(bool hasMainTreatment, bool hasAltTreatment)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void ClearAfflictionsAtLocationArray()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateScrollbar()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[CallsUnknownMethods(Count = 14)]
	private void RefreshTintedImages()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "AfflictionListHasChanged")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	private void CheckForAfflictionListChange()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "IsSameAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	private bool AfflictionListHasChanged()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "AfflictionListHasChanged")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[Calls(Type = typeof(NPCAffliction), Member = "IsTreated")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void GetAllAfflictions(ref List<NPCAffliction> list)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private float GetColdPercent()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetConditionPercent()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private float GetCriticalHP()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private float GetHP()
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void EnableOutline(NPC npc)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 13)]
	private void EnableApplyTreatmentButton(bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 35)]
	public Panel_Diagnosis()
	{
	}
}
