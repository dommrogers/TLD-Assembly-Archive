using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

	public Color m_ButtonTextColor_Hover;

	public Color m_ButtonTextColor_Normal;

	public Color m_ButtonTextColor_Selected;

	public Color m_ButtonTextColor_Disabled;

	public Color m_ButtonTextColor_HoverConfirmRequired;

	public GameObject m_BasicMenuItemPrefab;

	public UIGrid m_MenuGrid;

	public int m_SecondaryTextSpacing;

	public GameObject m_MouseBackButton;

	public GameObject m_MouseConfirmButton;

	public GenericButtonMouseSpawner m_MouseConfirmButtonSpawner;

	public GameObject m_MainMenuBackgroundObject;

	public GameObject m_CommonBackgroundObject;

	public MouseKeyboardControlBehavior m_MouseKeyboardControlBehavior;

	public bool m_CanScroll;

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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MonoBehaviour GetOwnerContext()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "ConfigureMenu")]
	public void AddExtension(IBasicMenuExtension menuExtension)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateDescriptionForMouseControl()
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescriptionForMouseControl")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	public void ManualUpdate()
	{
	}

	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetBackAction(Action onClickBackAction)
	{
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Story), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "ConfigureMenu")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	public void EnableConfirm(bool enable, string confirmTextLocId)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateMouseConfirmText(string confirmTextLocId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetOnSelectionUpdateCallback(OnSelectionUpdate onSelectionUpdate)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	public int GetItemValueIndex(int value)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(BasicMenuItemModel), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 24)]
	public BasicMenuItemModel AddItem(string id, int value, int itemIndex, string labelText, string descriptionText, string secondaryText, Action onClickAction, Color tintNormal, Color tintHighlight)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	public void AddLineBreak()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 54)]
	[DeduplicatedMethod]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BasicMenu), Member = "RefreshScrollbarSettings")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedColor")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 39)]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	public void Enable(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[CallerCount(Count = 7)]
	public int GetItemCount()
	{
		return default(int);
	}

	[CallerCount(Count = 44)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetSelectedItemIndex()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	public string GetSelectedItemIndexNextId()
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "DeleteSaveSlot")]
	public int GetSelectedItemIndexFromId(string id)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ProcessMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	public string GetSelectedItemId()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public int GetSelectedItemValue()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool HasActiveItemByID(string id)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateMainWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedColor")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 4)]
	public void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	public void OnConfirm()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnItemClicked(int index)
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	public void OnItemDoubleClicked(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnClickBack()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static BasicMenu InstantiateMenu(GameObject prefab, GameObject root, GameObject defaultRoot, MonoBehaviour context)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ConfigureMenu")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitleHeader")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Story), Member = "ConfigureMenu")]
	public void UpdateTitle(string mainLocalizedTextId, string headerLocalizedTextId, Vector3 headerOffset)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnClickBack")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnConfirm")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[CallerCount(Count = 7)]
	private bool AcceptInput()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateTitleHeader(string localizedTextId, Vector3 offset)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void UpdateTitle(string localizedTextId)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	public void SetItemSelectable(int itemIndex, bool selectable)
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "RestoreSelection")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "RestoreSelection")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void SetItemSelected(int itemIndex)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateHoveredButton(int index, bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	private int GetButtonIndexHovered()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 5)]
	private void SetButtonPressedFromMenuIndex(int buttonIndex, bool immediate)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private Color GetSelectedColor(int index)
	{
		return default(Color);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "SelectNextValidItem")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(BasicMenu), Member = "SelectNextValidItem")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	private void ProcessMenu(List<BasicMenuItemView> menuItems)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateDescriptionForMouseControl")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void UpdateDescription(int buttonIndex)
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "UpdateScrollbar")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "ClampSelectedIndex")]
	private void UpdateSelection(List<BasicMenuItemView> menuItems)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CalledBy(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ClampSelectedIndex()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "ClampSelectedIndex")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void RefreshEnableItems()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "SelectNextValidItem")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallerCount(Count = 5)]
	private bool CanItemBeSelected(int index)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnConfirm")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 4)]
	private void InternalClickAction(int index, bool doAction)
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Awake")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(BasicMenu), Member = "SetItemSelectable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	private void RefreshButtonStateColors()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void RefreshScrollbarSettings()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void UpdateScrollbar()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnScrollbarChange()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Story), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Update")]
	[CallerCount(Count = 7)]
	public void UpdateMenuExtensionButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Cache")]
	[Calls(Type = typeof(EventDelegate), Member = "Cache")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Awake")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(EventDelegate.Parameter), Member = ".ctor")]
	[Calls(Type = typeof(EventDelegate.Parameter), Member = ".ctor")]
	private void InstantiateMenuItems()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private int SelectNextValidItem(List<BasicMenuItemView> menuItems, int index, int delta)
	{
		return default(int);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 28)]
	public BasicMenu()
	{
	}
}
