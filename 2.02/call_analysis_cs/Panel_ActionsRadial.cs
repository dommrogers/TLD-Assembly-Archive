using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
using UnityEngine;

public class Panel_ActionsRadial : Panel_Base
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

	[Serializable]
	public class CustomInspectOffset
	{
		public string m_GearName;

		public Vector3 m_Offset;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public CustomInspectOffset()
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

	public TweenAlpha m_TweenAlpha;

	public RadialMenuArm[] m_RadialArms;

	public RadialInfo[] m_PrimaryRadial;

	public RadialInfo[] m_PrimaryRadialStory;

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

	public GameObject m_CraftingObject;

	public UILabel m_CraftingItemName;

	public UILabel m_CraftingItemDesc;

	public UILabel m_CraftingItemTime;

	public HarvestRepairMaterial[] m_CraftingRequiredMaterials;

	public float m_CraftingRequiredMaterialCenteredX;

	public float m_CraftingRequiredMaterialSpacing;

	public Vector3 m_InspectGearOffset;

	public CustomInspectOffset[] m_CustomOffsets;

	public float m_InspectModeSizeModifier;

	public string[] m_LightSourceRadialOrder;

	public string[] m_WeaponRadialOrder;

	public string[] m_PlaceItemRadialOrder;

	public string[] m_NavigationRadialOrder;

	public string[] m_ShelterRadialOrder;

	public string[] m_ToolsRadialOrder;

	public string m_ClickAudio;

	public string m_BackAudio;

	public string m_OpenAudio;

	public string m_CloseAudio;

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

	public GameObject m_MissionNotificanFlag;

	public int m_MaximumRadialOnScreenLimit;

	private int m_NextArmToAdd;

	private bool m_UsingGamepadLastFrame;

	private BlueprintItem m_ItemBeingCrafted;

	private uint m_CraftingAudio;

	private bool m_TimeAccelerated;

	private float m_ElapsedCraftingTime;

	private float m_DayLengthScaleBeforeCrafting;

	private GearItem m_GearItemBeingInspected;

	private Vector3 m_InspectLightOrigPos;

	private float m_InspectCamOrigDepth;

	private float m_MaxFadeOverlayAlphaReached;

	private int m_NumFramesActive;

	private bool m_RadialDisabled;

	private bool m_IsExiting;

	private List<Action> m_Queue;

	private GearItem[] m_SatchelItems;

	private List<GearItem> m_TempGearItemListNormal;

	private List<GearItem> m_TempGearItemListFavorites;

	private bool m_DoItemInHandsDuringInteractionEnd;

	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "CanPlaceFromRadial")]
	[Calls(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[Calls(Type = typeof(RadialMenuArm), Member = "DoCallbackAction")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateCurrentTimeLabel")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "OnPrevRadial")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateCrafting")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
	[Calls(Type = typeof(Panel_Inventory), Member = "ReturnFromAddToSatchel")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "CanPlaceFromRadial")]
	[Calls(Type = typeof(RadialMenuArm), Member = "DoCallbackAction")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "IsCrafting")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButtonHeldDown")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "OnBack")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "OnBack")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "MousePosToIndex")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "CanPlaceFromRadial")]
	[Calls(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelRadial")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateMissionInfo")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelSelectSlotRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowLightSourceRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowToolsRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowBodyCarryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateCurrentTimeLabel")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowWeaponRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void Enable(bool enable, bool doHoverDisable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetPanelAlpha()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsRadialDisabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void DisableRadial(bool disabled)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "DoTween")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void DoFirstOpen()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoFirstOpen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void DoTween()
	{
	}

	[CallsUnknownMethods(Count = 51)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	public void ShowSatchelSelectSlotRadial()
	{
	}

	[CallsUnknownMethods(Count = 58)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	public void ShowSatchelRadial()
	{
	}

	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShouldShowNewItemHighlight")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShouldShowNewItemHighlight")]
	public void ShowPrimaryRadial()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetGearItemsForRadial")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void ShowLightSourceRadial()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetGearItemsForRadial")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void ShowWeaponRadial()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetGearItemsForRadial")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void ShowToolsRadial()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowToolsRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowWeaponRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowLightSourceRadial")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private List<GearItem> GetGearItemsForRadial(string[] itemOrder, out int items)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref items) = null;
		return null;
	}

	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[CallsUnknownMethods(Count = 171)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(LeanToManager), Member = "PlayerInLeanTo")]
	public void ShowPlaceItemRadial()
	{
	}

	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CallsUnknownMethods(Count = 54)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(LeanToManager), Member = "LeanTosAreUnlocked")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(LeanToManager), Member = "LeanTosAreUnlocked")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(SnowShelterManager), Member = "SnowSheltersAreUnlocked")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	public void ShowShelterRadial()
	{
	}

	[CallsUnknownMethods(Count = 64)]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_Map), Member = "NoMapsUnlocked")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowNoMapsUnlockedMessage")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public void ShowNavigationRadial()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ShowCraftingRadial()
	{
	}

	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideHoverText")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 51)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDelegateForRadial")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	public void ShowBodyCarryRadial()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BodyCarry), Member = "MaybeDrop")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void DoBodyDrop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BodyCarry), Member = "MaybePlace")]
	[CallsUnknownMethods(Count = 2)]
	public void DoBodyPlacement()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "NoMapsUnlocked")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowNoMapsUnlockedMessage")]
	[CallsUnknownMethods(Count = 3)]
	public void DoOpenMap()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetFoodItemsInInventory")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void ShowFoodRadial()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDrinkItemsInInventory")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CallsUnknownMethods(Count = 15)]
	public void ShowDrinkRadial()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetFirstAidItemsInInventory")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CallsUnknownMethods(Count = 15)]
	public void ShowFirstAidRadial()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetRadialInfo")]
	public void AddRadialSelection(RadialInfo radialInfo, Action callback, bool greyOut = false, bool showHighlight = false)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetRadialInfoGear")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelSelectSlotRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowLightSourceRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowWeaponRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowToolsRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	public void AddRadialSelectionGear(string textureName, RadialGearDelegate callback, GearItem gi, bool greyOut = false, bool showCrafting = false, int numItems = 1)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	public void OnPrevRadial()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "ResetToBeginning")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	public void OnBack()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory), Member = "ReturnFromAddToSatchel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnBackFinal()
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void ShowNotInjuredMessage()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ShowNoBedrollMessage()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Inventory), Member = "GetBestDecoy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void ShowNoDecoyMessage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(InputManager), Member = "CanStartFireIndoors")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 2)]
	public void ShowNoCampfireMessage()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ShowNoLightSourceMessage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNoWeaponMessage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNoToolsMessage()
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ShowNoMapsMessage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNotImplemented()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNoEmergencyStimMessage()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ShowNoFirstAidItemsMessage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNoFoodMessage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowNoDrinkMessage()
	{
	}

	[Calls(Type = typeof(RockCacheManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RockCacheManager), Member = "HasReachedMaxRockCacheCount")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	public void ShowNoRockCacheMessage()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UseItem")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UseEmergencyStim()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void StartClothingUI()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 4)]
	public void ShowNoSnowShelterMessage()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LeanToManager), Member = "GetMissingMaterialsString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ShowNoLeanToMessage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 4)]
	private void ShowNoSprayPaintMessage()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UseEmergencyStim")]
	[Calls(Type = typeof(GameManager), Member = "MaybeBlockMoveInputUntilReleased")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void UseItem(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "ReturnFromAddToSatchel")]
	[CallsUnknownMethods(Count = 5)]
	public void ReplaceItemInSatchel(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Inventory), Member = "ReturnFromAddToSatchel")]
	[CallsUnknownMethods(Count = 7)]
	public void AddItemToSatchel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerInVehicle), Member = "OnBedroll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OpenVehicleRest()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerInVehicle), Member = "OnBedroll")]
	[CallsUnknownMethods(Count = 2)]
	public void OpenVehicleRest(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "OnBedroll")]
	[CallsUnknownMethods(Count = 2)]
	public void OpenSnowShelterRest()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "OnBedroll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OpenSnowShelterRest(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LeanToManager), Member = "OnBedroll")]
	[CallsUnknownMethods(Count = 2)]
	public void OpenLeanToRest()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LeanToManager), Member = "OnBedroll")]
	[CallsUnknownMethods(Count = 2)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "CanCraftItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	public void DoCraftItem(GearItem gi)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OnCancelCrafting")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateCrafting")]
	public bool IsCrafting()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_ActionsRadial), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "StopProgressBarAudio")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "IsCrafting")]
	public void OnCancelCrafting()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoCallbackAction")]
	[CallsUnknownMethods(Count = 8)]
	public void ShowEatRawMeatConfirmPopup()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ResetNotificationsData()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DetermineHoveredItemState")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private bool CanPlaceFromRadial(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DetermineHoveredItemState")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CanUseFromRadial(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "DetermineHoveredItemState")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetRadialInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "DetermineHoveredItemState")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateButtonStates()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "CanUseFromRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetActionText")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetActionText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "CanPlaceFromRadial")]
	private void DetermineHoveredItemState(out bool canPlace, out string useAction)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref canPlace) = null;
		useAction = null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DetermineHoveredItemState")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DetermineHoveredItemState")]
	private string GetActionText(RadialMenuArm arm)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private int StickDirectionToIndex(Vector2 stickVec)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	private int MousePosToIndex()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowBodyCarryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[CallerCount(Count = 12)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	private Action GetDelegateForRadial(RadialType radialType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[Calls(Type = typeof(RockCacheManager), Member = "CanAttemptToPlaceRockCache")]
	[Calls(Type = typeof(LeanToManager), Member = "CanAttemptToPlaceLeanTo")]
	[Calls(Type = typeof(LeanToManager), Member = "CanAttemptToPlaceLeanTo")]
	[Calls(Type = typeof(SnowShelterManager), Member = "CanAttemptToPlaceSnowShelter")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[Calls(Type = typeof(Panel_Map), Member = "NoMapsUnlocked")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CallsUnknownMethods(Count = 57)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetDrinkItemsInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(SnowShelterManager), Member = "CanAttemptToPlaceSnowShelter")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetFoodItemsInInventory")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "CanStartFireIndoors")]
	[Calls(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(Inventory), Member = "GetBestDecoy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "GetFirstAidItemsInInventory")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private bool GetShouldGreyOut(RadialType radialType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	private bool ShouldShowNewItemHighlight(RadialType radialType)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "RefreshCraftingRequiredMaterials")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 112)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateDisplayText()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "GetHoursDaylightString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void UpdateCurrentTimeLabel()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItemFractionalStack")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 60)]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowLiquidFractionalStack")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	private void RefreshCraftingRequiredMaterials(BlueprintItem bpi)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "StopProgressBarAudio")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddCraftedItemToInventory")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ConsumeMaterialsUsedForCrafting")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "RestoreTimeOfDay")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "StopProgressBarAudio")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "IsCrafting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	private void UpdateCrafting()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateCrafting")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OnCancelCrafting")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateCrafting")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	private void RestoreTimeOfDay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsUnknownMethods(Count = 4)]
	private void AccelerateTimeOfDay(int craftingMinutes)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateCrafting")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateCrafting")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OnCancelCrafting")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	private void StopProgressBarAudio()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateCrafting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void ConsumeMaterialsUsedForCrafting(BlueprintItem bpi)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateCrafting")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(AchievementManager), Member = "CraftedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AddCraftedItemToInventory(BlueprintItem bpi)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoCraftItem")]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private bool CanCraftItem(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private int GetCraftResultAmount(GearItem gi)
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowFirstAidRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowDrinkRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowFoodRadial")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	private void ShowGearRadial(List<GearItem> gearItems, Action noItemsAction)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowFoodRadial")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private List<GearItem> GetFoodItemsInInventory()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowDrinkRadial")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private List<GearItem> GetDrinkItemsInInventory()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowFirstAidRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private List<GearItem> GetFirstAidItemsInInventory()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "get_frames")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "get_frames")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "GetCurrentFrame")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "get_frames")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UISpriteAnimation), Member = "GetCurrentFrame")]
	private void UpdateFadeOverlay()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetNumTorches")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetNumStones")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "UpdateAndEnableStackStatus")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetNumNoiseMakers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateStackStatus(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void UpdateHotColdStatus(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	private void UpdateAndEnableStackStatus(string text, string spriteName, Color c)
	{
	}

	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAndEnableHotColdStatus(string text, string spriteName, Color c)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string StripBraces(string text)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CallsUnknownMethods(Count = 14)]
	private void UpdateMissionInfo()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RadialMenuArm), Member = "DoCallbackAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void ForceRadialMenuArmCallback()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 62)]
	public Panel_ActionsRadial()
	{
	}
}
