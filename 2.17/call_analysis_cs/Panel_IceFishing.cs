using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gameplay.Fishing;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Panel_IceFishing : Panel_AutoReferenced
{
	private enum IceFishingAction
	{
		ActiveFishing,
		TipupFishing
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GearItem> _003C_003E9__56_0;

		public static Predicate<GearItem> _003C_003E9__56_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CRefreshRows_003Eb__56_0(GearItem gi)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CRefreshRows_003Eb__56_1(GearItem gi)
		{
			return false;
		}
	}

	private GameObject m_ActiveFishingButton;

	private GameObject m_PlaceTipupButton;

	private Color m_InactiveActionColor;

	private IceFishingSelectionRow m_LureSelection;

	private IceFishingSelectionRow m_BaitSelection;

	private GameObject m_ActiveFishingParent;

	private int m_MaxHoursToFish;

	private int m_MinHoursToFish;

	private int m_HoursToFishDefault;

	private float m_SecondsProgressBarPerHour;

	private Transform m_TimeWidgetPos;

	private UILabel m_HoursToFishLabel;

	private UILabel m_EstimatedCaloriesBurnedLabel;

	private UILabel m_CurrentCaloriesLabel;

	private UILabel m_FeelsLikeLabel;

	private Color m_FreezingTempLabelColor;

	private GameObject m_ButtonHoursIncrease;

	private GameObject m_ButtonHoursDecrease;

	private AssetReferenceT<GearItemData> m_TackleDataReference;

	private GameObject m_TipupFishingParent;

	private AssetReferenceT<GearItemData> m_TipupDataReference;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private PanelReference<Panel_Crafting> m_Crafting;

	private ButtonLegendContainer m_ButtonLegendContainer;

	private GameObject m_ToggleFishingHoursButton;

	private GameObject m_ToggleTackleButton;

	private IceFishingAction m_Action;

	private IceFishingSelectionRow m_ActiveRow;

	private int m_HoursToFish;

	private IceFishingHole m_IceFishingHole;

	private GearItemData m_TackleData;

	private GearItemData m_TipupData;

	private AsyncOperationHandle<GearItemData> m_TackleDataHandle;

	private AsyncOperationHandle<GearItemData> m_TipupDataHandle;

	private GearItem m_BestTackle;

	private GearItem m_BestTipup;

	private bool m_FocusedOnTackle;

	private GamepadButtonSprite[] m_GamepadButtonSprites;

	private List<UIButton> m_ActiveFishingSelectButtons;

	private List<UIButton> m_PlaceTipupSelectButtons;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_AutoReferenced), Member = "OnDestroy")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	protected override void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "ChangeFishingHours")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateTackleController")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "SwitchAction")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateCurrentCaloriesLabel")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateFeelsLikeLabel")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "SwitchFocus")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingSelectionRow), Member = "SetSelected")]
	[Calls(Type = typeof(IceFishingSelectionRow), Member = "ChangeSelectedGearItem")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateTackleController(float menuHorizontal, float menuVertical)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_IceFishing), Member = "ChangeFishingHours")]
	private void UpdateFishingHoursController(float menuHorizontal)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetBestFromGearItemData")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanDoFishing()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestFromGearItemData")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateBestGear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Launch(IceFishingHole ifh)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateButtonState")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "SwitchAction")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "RefreshRows")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_IceFishing), Member = "SwitchAction")]
	public void OnShowActiveFishing()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnShowPlaceTipup()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnShowActiveFishing")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateButtonColor")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "SwitchFocus")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateCurrentCaloriesLabel")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateFeelsLikeLabel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SwitchAction(IceFishingAction action, bool forceUpdate = false)
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "SwitchAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateButtonColor(List<UIButton> buttons, Color color)
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateButtonState(List<UIButton> buttons, bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "SwitchAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(IceFishingSelectionRow), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateHoursToFishLabel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SwitchFocus(bool focusedOnTackle)
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingSelectionRow), Member = "RefreshRow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshRows()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnOpenCrafting()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetSelectedBait")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetSelectedLure")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetActiveTipup")]
	[Calls(Type = typeof(IceFishingHole), Member = "StartFishing")]
	[Calls(Type = typeof(IceFishingHole), Member = "StartActiveFishing")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnFish()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_IceFishing), Member = "ChangeFishingHours")]
	public void OnIncreaseHours()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnDecreaseHours()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "UpdateFishingHoursController")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnIncreaseHours")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "UpdateHoursToFishLabel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	private void ChangeFishingHours(int change)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeRollRandomWeightAndCalories")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsFishing()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "SwitchFocus")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "ChangeFishingHours")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateHoursToFishLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "SwitchAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "SwitchAction")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "SwitchAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateFeelsLikeLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private GearItem GetBestTipup()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_IceFishing()
	{
	}
}
