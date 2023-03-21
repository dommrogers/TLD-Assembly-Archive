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

		[CalledBy(Type = typeof(BasicMenu), Member = "AddItem")]
		[CallerCount(Count = 1)]
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
		[CallerCount(Count = 7)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MonoBehaviour GetOwnerContext()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "ConfigureMenu")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void AddExtension(IBasicMenuExtension menuExtension)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateDescriptionForMouseControl()
	{
	}

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescriptionForMouseControl")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public void ManualUpdate()
	{
	}

	[CallerCount(Count = 20)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetBackAction(Action onClickBackAction)
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "ConfigureMenu")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void EnableConfirm(bool enable, string confirmTextLocId)
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateMouseConfirmText(string confirmTextLocId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetOnSelectionUpdateCallback(OnSelectionUpdate onSelectionUpdate)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetItemValueIndex(int value)
	{
		return 0;
	}

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(BasicMenuItemModel), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public BasicMenuItemModel AddItem(string id, int value, int itemIndex, string labelText, string descriptionText, string secondaryText, Action onClickAction, Color tintNormal, Color tintHighlight)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AddLineBreak()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 54)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEnabled()
	{
		return false;
	}

	[CallerCount(Count = 39)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshScrollbarSettings")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedColor")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public void Enable(bool enabled)
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetItemCount()
	{
		return 0;
	}

	[CallerCount(Count = 44)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int GetSelectedItemIndex()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "DeleteSaveSlot")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public string GetSelectedItemIndexNextId()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "DeleteSaveSlot")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public int GetSelectedItemIndexFromId(string id)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public string GetSelectedItemId()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int GetSelectedItemValue()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool HasActiveItemByID(string id)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateMainWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedColor")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnItemClicked(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnItemDoubleClicked(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static BasicMenu InstantiateMenu(GameObject prefab, GameObject root, GameObject defaultRoot, MonoBehaviour context)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "ConfigureMenu")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitleHeader")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateTitle(string mainLocalizedTextId, string headerLocalizedTextId, Vector3 headerOffset)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnConfirm")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnClickBack")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private bool AcceptInput()
	{
		return false;
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateTitleHeader(string localizedTextId, Vector3 offset)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateTitle(string localizedTextId)
	{
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetItemSelectable(int itemIndex, bool selectable)
	{
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "RestoreSelection")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public void SetItemSelected(int itemIndex)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateHoveredButton(int index, bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private int GetButtonIndexHovered()
	{
		return 0;
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void SetButtonPressedFromMenuIndex(int buttonIndex, bool immediate)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Color GetSelectedColor(int index)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(BasicMenu), Member = "SelectNextValidItem")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void ProcessMenu(List<BasicMenuItemView> menuItems)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateDescriptionForMouseControl")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateDescription(int buttonIndex)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateScrollbar")]
	[Calls(Type = typeof(BasicMenu), Member = "ClampSelectedIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	private void UpdateSelection(List<BasicMenuItemView> menuItems)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CalledBy(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ClampSelectedIndex()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(BasicMenu), Member = "ClampSelectedIndex")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 40)]
	private void RefreshEnableItems()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "SelectNextValidItem")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private bool CanItemBeSelected(int index)
	{
		return false;
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "OnConfirm")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void InternalClickAction(int index, bool doAction)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Awake")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "SetItemSelectable")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private void RefreshButtonStateColors()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void RefreshScrollbarSettings()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateScrollbar()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void OnScrollbarChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "Update")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateMenuExtensionButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(EventDelegate), Member = "Cache")]
	[Calls(Type = typeof(EventDelegate.Parameter), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 47)]
	private void InstantiateMenuItems()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private int SelectNextValidItem(List<BasicMenuItemView> menuItems, int index, int delta)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	public BasicMenu()
	{
	}
}
