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

	[CalledBy(Type = typeof(GridUI), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshTable")]
	[CalledBy(Type = typeof(GridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	public void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GridItem), Member = "Initialize")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public void Initialize(Panel_Base parentPanel, Action backAction, Action optionalConfirmAction = null)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GridItem), Member = "Initialize")]
	private void InitializeNewItem(GridItem item)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GridUI), Member = "RefreshGridItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	public void AddItem(LocalizedString label, Texture icon, bool disabled)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_nowhere_to_hide_banishment_ready")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "SetShowBanishmentGlyph")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Reset")]
	[CallerCount(Count = 7)]
	public void ClearItems()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIButtonColor), Member = "ResetDefaultColor")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GridUI), Member = "AddItem")]
	[CalledBy(Type = typeof(GridUI), Member = "Update")]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshTable")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshGridItem(int gridItemIndex, int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(GridUI), Member = "MoveGridSelection")]
	[CallsUnknownMethods(Count = 1)]
	private void Scroll(int direction)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetSelectedIndex()
	{
		return default(int);
	}

	[Calls(Type = typeof(GridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(GridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(GridUI), Member = "RefreshGridItem")]
	[Calls(Type = typeof(GridUI), Member = "MoveSelectedSpriteAndTween")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "UpdateControls")]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallerCount(Count = 0)]
	public void SetHasActiveFocus(bool active)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnBack()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[CalledBy(Type = typeof(GridUI), Member = "Update")]
	[Calls(Type = typeof(GridUI), Member = "MoveGridSelection")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	private void UpdateControls()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GridUI), Member = "Scroll")]
	[CalledBy(Type = typeof(GridUI), Member = "UpdateControls")]
	[CallsUnknownMethods(Count = 1)]
	private void MoveGridSelection(int horizontal, int vertical)
	{
	}

	[Calls(Type = typeof(GridUI), Member = "MoveSelectedSpriteAndTween")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GridItem), Member = "ToggleSelection")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "RefreshGridItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GridItem), Member = "ToggleSelection")]
	private void RefreshTable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public GridUI()
	{
	}
}
