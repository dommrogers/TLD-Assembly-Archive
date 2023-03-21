using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;

public class Panel_ActionsRadial : Panel_AutoReferenced, INotificationHandler
{
	public enum RadialType
	{
		LightSources,
		Weapons,
		Bedroll,
		Fire,
		Journal,
		Inventory,
		Decoy,
		FirstAid,
		PlaceItem,
		Clothing,
		Tools,
		Crafting,
		Empty,
		EmergencyStim,
		SnowShelter,
		PassTime,
		GoToRadial,
		EmptySatchelSlot,
		Status,
		Food,
		Drink,
		Navigation,
		Map,
		Shelter,
		LeanTo,
		LeanToNoCampfire,
		SprayPaint,
		RockCache,
		NoiseMaker
	}

	[Serializable]
	public class RadialInfo
	{
		public RadialType m_RadialElement;

		public string m_SpriteName;

		public string m_SpriteNameHover;

		public Vector2 m_PixelSize;

		public string m_GreyOutSpriteName;

		public Vector2 m_GreyOutPixelSize;

		public Color m_IconActiveColor;

		public Color m_IconActiveHoverColor;

		[CallerCount(Count = 0)]
		public RadialInfo()
		{
		}
	}

	public delegate void RadialGearDelegate(GearItem gi);

	public GameObject m_TimeWidgetPos;

	public GearItem m_GearItemAddToSatchel;

	public RadialMenuArm m_RadialArmThatDidInvoke;

	public float m_SecondsToLockControlsAfter;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public GameObject m_NonAnimatingObjects;

	public UISpriteAnimation m_BackpieceAnim;

	public UISpriteAnimation m_BackpieceAnimOut;

	public UISprite m_FadeOverlaySprite;

	public float m_FadeOverlayMaxAlpha;

	public int m_NumFramesToFadeInOut;

	public bool m_DisableStatusBarsDuringFadeOut;

	public float m_CenterButtonRadius;

	public TweenScale m_TweenScale;

	public RadialMenuArm[] m_RadialArms;

	public RadialInfo[] m_PrimaryRadial;

	public RadialInfo m_FireRadialInfo;

	public RadialInfo m_PassTimeRadialInfo;

	public RadialInfo m_SnowShelterRadialInfo;

	public RadialInfo m_LeanToRadialInfo;

	public RadialInfo m_LeanToNoCampfireRadialInfo;

	public RadialInfo m_ShelterRadialInfo;

	public RadialInfo m_DecoyRadialInfo;

	public RadialInfo m_OpenMapRadialInfo;

	public RadialInfo m_SprayPaintRadialInfo;

	public string m_NowhereToHideSprayPaintCanSprite;

	public RadialInfo m_OpenRockCacheRadialInfo;

	public Color m_SectionColorUnselected;

	public Color m_SectionColorSelected;

	public Color m_SectionColorEmpty;

	public Color m_SectionColorEmptySelected;

	public Color m_IconColorGreyedOut;

	public Color m_GearIconColorGreyedOut;

	public Color m_SubRadialBackButtonSelected;

	public Color m_SubRadialBackButtonUnselected;

	public UILabel m_SegmentLabel;

	public UILabel m_CurrentTimeLabel;

	public string[] m_LightSourceRadialOrder;

	public string[] m_WeaponRadialOrder;

	public string[] m_PlaceItemRadialOrder;

	public string[] m_NavigationRadialOrder;

	public string[] m_ShelterRadialOrder;

	public string[] m_ToolsRadialOrder;

	public AK.Wwise.Event m_ClickAudio;

	public AK.Wwise.Event m_BackAudio;

	public AK.Wwise.Event m_OpenAudio;

	public AK.Wwise.Event m_CloseAudio;

	public StatusBar m_ColdStatusBar;

	public GameObject m_GearStatsObject;

	public GameObject m_GearConditionObject;

	public UISprite m_GearConditionSprite;

	public UILabel m_GearConditionLabel;

	public GameObject m_GearConditionCenteredObject;

	public UISprite m_GearConditionCenteredSprite;

	public UILabel m_GearConditionCenteredLabel;

	public UISprite m_StackStatusIcon;

	public UISprite m_StackStatusIconShadow;

	public UILabel m_StackStatusLabel;

	public Color m_StackStatusColor;

	public string m_LiquidIcon;

	public string m_LampFuelIcon;

	public UISprite m_HotColdStatusIcon;

	public UISprite m_HotColdStatusIconShadow;

	public UILabel m_HotColdStatusLabel;

	public string m_FoodHotStatusIcon;

	public Color m_FoodHotStatusColor;

	public string m_FoodColdStatusIcon;

	public Color m_FoodColdStatusColor;

	public UILabel m_MissionObjectiveLabel;

	public UILabel m_MissionObjectiveWithTimerLabel;

