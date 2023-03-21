using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.SaveState;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	public override void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "GetSliderValue")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyWaterTreatment")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Input), Member = "GetAxis")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AfflictionDiagnosed")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshStatusLabels")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshRightPage")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCAffliction), Member = "UseWater")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyWaterTreatment(float progress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsUnknownMethods(Count = 1)]
	public void DoScrollUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsUnknownMethods(Count = 1)]
	public void DoScrollDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectPrevFAKItem")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNextFAKItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SelectItem(FirstAidKitButton fakButton)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void UseSelectedItem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshRightPage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AfflictionDiagnosed")]
	[CallsUnknownMethods(Count = 1)]
	public void SelectNPCAffliction(NPCAfflictionButton affButton)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshRightPage")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshTintedImages")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RefreshAll()
	{
	}

	[CallerCount(Count = 0)]
	public bool TreatmentInProgress()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "OnDiagnoseIntroComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "DisableAfflictionButtons")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableOutline")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(BodyCarry), Member = "MaybeDrop")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[Calls(Type = typeof(StatusBar), Member = "Update")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	public void Enable(bool enable, NPC npc)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	public void OnBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "SelectItem")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectPrevFAKItem(bool playAudio = true)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckIfSelectedItemUsedUp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "SelectItem")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectNextFAKItem(bool playAudio = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public AfflictionType GetSelectedAfflictionType()
	{
		return default(AfflictionType);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshStatusLabels")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Color GetColorForStatusLine()
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "AfflictionListHasChanged")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSameAffliction(NPCAffliction afflictiona, NPCAffliction afflictionb)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSameAffliction(NPCAffliction afflictiona, NPCAfflictionButton afflictionButtonb)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCAffliction), Member = "IsTreated")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ReplaceAnimation")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void PostTreatment(NPCAffliction affliction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "ReplaceAnimation")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeReplaceExitAnimation(NPCAffliction affliction)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "MaybeReplaceExitAnimation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private void ReplaceAnimation(AssetReferenceTimeline timelineExitRef, AnimatedInteraction animatedInteraction)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableApplyTreatmentUI")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "IsWaterTreamentInProgress")]
	[Calls(Type = typeof(NPCAffliction), Member = "GetTreatmentWaterVolumeLiters")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void ApplyStandardTreatment()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsWaterTreamentInProgress()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAffliction), Member = "UseWater")]
	[Calls(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[Calls(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnTreatmentComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "IsWaterTreamentInProgress")]
	[Calls(Type = typeof(NPCAffliction), Member = "GetTreatmentWaterVolumeLiters")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 6)]
	private void ApplyAlternateTreatment()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetColorForStatusLine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshStatusLabels()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 33)]
	private void UpdateBodyIconActiveAnimation(int affLocation, AfflictionType afflictionType)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void DisableAfflictionButtons()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateBodyIconColors")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAllButSelectedBodyIconColors()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void HideRightPage()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNPCAffliction")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAlternateAfflictionsRemediesInfo")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesInfo")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanSelectAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanSelectStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private NPCAffliction GetSelectedAffliction()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void GatherStatusBars()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void HookupStatusBars()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatusBar), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateStatusBars()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesParams")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PlayerCanUseRemedy")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsUnknownMethods(Count = 2)]
	private bool PlayerHasRemedy(AfflictionRemedy remedy, AfflictionDefinition afflictionDefinition)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[CallsUnknownMethods(Count = 1)]
	private bool PlayerCanUseRemedy(NPCAffliction npcAffliction, AfflictionRemedy afflictionRemedy1, bool remedy1Complete, AfflictionRemedy afflictionRemedy2, bool remedy2Complete)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanSelectStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshSelection")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(NPCAffliction), Member = "IsTreated")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerCanUseRemedy")]
	[CallsUnknownMethods(Count = 1)]
	private bool HasStandardTreatment(NPCAffliction npcAffliction)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanSelectAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshSelection")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(NPCAffliction), Member = "IsTreated")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "PlayerCanUseRemedy")]
	[CallsUnknownMethods(Count = 1)]
	private bool HasAlternateTreatment(NPCAffliction npcAffliction)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void EnableMultipleRemedies(TreatmentUI ui, bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void EnableAlternateTreatment(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateRestUI(NPCAffliction affliction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanSelectAlternateTreatment()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanSelectStandardTreatment()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAffliction), Member = "GetWaterRequiredForTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "EnableMouseButton")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableMultipleRemedies")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateStandardTreatmentUI(NPCAffliction affliction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAffliction), Member = "GetWaterRequiredForTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "EnableMouseButton")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "EnableMultipleRemedies")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateAlternateTreatmentUI(NPCAffliction affliction)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAlternateAfflictionsRemediesInfo")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesInfo")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[CallsUnknownMethods(Count = 14)]
	private static void GetAfflictionsRemediesParams(out string[] remedySprites, out bool[] remedyComplete, out int[] remedyNumRequired, AfflictionRemedy afflictionRemedy1, AfflictionRemedy afflictionRemedy2, bool remedy1Complete, bool remedy2Complete)
	{
		remedySprites = null;
		remedyComplete = null;
		remedyNumRequired = null;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNPCAffliction")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[CallerCount(Count = 3)]
	private void RefreshRightPage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void DisableMultiAndSingleTreatmentsBG()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void EnableMultiTreatmentBG()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void EnableSingleTreatmentBG()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void EnableApplyTreatmentUI(bool canApplyTreatment)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetSelectedAffliction")]
	[Calls(Type = typeof(NPCAffliction), Member = "RequiresRemdy")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanApplyTreatment()
	{
		return false;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "EnableMouseButton")]
	[CallsUnknownMethods(Count = 1)]
	private void EnableStandardSelectionButtons(bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void DisableTreatmentSelectionObjects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshKit()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAllButSelectedBodyIconColors")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 27)]
	private void UpdateBodyIconColors(NPCAfflictionButton afflictionButton, bool isButtonSelected, int bodyIconIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void AddAfflictionAtLocation(int bodyIconIndex, AfflictionBodyArea location, AfflictionType type)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckIfSelectedAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "AddAfflictionAtLocation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetupAffliction")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateBodyIconColors")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 15)]
	private void RefreshScrollList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void CheckIfSelectedAfflictionHealed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "SelectNextFAKItem")]
	[CallsUnknownMethods(Count = 1)]
	private void CheckIfSelectedItemUsedUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "EndDiagnosing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ExitInterface()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
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

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "UpdateWaterRemedyUI")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateRemedyUI(RemedyUI ui, AfflictionRemedy remedy, bool itemNeeded, float waterNeeded, AfflictionType afflictionType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateHasTreatments(bool hasMainTreatment, bool hasAltTreatment)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool HasAnyFirstAidItem()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool AfflictionTypeNeedsRestAfterItems(AfflictionType affType)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void ClearAfflictionsAtLocationArray()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateScrollbar()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshTintedImages()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "IsSameAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void CheckForAfflictionListChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "IsSameAffliction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private bool AfflictionListHasChanged()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "AfflictionListHasChanged")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NPCAffliction), Member = "IsTreated")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void GetAllAfflictions(ref List<NPCAffliction> list)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private float GetColdPercent()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private float GetConditionPercent()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private float GetCriticalHP()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private float GetHP()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 6)]
	private void EnableOutline(NPC npc)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void EnableApplyTreatmentButton(bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 26)]
	public Panel_Diagnosis()
	{
	}
}
