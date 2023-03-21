using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_WeaponPicker : Panel_AutoReferenced
{
	public ButtonLegendContainer m_ButtonLegendContainer;

	public GameObject m_ListRoot;

	public WeaponPickerGridItem m_Item1;

	public WeaponPickerGridItem m_Item2;

	public WeaponPickerGridItem m_Item3;

	public WeaponPickerGridItem m_Item4;

	public UILabel m_Label1;

	public UILabel m_Label2;

	public UILabel m_Label3;

	public UILabel m_Label4;

	public UISprite m_StruggleBar;

	public float m_StruggleBarFillOffset;

	public GameObject m_SelectedEffect;

	public TweenScale m_SelectedSpriteTweenScale;

	private List<GearItem> m_GearItems;

	private List<WeaponPickerGridItem> m_GridItemsList;

	private List<UILabel> m_LabelsList;

	private List<UISprite> m_HoverEffectSpriteList;

	private int m_SelectedItemIndex;

	private GearItem m_SelectedItem;

	private float m_DurationSeconds;

	private float m_TimerSeconds;

	private float m_ListOffsetWhen2;

	private float m_ListOffsetWhen3;

	private float m_ListOriginalOffset;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 20)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlayDuringStruggle")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void InitializeLayout()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnWeaponPicked")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	private void MaybeSelectGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnShowPickerEnded")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeInterruptPicker")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShowPicker")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "MaybeSelectGear")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeLayout")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void Enable(bool enable, List<GearItem> listItems, float durationSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "OnClick")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	public void SelectGridItem(WeaponPickerGridItem gridItem, bool isInContainer)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static List<GearItem> GetPrioritizedWeaponList()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public static GearItem GetBestItemScare()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public static GearItem GetBestItemPuncture()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static GearItem GetBestItemSlash()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	public static GearItem GetBestItemShoot()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemScare")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPuncture")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemShoot")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static GearItem GetBestItemPerCategory(StruggleBonus.StruggleWeaponType type)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private int GetHoveredItemIndex()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateMouseIndex()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "Refresh")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "RefreshEmptyItem")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetCategoryForItem")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void InitializeListItem(int i)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void InitializeListItems()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	private string GetCategoryForItem(GearItem item)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "UpdateIndexSelected")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateGamepadSelection()
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

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateIndexSelected")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "MoveSelectedSpriteAndTween")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnSelectedIndexChanged(int newIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateIndexSelected(int newIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateBar()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void InitializeTimerBar(float durationSeconds)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	private void SetStruggleBarFillAmount(float value)
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "MoveSelectedSpriteAndTween")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void InitializeSelection()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_WeaponPicker()
	{
	}
}
