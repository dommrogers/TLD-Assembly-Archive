using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshTable")]
	[CalledBy(Type = typeof(GridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GridUI), Member = "InitializeNewItem")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public void Initialize(Panel_Base parentPanel, Action backAction, Action optionalConfirmAction = null)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GridItem), Member = "Initialize")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(GridUI), Member = "Initialize")]
	[CallsUnknownMethods(Count = 6)]
	private void InitializeNewItem(GridItem item)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GridUI), Member = "RefreshGridItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void AddItem(LocalizedString label, Texture icon, bool disabled)
	{
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "SetShowBanishmentGlyph")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Reset")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_nowhere_to_hide_banishment_ready")]
	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	public void ClearItems()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(GridUI), Member = "RefreshTable")]
	[CalledBy(Type = typeof(GridUI), Member = "AddItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(UIButtonColor), Member = "ResetDefaultColor")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	private void RefreshGridItem(int gridItemIndex, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectItem(GridItem item)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "Scroll")]
	public void ScrollLeft()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ScrollRight()
	{
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "OnButtonScrollRight")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GridUI), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "OnButtonScrollLeft")]
	[CalledBy(Type = typeof(GridUI), Member = "ScrollLeft")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	private void Scroll(int direction)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public int GetSelectedIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "UpdateControls")]
	[Calls(Type = typeof(GridUI), Member = "RefreshTable")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallerCount(Count = 0)]
	public void SetHasActiveFocus(bool active)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnBack()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GridUI), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(GridUI), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateControls()
	{
	}

	[CalledBy(Type = typeof(GridUI), Member = "UpdateControls")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GridUI), Member = "Scroll")]
	[CallerCount(Count = 1)]
	private void MoveGridSelection(int horizontal, int vertical)
	{
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[CalledBy(Type = typeof(GridUI), Member = "Update")]
	[Calls(Type = typeof(GridUI), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(GridUI), Member = "RefreshGridItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GridItem), Member = "ToggleSelection")]
	private void RefreshTable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public GridUI()
	{
	}
}
