using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class GridUI
{
	private struct Item
	{
		public int m_Index;

		public LocalizedString m_Label;

		public Texture m_Icon;

		public bool m_Disabled;
	}

	[Serializable]
	public class GridSetup
	{
		public int m_MaxToShowAtOnce;

		public int m_NumberOfColumns;

		public int m_PreSelectedIndex;

		public GameObject m_FirstElementLocation;

		[CallerCount(Count = 0)]
		public GridSetup()
		{
		}
	}

	private GameObject m_TableObject;

	private GameObject GridItemPrefab;

	private UIButton m_LeftArrowButton;

	private UIButton m_RightArrowButton;

	public bool m_DragDropEnabled;

	public float m_DisabledAlpha;

	private GridSetup m_StandardGripSetup;

	private GridSetup m_NowhereToHideGridSetup;

	private int m_TableNumColumns;

	private float m_TableSpacingHorizontal;

	private float m_TableSpacingVertical;

	private int m_MaxItemsDisplayAtOnce;

	private int m_PreSelectedIndex;

	public GameObject m_SelectedSpriteObj;

	public TweenScale m_SelectedSpriteTweenScale;

	private Panel_Base m_ParentPanel;

	private Action m_ConfirmAction;

	private Action m_OnBackAction;

	private List<Item> m_ItemList;

	private GridItem[] m_TableItems;

	private bool m_HasActiveFocus;

	private bool m_IsDirty;

	private int m_SelectedItemIndex;

	private int m_FirstItemDisplayedIndex;

	[CalledBy(Type = typeof(GridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(GridUI), Member = "Update")]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshTable")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GridItem), Member = "Initialize")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	public void Initialize(Panel_Base parentPanel, Action backAction, Action optionalConfirmAction = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridItem), Member = "Initialize")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void InitializeNewItem(GridItem item)
	{
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GridUI), Member = "RefreshGridItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void AddItem(LocalizedString label, Texture icon, bool disabled)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Reset")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "SetShowBanishmentGlyph")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_nowhere_to_hide_banishment_ready")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void ClearItems()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsEmpty()
	{
		return false;
	}

	[CalledBy(Type = typeof(GridUI), Member = "AddItem")]
	[CalledBy(Type = typeof(GridUI), Member = "Update")]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshTable")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIButtonColor), Member = "ResetDefaultColor")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshGridItem(int gridItemIndex, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectItem(GridItem item)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void ScrollLeft()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void ScrollRight()
	{
	}

	[CalledBy(Type = typeof(GridUI), Member = "MoveGridSelection")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Scroll(int direction)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetSelectedIndex()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "UpdateControls")]
	[Calls(Type = typeof(GridUI), Member = "RefreshGridItem")]
	[Calls(Type = typeof(GridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(GridUI), Member = "MoveSelectedSpriteAndTween")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallerCount(Count = 0)]
	public void SetHasActiveFocus(bool active)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnBack()
	{
	}

	[CalledBy(Type = typeof(GridUI), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GridUI), Member = "MoveGridSelection")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateControls()
	{
	}

	[CalledBy(Type = typeof(GridUI), Member = "UpdateControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GridUI), Member = "Scroll")]
	[CallsUnknownMethods(Count = 1)]
	private void MoveGridSelection(int horizontal, int vertical)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "RefreshGridItem")]
	[Calls(Type = typeof(GridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(GridUI), Member = "MoveSelectedSpriteAndTween")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshTable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public GridUI()
	{
	}
}
