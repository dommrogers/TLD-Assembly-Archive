using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class BasicMenu : MonoBehaviour
{
	public enum MouseKeyboardControlBehavior
	{
		AutoConfirmWhenSelected,
		RequiresConfirmOrDoubleClick
	}

	public enum UserControlMode
	{
		None,
		GamePad,
		MouseKb
	}

	public class BasicMenuItemModel
	{
		public readonly string m_Id;

		public readonly int m_Value;

		public readonly int m_ItemIndex;

		public readonly Action m_Action;

		public readonly string m_LabelText;

		public readonly string m_DescriptionText;

		public readonly string m_SecondaryText;

		public readonly Color m_NormalTint;

		public readonly Color m_HighlightTint;

		public bool m_Selectable;

		public bool m_IsLocked;

		public bool m_IsChecked;

		public bool m_IsCloudItem;

		public bool m_IsUpsell;

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(BasicMenu), Member = "AddItem")]
		public BasicMenuItemModel(string id, int value, int itemIndex, string labelText, string descriptionText, string secondaryText, Action onClickAction, Color tintNormal, Color tintHighlight)
		{
		}
	}

	[Serializable]
	public class BasicMenuItemView
	{
		public GameObject m_Display;

		public UIButton m_Button;

		public DoubleClickButton m_DoubleClickButton;

		public UILabel m_Label;

		public UISprite m_Linebreak;

		public UILabel m_SecondaryLabel;

		public GameObject m_LockedIcon;

		public GameObject m_CheckmarkIcon;

		public GameObject m_CloudIcon;

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void SetState(UIButtonColor.State state, bool immediate)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public BasicMenuItemView()
		{
		}
	}

	public delegate void OnSelectionUpdate(string id, int value, int itemIndex);

	public UILabel m_TitleLabel;

	public UILabel m_TitleHeaderLabel;

	public GameObject m_TitleGroup;

	public GameObject m_SelectionMarker;

	public UILabel m_DescriptionLabel;

	public GameObject m_Scrollbar;

	public GameObject m_UpsellMarker;

	public Color m_ButtonTextColor_Hover;

	public Color m_ButtonTextColor_Normal;

	public Color m_ButtonTextColor_Selected;

	public Color m_ButtonTextColor_Disabled;

	public Color m_ButtonTextColor_HoverConfirmRequired;

	public GameObject m_BasicMenuItemPrefab;

	public UIGrid m_MenuGrid;

	public int m_SecondaryTextSpacing;

	public GameObject m_MouseBackButton;

	public GameObject m_MouseBackToHomeButton;

	public GameObject m_MouseConfirmButton;

	public GenericButtonMouseSpawner m_MouseConfirmButtonSpawner;

	public GameObject m_MainMenuBackgroundObject;

	public GameObject m_CommonBackgroundObject;

	public GameObject m_LeftAlignBackgroundObject;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_Debug> m_Debug;

	public MouseKeyboardControlBehavior m_MouseKeyboardControlBehavior;

	public bool m_CanScroll;

	private bool _003CIsFocused_003Ek__BackingField;

	private int m_MenuScrollOffset;

	private int m_MenuSelectedButtonIndex;

	private int m_PreviousMenuScrollOffset;

	private int m_PreviousSelectedButtonIndex;

	private List<BasicMenuItemView> m_EnabledMenuItems;

	private List<BasicMenuItemModel> m_ItemModelList;

	private Action m_OnClickBackAction;

	private Vector3 m_HeaderLabelOriginalPosition;

	private OnSelectionUpdate m_OnSelectionUpdateCallback;

	private int m_DescriptionCurrentIndex;

	private UserControlMode m_LastControlMode;

	private const int m_MaxMenuItems = 8;

	private UISlider m_ScrollbarSlider;

	private List<BasicMenuItemView> m_MenuItems;

	private MonoBehaviour m_OwnerContext;

	private List<IBasicMenuExtension> m_MenuExtensions;

	private bool m_ForceDisableBackbutton;

	public bool IsFocused
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MonoBehaviour GetOwnerContext()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BasicMenu), Member = "SetFocused")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 6)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	public void AddExtension(IBasicMenuExtension menuExtension)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void UpdateDescriptionForMouseControl()
	{
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessTopMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateMainWindow")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Update")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Update")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescriptionForMouseControl")]
	public void ManualUpdate()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	public void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetBackAction(Action onClickBackAction)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	public void EnableConfirm(bool enable, string confirmTextLocId)
	{
	}

	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	public void UpdateMouseConfirmText(string confirmTextLocId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetOnSelectionUpdateCallback(OnSelectionUpdate onSelectionUpdate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetItemValueIndex(int value)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Sandbox), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "AddMenuItem")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "AddLineBreak")]
	[Calls(Type = typeof(BasicMenuItemModel), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	public BasicMenuItemModel AddItem(string id, int value, int itemIndex, string labelText, string descriptionText, string secondaryText, Action onClickAction, Color tintNormal, Color tintHighlight)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	public void AddLineBreak()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedColor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshScrollbarSettings")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	public void Enable(bool enabled)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Awake")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetCommunicationButtonsFocus")]
	[CallsUnknownMethods(Count = 3)]
	public void SetFocused(bool focused)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetItemCount()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "GetSelectedMenuItem")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnFadeOutFinished")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "GetSelectedIndex")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "RestoreSelection")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetTabSelectedIndex")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSlotClicked")]
	[CallerCount(Count = 15)]
	public int GetSelectedItemIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CallsUnknownMethods(Count = 2)]
	public string GetSelectedItemIndexNextId()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public int GetSelectedItemIndexFromId(string id)
	{
		return default(int);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnWorldMapClicked")]
	[CallsUnknownMethods(Count = 2)]
	public string GetSelectedItemId()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public int GetSelectedItemValue()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	public bool HasActiveItemByID(string id)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateMainWindow")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedColor")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	public void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	public void OnConfirm()
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void OnItemClicked(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	public void OnItemDoubleClicked(int index)
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnClickBack()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Initialize")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeTopMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Initialize")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Initialize")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	public static BasicMenu InstantiateMenu(GameObject prefab, GameObject root, GameObject defaultRoot, MonoBehaviour context)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitleHeader")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	public void UpdateTitle(string mainLocalizedTextId, string headerLocalizedTextId, Vector3 headerOffset)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnClickBack")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnConfirm")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	private bool AcceptInput()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateTitleHeader(string localizedTextId, Vector3 offset)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateTitle(string localizedTextId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void SetItemSelectable(int itemIndex, bool selectable)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "RestoreSelection")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "RestoreSelection")]
	public void SetItemSelected(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void EnableBackButton(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableBackHomeButton(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableCommonBackground(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	private void UpdateHoveredButton(int index, bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private int GetButtonIndexHovered()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetButtonPressedFromMenuIndex(int buttonIndex, bool immediate)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CallsUnknownMethods(Count = 2)]
	private Color GetSelectedColor(int index)
	{
		return default(Color);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(BasicMenu), Member = "SelectNextValidItem")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[Calls(Type = typeof(BasicMenu), Member = "SelectNextValidItem")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	private void ProcessMenu(List<BasicMenuItemView> menuItems)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateDescriptionForMouseControl")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateDescription(int buttonIndex)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateScrollbar")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 4)]
	private void UpdateSelection(List<BasicMenuItemView> menuItems)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void ClampSelectedIndex()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void RefreshEnableItems()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BasicMenu), Member = "SelectNextValidItem")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	private bool CanItemBeSelected(int index)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnConfirm")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void InternalClickAction(int index, bool doAction)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BasicMenu), Member = "Awake")]
	[CalledBy(Type = typeof(BasicMenu), Member = "SetItemSelectable")]
	private void RefreshButtonStateColors()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshScrollbarSettings()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void UpdateScrollbar()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 4)]
	public void OnScrollbarChange()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "UpdateButtonLegend")]
	public void UpdateMenuExtensionButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority)
	{
	}

	[Calls(Type = typeof(EventDelegate.Parameter), Member = ".ctor")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(BasicMenu), Member = "Awake")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(EventDelegate), Member = "Cache")]
	[Calls(Type = typeof(EventDelegate.Parameter), Member = ".ctor")]
	[Calls(Type = typeof(EventDelegate), Member = "Cache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	private void InstantiateMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	private int SelectNextValidItem(List<BasicMenuItemView> menuItems, int index, int delta)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	public BasicMenu()
	{
	}
}
