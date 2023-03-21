using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;

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

	private Panel_Clothing m_Panel_Clothing;

	[CalledBy(Type = typeof(GenericClothingSlotSpawner), Member = "AssignValuesToSpawnedObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	public void DoSetup(Panel_Clothing parentPanel, string emptySlotSpriteName, ClothingRegion region, ClothingLayer layer, int column, int row, UITexture[] paperDolls, string layerLocID)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "DeselectItems")]
	[CallsUnknownMethods(Count = 2)]
	public void ActivateMouseHoverHighlight(bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	public void DoAltLayoutSetup(int column, int row)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "DeselectItems")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectItemIfEquipped")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetDefaultSelection")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ClothingSlot), Member = "ActivateMouseHoverHighlight")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetDefaultSelection")]
	public void SetSelected(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CallsUnknownMethods(Count = 1)]
	public void DoClickAction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(ClothingSlot), Member = "CheckForHide")]
	[Calls(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[Calls(Type = typeof(ClothingSlot), Member = "HasOptionsAvailable")]
	[Calls(Type = typeof(ClothingSlot), Member = "ToggleWidgetsActive")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetBlendAmountOnly")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseThirdAltTexture")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	public void UpdateSlotInfo()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "ActivateTopLayerOnly")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "ActivateTopLayerOnly")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForHide")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
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
	[CallerCount(Count = 0)]
	private void UpdateWetFrozenSprites(ClothingItem clothingItem)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ClothingSlot), Member = "ToggleWidgetsActive")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureNoBlendMap")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureBlendMap")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private void SetPaperDollTexture(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureBlendMap")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "AdjustForFemaleVariant")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Addressables), Member = "LoadResourceLocationsAsync")]
	private bool IsAddressableTexture(string name)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureNoBlendMap")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureBlendMap")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureBlendMap")]
	[Calls(Type = typeof(StringBuilder), Member = "Replace")]
	[Calls(Type = typeof(ClothingSlot), Member = "IsAddressableTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "Remove")]
	private void AdjustForFemaleVariant()
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "Replace")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(ClothingSlot), Member = "IsAddressableTexture")]
	[Calls(Type = typeof(ClothingSlot), Member = "AdjustForFemaleVariant")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "Replace")]
	[Calls(Type = typeof(ClothingSlot), Member = "AdjustForFemaleVariant")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseThirdAltTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private void SetPaperDollTextureBlendMap(GearItem gi, bool isFemale, int widgetIndex)
	{
	}

	[Calls(Type = typeof(ClothingSlot), Member = "AdjustForFemaleVariant")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseThirdAltTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void SetPaperDollTextureNoBlendMap(GearItem gi, bool isFemale, int widgetIndex)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	private void SetBlendAmountOnly(GearItem gi)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetWornCarryingCapacityBuffClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool HasOptionsAvailable()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int GetPaperDollTextureLayer()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_FeetTop")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Astrid")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Accessory")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_HeadMid")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_FeetTop")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Astrid")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Hands")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Hands")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdatePaperDollTextureLayer(int newLayer)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureBlendMap")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureNoBlendMap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private bool ShouldUseAltTexture()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureBlendMap")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureNoBlendMap")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool ShouldUseThirdAltTexture()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Astrid")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Accessory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_HeadMid")]
	private void CheckForChangeLayer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdatePaperDollLayer_Hands()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	private void UpdatePaperDollLayer_FeetTop()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void UpdatePaperDollLayer_HeadMid()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	private void UpdatePaperDollLayer_Accessory(int CHEST_MID_DEFAULT_LAYER)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdatePaperDollLayer_Astrid(int CHEST_BASE_LAYER, int CHEST_MID_DEFAULT_LAYER)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(ClothingSlot), Member = "ToggleWidgetsActive")]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "GetFootwearType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void CheckForHide()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	private static bool IsMatchingGearName(string a, string b)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public ClothingSlot()
	{
	}
}
