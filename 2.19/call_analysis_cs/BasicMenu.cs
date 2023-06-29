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
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MonoBehaviour GetOwnerContext()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "SetFocused")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void AddExtension(IBasicMenuExtension menuExtension)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "GetButtonIndexHovered")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	private void UpdateDescriptionForMouseControl()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateMainWindow")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessTopMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Update")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[Calls(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "GetButtonIndexHovered")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void ManualUpdate()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetBackAction(Action onClickBackAction)
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableConfirm(bool enable, string confirmTextLocId)
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateMouseConfirmText(string confirmTextLocId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetOnSelectionUpdateCallback(OnSelectionUpdate onSelectionUpdate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetItemValueIndex(int value)
	{
		return 0;
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "AddLineBreak")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "AddMenuItem")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(BasicMenuItemModel), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public BasicMenuItemModel AddItem(string id, int value, int itemIndex, string labelText, string descriptionText, string secondaryText, Action onClickAction, Color tintNormal, Color tintHighlight)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	public void AddLineBreak()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 57)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "EnableLoadList")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshScrollbarSettings")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedColor")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void Enable(bool enabled)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Awake")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetCommunicationButtonsFocus")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void SetFocused(bool focused)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetItemCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetTabSelectedIndex")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "GetSelectedIndex")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "GetSelectedMenuItem")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnFadeOutFinished")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 16)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetSelectedItemIndex()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetSelectedItemIndexNextId()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 4)]
	public int GetSelectedItemIndexFromId(string id)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnWorldMapClicked")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetSelectedItemId()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetSelectedItemValue()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	public bool HasActiveItemByID(string id)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateMainWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshEnableItems")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedColor")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(BasicMenu), Member = "SetButtonPressedFromMenuIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateHoveredButton")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "AcceptInput")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnClickBack()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeTopMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Initialize")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static BasicMenu InstantiateMenu(GameObject prefab, GameObject root, GameObject defaultRoot, MonoBehaviour context)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitleHeader")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[CallsUnknownMethods(Count = 1)]
	private bool AcceptInput()
	{
		return false;
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateTitleHeader(string localizedTextId, Vector3 offset)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateTitle(string localizedTextId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void SetItemSelectable(int itemIndex, bool selectable)
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "RestoreSelection")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "RestoreSelection")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateHoveredButton(int index, bool immediate)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateDescriptionForMouseControl")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetButtonPressedFromMenuIndex(int buttonIndex, bool immediate)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private Color GetSelectedColor(int index)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
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
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessMenu(List<BasicMenuItemView> menuItems)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateDescriptionForMouseControl")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateDescription(int buttonIndex)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(BasicMenu), Member = "InternalClickAction")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateDescription")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateScrollbar")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateSelection(List<BasicMenuItemView> menuItems)
	{
	}

	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 16)]
	private void RefreshEnableItems()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "OnItemDoubleClicked")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(BasicMenu), Member = "SelectNextValidItem")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshButtonStateColors()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshScrollbarSettings()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateSelection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateScrollbar()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 4)]
	public void OnScrollbarChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateMenuExtensionButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(EventDelegate), Member = "Cache")]
	[Calls(Type = typeof(EventDelegate.Parameter), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	private void InstantiateMenuItems()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "CanItemBeSelected")]
	[CallsUnknownMethods(Count = 1)]
	private int SelectNextValidItem(List<BasicMenuItemView> menuItems, int index, int delta)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public BasicMenu()
	{
	}
}
