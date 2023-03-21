using System;
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

	[CallsUnknownMethods(Count = 34)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SetStruggleBarFillAmount")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SetStruggleBarFillAmount")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlayDuringStruggle")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private void InitializeLayout()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void MaybeSelectGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "OnCancel")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeInterruptPicker")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShowPicker")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnShowPickerEnded")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItems")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeLayout")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SetStruggleBarFillAmount")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "MaybeSelectGear")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	public void Enable(bool enable, List<GearItem> listItems, float durationSeconds)
	{
	}

	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "OnClick")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	public void SelectGridItem(WeaponPickerGridItem gridItem, bool isInContainer)
	{
	}

	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	public static List<GearItem> GetPrioritizedWeaponList()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	public static GearItem GetBestItemScare()
	{
		return null;
	}

	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemShoot")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPuncture")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPuncture")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemScare")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemScare")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	public static GearItem GetBestItemPerCategory(StruggleBonus.StruggleWeaponType type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	private void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private int GetHoveredItemIndex()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetHoveredItemIndex")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "UpdateIndexSelected")]
	private void UpdateMouseIndex()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItems")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetCategoryForItem")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "RefreshEmptyItem")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void InitializeListItem(int i)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void InitializeListItems()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	private string GetCategoryForItem(GearItem item)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "UpdateIndexSelected")]
	private void UpdateGamepadSelection()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateIndexSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void OnSelectedIndexChanged(int newIndex)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateIndexSelected(int newIndex)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void UpdateBar()
	{
	}

	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SetStruggleBarFillAmount")]
	[CallerCount(Count = 0)]
	private void InitializeTimerBar(float durationSeconds)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeTimerBar")]
	[CallsUnknownMethods(Count = 1)]
	private void SetStruggleBarFillAmount(float value)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "MoveSelectedSpriteAndTween")]
	private void InitializeSelection()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 35)]
	public Panel_WeaponPicker()
	{
	}
}
