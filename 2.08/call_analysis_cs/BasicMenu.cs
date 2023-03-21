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

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BasicMenu), Member = "SetFocused")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
	[CallsUnknownMethods(Count = 6)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	public void AddExtension(IBasicMenuExtension menuExtension)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "GetButtonIndexHovered")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	private void UpdateDescriptionForMouseControl()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateMainWindow")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessTopMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Update")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "Update")]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Update")]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Update")]
	[Calls(Type = typeof(BasicMenu), Member = "GetButtonIndexHovered")]
	public void ManualUpdate()
	{
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "ConfigureMenu")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CallerCount(Count = 15)]
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
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	public void EnableConfirm(bool enable, string confirmTextLocId)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BasicMenuItemModel), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public BasicMenuItemModel AddItem(string id, int value, int itemIndex, string labelText, string descriptionText, string secondaryText, Action onClickAction, Color tintNormal, Color tintHighlight)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	public void AddLineBreak()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshScrollbarSettings")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedColor")]
	public void Enable(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetCommunicationButtonsFocus")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void SetFocused(bool focused)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetItemCount()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnFadeOutFinished")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "GetSelectedMenuItem")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "GetSelectedIndex")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetTabSelectedIndex")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "GetSelectedSaveSlotInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSelectedSaveSlotInfo")]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public int GetSelectedItemIndexFromId(string id)
	{
		return default(int);
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnWorldMapClicked")]
	[CallsUnknownMethods(Count = 2)]
	public string GetSelectedItemId()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public int GetSelectedItemValue()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 4)]
	public bool HasActiveItemByID(string id)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateMainWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedColor")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
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

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[CallerCount(Count = 0)]
	public void OnClickBack()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Initialize")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeTopMenu")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Panel_Extras), Member = "Initialize")]
	public static BasicMenu InstantiateMenu(GameObject prefab, GameObject root, GameObject defaultRoot, MonoBehaviour context)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitleHeader")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	public void UpdateTitle(string mainLocalizedTextId, string headerLocalizedTextId, Vector3 headerOffset)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnClickBack")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnConfirm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	private bool AcceptInput()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void UpdateTitleHeader(string localizedTextId, Vector3 offset)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "RestoreSelection")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	public void SetItemSelected(int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	private void UpdateHoveredButton(int index, bool immediate)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateDescriptionForMouseControl")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 2)]
	private int GetButtonIndexHovered()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
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

	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "SelectNextValidItem")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(BasicMenu), Member = "SelectNextValidItem")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 1)]
	private void ProcessMenu(List<BasicMenuItemView> menuItems)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateDescriptionForMouseControl")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateDescriptionForMouseControl")]
	private void UpdateDescription(int buttonIndex)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateScrollbar")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void UpdateSelection(List<BasicMenuItemView> menuItems)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void ClampSelectedIndex()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void RefreshEnableItems()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "SelectNextValidItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	private bool CanItemBeSelected(int index)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnConfirm")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void InternalClickAction(int index, bool doAction)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "SetItemSelectable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Awake")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	private void RefreshButtonStateColors()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshScrollbarSettings()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void UpdateScrollbar()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 4)]
	public void OnScrollbarChange()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	public void UpdateMenuExtensionButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(BasicMenu), Member = "Awake")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(EventDelegate.Parameter), Member = ".ctor")]
	[Calls(Type = typeof(EventDelegate), Member = "Cache")]
	[Calls(Type = typeof(EventDelegate), Member = "Cache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate.Parameter), Member = ".ctor")]
	private void InstantiateMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	private int SelectNextValidItem(List<BasicMenuItemView> menuItems, int index, int delta)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public BasicMenu()
	{
	}
}
