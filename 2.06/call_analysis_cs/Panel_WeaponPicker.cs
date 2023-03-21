using System;
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
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 20)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlayDuringStruggle")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallsUnknownMethods(Count = 8)]
	private void InitializeLayout()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnWeaponPicked")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShowPicker")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnShowPickerEnded")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeInterruptPicker")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeLayout")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "MaybeSelectGear")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 4)]
	public void Enable(bool enable, List<GearItem> listItems, float durationSeconds)
	{
	}

	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallerCount(Count = 0)]
	public void OnCancel()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	public void SelectGridItem(WeaponPickerGridItem gridItem, bool isInContainer)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	public static List<GearItem> GetPrioritizedWeaponList()
	{
		return null;
	}

	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GearItem GetBestItemScare()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPerCategory")]
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

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemScare")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemScare")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPuncture")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemShoot")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetBestItemPuncture")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	public static GearItem GetBestItemPerCategory(StruggleBonus.StruggleWeaponType type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	private void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[CallsUnknownMethods(Count = 4)]
	private int GetHoveredItemIndex()
	{
		return default(int);
	}

	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetHoveredItemIndex")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	private void UpdateMouseIndex()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItems")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "Refresh")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "RefreshEmptyItem")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetCategoryForItem")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallsUnknownMethods(Count = 6)]
	private void InitializeListItem(int i)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void InitializeListItems()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetCategoryForItem(GearItem item)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "UpdateIndexSelected")]
	private void UpdateGamepadSelection()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateIndexSelected")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateMouseIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "MoveSelectedSpriteAndTween")]
	private void OnSelectedIndexChanged(int newIndex)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "UpdateGamepadSelection")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateIndexSelected(int newIndex)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateBar()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void InitializeTimerBar(float durationSeconds)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	private void SetStruggleBarFillAmount(float value)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallsUnknownMethods(Count = 6)]
	private void InitializeSelection()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public Panel_WeaponPicker()
	{
	}
}