	public UILabel m_MissionTimerLabel;

	public GameObject m_MissionObjectWithTimer;

	public GameObject m_MissionObjectNoTimer;

	public GameObject m_MissionObjectivePanel;

	public UILabel m_ObjectiveStatus;

	public UILabel m_SubObjectiveStatus;

	public MissionsProgressBar m_MissionsProgressBar;

	public RadialInfo m_PlaceBodyRadialInfo;

	public RadialInfo m_DropBodyRadialInfo;

	public List<string> m_BodyCarryRadialOrder;

	private PanelReference<Panel_Actions> m_Actions;

	private PanelReference<Panel_Clothing> m_Clothing;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_Map> m_Map;

	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	private PanelReference<Panel_Rest> m_Rest;

	public GameObject m_MissionNotificanFlag;

	public int m_MaximumRadialOnScreenLimit;

	private int m_NextArmToAdd;

	private bool m_UsingGamepadLastFrame;

	private GearItem m_GearItemBeingInspected;

	private float m_MaxFadeOverlayAlphaReached;

	private int m_NumFramesActive;

	private bool m_RadialDisabled;

	private bool m_IsExiting;

	private List<Action> m_Queue;

	private GearItem[] m_SatchelItems;

	private List<GearItem> m_TempGearItemListNormal;

	private List<GearItem> m_TempGearItemListFavorites;

