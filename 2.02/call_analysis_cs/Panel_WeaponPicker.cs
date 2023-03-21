using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_WeaponPicker : Panel_Base
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
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 34)]
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
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SetStruggleBarFillAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	private void InitializeLayout()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
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
	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnShowPickerEnded")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeInterruptPicker")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShowPicker")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "MaybeSelectGear")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeLayout")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItems")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SetStruggleBarFillAmount")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void Enable(bool enable, List<GearItem> listItems, float durationSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "OnClick")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public void SelectGridItem(WeaponPickerGridItem gridItem, bool isInContainer)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public static List<GearItem> GetPrioritizedWeaponList()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GearItem GetBestItemScare()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static GearItem GetBestItemPerCategory(StruggleBonus.StruggleWeaponType type)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private int GetHoveredItemIndex()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetHoveredItemIndex")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "UpdateIndexSelected")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateMouseIndex()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "Refresh")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "RefreshEmptyItem")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetCategoryForItem")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	private void InitializeListItem(int i)
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void InitializeListItems()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[CallerCount(Count = 1)]
	private string GetCategoryForItem(GearItem item)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "UpdateIndexSelected")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateGamepadSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateIndexSelected")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "MoveSelectedSpriteAndTween")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void OnSelectedIndexChanged(int newIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateIndexSelected(int newIndex)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void UpdateBar()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SetStruggleBarFillAmount")]
	private void InitializeTimerBar(float durationSeconds)
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeTimerBar")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetStruggleBarFillAmount(float value)
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "MoveSelectedSpriteAndTween")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	private void InitializeSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 35)]
	public Panel_WeaponPicker()
	{
	}
}
