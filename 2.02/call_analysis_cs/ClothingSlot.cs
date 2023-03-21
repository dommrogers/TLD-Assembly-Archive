using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ClothingSlot : MonoBehaviour
{
	public UITexture m_TextureGearItem;

	public UISprite m_SpriteEmptySlot;

	public GameObject m_Selected;

	public UISprite m_SpriteWet;

	public UISprite m_SpriteFrozen;

	public UISprite m_SpriteOptionsAvailable;

	public UILabel m_LayerLabel;

	public GameObject m_SpriteBoxHover;

	public Material m_MaterialSource;

	public GearItem m_GearItem;

	private ClothingRegion m_ClothingRegion;

	private ClothingLayer m_ClothingLayer;

	private int m_LayoutColumnIndex;

	private int m_LayoutRowIndex;

	private bool m_HasRegistered;

	private bool m_IsUsingAltTexture;

	private bool m_IsUsingThirdAltTexture;

	private VoicePersona m_VoiceInUse;

	private UITexture[] m_PaperDollSlots;

	private List<UIWidget> m_PaperDollSlotWidgets;

	private StringBuilder m_StringBuilder;

	private bool m_HasAltLayoutIndex;

	private int m_AltLayoutColumnIndex;

	private int m_AltLayoutRowIndex;

	public HoverWidgetControl m_HoverWidgetControl;

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CalledBy(Type = typeof(GenericClothingSlotSpawner), Member = "AssignValuesToSpawnedObject")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	public void DoSetup(string emptySlotSpriteName, ClothingRegion region, ClothingLayer layer, int column, int row, UITexture[] paperDolls, string layerLocID)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "DeselectItems")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public void ActivateMouseHoverHighlight(bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	public void DoAltLayoutSetup(int column, int row)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasAltIndex()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetColumnIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public bool ColumnMatchesLayout(int col)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetDefaultSelection")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetDefaultSelection")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectItemIfEquipped")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "DeselectItems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[Calls(Type = typeof(ClothingSlot), Member = "ActivateMouseHoverHighlight")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetSelected(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void DoClickAction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[CallsUnknownMethods(Count = 2)]
	public void DoDoubleClickAction()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsAtPositionInLayout(int col, int row)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsSelected()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ClothingRegion GetClothingRegion()
	{
		return default(ClothingRegion);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ClothingLayer GetClothingLayer()
	{
		return default(ClothingLayer);
	}

	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(ClothingSlot), Member = "HasOptionsAvailable")]
	[Calls(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[Calls(Type = typeof(ClothingSlot), Member = "CheckForHide")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(ClothingSlot), Member = "SetBlendAmountOnly")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseThirdAltTexture")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	public void UpdateSlotInfo()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "ActivateTopLayerOnly")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "ActivateTopLayerOnly")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForHide")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void ToggleWidgetsActive(bool toggle)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetLayoutRow()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetLayoutColumn()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallerCount(Count = 0)]
	private void UpdateWetFrozenSprites(ClothingItem clothingItem)
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(StringBuilder), Member = "Remove")]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "Replace")]
	[Calls(Type = typeof(StringBuilder), Member = "Replace")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseThirdAltTexture")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Replace")]
	[CallsUnknownMethods(Count = 95)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ClothingSlot), Member = "ToggleWidgetsActive")]
	[Calls(Type = typeof(StringBuilder), Member = "Replace")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "Remove")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseThirdAltTexture")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Remove")]
	[Calls(Type = typeof(StringBuilder), Member = "Replace")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private void SetPaperDollTexture(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	private void SetBlendAmountOnly(GearItem gi)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(PlayerManager), Member = "GetWornCarryingCapacityBuffClothing")]
	private bool HasOptionsAvailable()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private int GetPaperDollTextureLayer()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	private void UpdatePaperDollTextureLayer(int newLayer)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool ShouldUseAltTexture()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	private bool ShouldUseThirdAltTexture()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 53)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void CheckForChangeLayer()
	{
	}

	[Calls(Type = typeof(ClothingSlot), Member = "ToggleWidgetsActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(PlayerManager), Member = "GetFootwearType")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void CheckForHide()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public ClothingSlot()
	{
	}
}