	private bool m_DoItemInHandsDuringInteractionEnd;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 14)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateCurrentTimeLabel")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "CanPlaceFromRadial")]
	[Calls(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "OnBack")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
	[Calls(Type = typeof(Panel_Inventory), Member = "ReturnFromAddToSatchel")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(RadialMenuArm), Member = "DoCallbackAction")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButtonHeldDown")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "OnBack")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(RadialMenuArm), Member = "DoCallbackAction")]
	[Calls(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "CanPlaceFromRadial")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "MousePosToIndex")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "CanPlaceFromRadial")]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateMissionInfo")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowLightSourceRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelSelectSlotRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowBodyCarryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateCurrentTimeLabel")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowWeaponRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowToolsRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	public void Enable(bool enable, bool doHoverDisable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetPanelAlpha()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public bool IsRadialDisabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void DisableRadial(bool disabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "DoTween")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void DoFirstOpen()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoFirstOpen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UISpriteAnimation), Member = "ResetToBeginning")]
	public void DoTween()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void ShowSatchelSelectSlotRadial()
	{
	}

	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetRadialInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void ShowSatchelRadial()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	public void ShowPrimaryRadial()
	{
	}

	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetGearItemsForRadial")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void ShowLightSourceRadial()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetGearItemsForRadial")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	public void ShowWeaponRadial()
	{
	}

	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetGearItemsForRadial")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	public void ShowToolsRadial()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowToolsRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowWeaponRadial")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowLightSourceRadial")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private List<GearItem> GetGearItemsForRadial(string[] itemOrder, out int items)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref items) = null;
		return null;
	}

	[CallsUnknownMethods(Count = 65)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(LeanToManager), Member = "PlayerInLeanTo")]
	[Calls(Type = typeof(string), Member = "Contains")]
	public void ShowPlaceItemRadial()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(LeanToManager), Member = "LeanTosAreUnlocked")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(LeanToManager), Member = "LeanTosAreUnlocked")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(SnowShelterManager), Member = "SnowSheltersAreUnlocked")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	public void ShowShelterRadial()
	{
	}

	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void ShowNavigationRadial()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideHoverText")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void ShowBodyCarryRadial()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyCarry), Member = "MaybeDrop")]
	[CallsUnknownMethods(Count = 1)]
	public void DoBodyDrop()
	{
	}

	[Calls(Type = typeof(BodyCarry), Member = "MaybePlace")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void DoBodyPlacement()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void DoOpenMap()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetFoodItemsInInventory")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CallsUnknownMethods(Count = 12)]
	public void ShowFoodRadial()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDrinkItemsInInventory")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CallsUnknownMethods(Count = 12)]
	public void ShowDrinkRadial()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetFirstAidItemsInInventory")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void ShowFirstAidRadial()
	{
	}

	[CallerCount(Count = 20)]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetRadialInfo")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[CallsUnknownMethods(Count = 2)]
	private void AddRadialSelection(RadialInfo radialInfo, Action callback, bool greyOut = false, bool showHighlight = false)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowToolsRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowWeaponRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowLightSourceRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelSelectSlotRadial")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetRadialInfoGear")]
	[CallerCount(Count = 7)]
	private void AddRadialSelectionGear(string textureName, RadialGearDelegate callback, GearItem gi)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnPrevRadial()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "ResetToBeginning")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void OnBack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Inventory), Member = "ReturnFromAddToSatchel")]
	[CallsUnknownMethods(Count = 1)]
	public void OnBackFinal()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallerCount(Count = 0)]
	public void ShowNotInjuredMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNoBedrollMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestDecoy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	public void ShowNoDecoyMessage()
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(InputManager), Member = "CanStartFireIndoors")]
	[CallerCount(Count = 0)]
	public void ShowNoCampfireMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNoLightSourceMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNoWeaponMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNoToolsMessage()
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void ShowNoMapsMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNotImplemented()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNoEmergencyStimMessage()
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	public void ShowNoFirstAidItemsMessage()
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void ShowNoFoodMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNoDrinkMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RockCacheManager), Member = "HasReachedMaxRockCacheCount")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 5)]
	public void ShowNoRockCacheMessage()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "MaybeBlockMoveInputUntilReleased")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CallsUnknownMethods(Count = 2)]
	public void UseEmergencyStim()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void StartClothingUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 2)]
	public void ShowNoSnowShelterMessage()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(LeanToManager), Member = "GetMissingMaterialsString")]
	[CallerCount(Count = 0)]
	public void ShowNoLeanToMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 2)]
	private void ShowNoSprayPaintMessage()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "MaybeBlockMoveInputUntilReleased")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void UseItem(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "ReturnFromAddToSatchel")]
	[CallsUnknownMethods(Count = 1)]
	public void ReplaceItemInSatchel(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Inventory), Member = "ReturnFromAddToSatchel")]
	[CallsUnknownMethods(Count = 2)]
	public void AddItemToSatchel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerInVehicle), Member = "OnBedroll")]
	[CallerCount(Count = 0)]
	public void OpenVehicleRest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInVehicle), Member = "OnBedroll")]
	[CallsUnknownMethods(Count = 1)]
	public void OpenVehicleRest(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "OnBedroll")]
	[CallsUnknownMethods(Count = 1)]
	public void OpenSnowShelterRest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "OnBedroll")]
	[CallsUnknownMethods(Count = 1)]
	public void OpenSnowShelterRest(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeanToManager), Member = "OnBedroll")]
	public void OpenLeanToRest()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeanToManager), Member = "OnBedroll")]
	public void OpenLeanToRest(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Rest), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void DoPassTime()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoCallbackAction")]
	[Calls(Type = typeof(RadialMenuArm), Member = "DoCallbackAction")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void ShowEatRawMeatConfirmPopup()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void ResetNotificationsData()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DetermineHoveredItemState")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 4)]
	private bool CanPlaceFromRadial(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DetermineHoveredItemState")]
	private bool CanUseFromRadial(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetRadialInfo")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "DetermineHoveredItemState")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "DetermineHoveredItemState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateButtonStates()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetActionText")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "CanPlaceFromRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "CanUseFromRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetActionText")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CallsUnknownMethods(Count = 2)]
	private void DetermineHoveredItemState(out bool canPlace, out string useAction)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref canPlace) = null;
		useAction = null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DetermineHoveredItemState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DetermineHoveredItemState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	private string GetActionText(RadialMenuArm arm)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private int StickDirectionToIndex(Vector2 stickVec)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private int MousePosToIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	private void ErrorAction()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowBodyCarryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CallsUnknownMethods(Count = 215)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	private Action GetDelegateForRadial(RadialType radialType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[CallerCount(Count = 15)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	private bool GetShouldGreyOut(RadialType radialType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private bool ShouldShowNewItemHighlight(RadialType radialType)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void UpdateDisplayText()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "GetHoursDaylightString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateCurrentTimeLabel()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowFirstAidRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowDrinkRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowFoodRadial")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetRadialInfoGear")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	private void ShowGearRadial(List<GearItem> gearItems, Action noItemsAction)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowFoodRadial")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private List<GearItem> GetFoodItemsInInventory()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowDrinkRadial")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private List<GearItem> GetDrinkItemsInInventory()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowFirstAidRadial")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private List<GearItem> GetFirstAidItemsInInventory()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "GetCurrentFrame")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UISpriteAnimation), Member = "GetCurrentFrame")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UISpriteAnimation), Member = "GetCurrentFrame")]
	private void UpdateFadeOverlay()
	{
	}

	[Calls(Type = typeof(Inventory), Member = "GetNumNoiseMakers")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateAndEnableStackStatus")]
	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetNumTorches")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetNumStones")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateStackStatus(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateHotColdStatus(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateAndEnableStackStatus(string text, string spriteName, Color c)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateMissionInfo()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RadialMenuArm), Member = "DoCallbackAction")]
	[CallsUnknownMethods(Count = 1)]
	private void ForceRadialMenuArmCallback()
	{
	}

	[CallsUnknownMethods(Count = 56)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public Panel_ActionsRadial()
	{
	}
}
