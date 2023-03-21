using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_List<T, U> : Panel_Base
{
	protected enum StickMode
	{
		VerticalStick,
		VerticalRightStick
	}

	public List<T> m_Displays;

	public GameObject m_ScrollbarSpawner;

	public ButtonLegendContainer m_ButtonLegendContainer;

	protected UISlider m_Slider;

	protected GameObject m_SliderRoot;

	protected List<U> m_Items;

	protected GamepadButtonSprite[] m_GamepadButtonSprites;

	protected int m_CurrentIndex;

	protected int m_CurrentDisplayOffset;

	protected U m_SelectedItem;

	protected bool m_RefreshingSelected;

	protected bool m_NeedsSelectedRefresh;

	protected bool m_NeedsUpdate;

	protected int m_ScrollWheelIndexStep;

	protected const int INVALID_INDEX = -1;

	protected StickMode m_StickMode;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public override void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CallsUnknownMethods(Count = 3)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsUnknownMethods(Count = 1)]
	public void OnBackButton()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void OnScrollbarChanged()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected virtual void Start_Internal()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void Awake_Internal()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void Enable_Internal(bool isEnabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void Update_Internal()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void ConfigureDisplay(T display, int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void SetSelected(T display, bool selected)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected virtual void ClearDisplay(T display)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected virtual void SetupDisplay(T display, U item)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	protected virtual List<U> GatherItems()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnDeleteItemRequested(int itemIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	protected int GetItemIndex(U item)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected void RefreshItemsDisplay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void OnDisplayClicked(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void OnDisplayClickedDelete(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void ItemDeleted()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void ResetIndex()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 7)]
	protected void RefreshSelected()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[DeduplicatedMethod]
	private int GetCurrentDisplayOffset()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private void CollectItems()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(InputManager), Member = "GetOpenActionsPanelPressed")]
	private void HandleInput()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 2)]
	private void HandleVerticalNavigation(float movement)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 14)]
	private void RefreshDisplayList()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateMouseKeyboardButtons()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void UpdateControllerButtons()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void ClearSelected()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public Panel_List()
	{
	}
}
