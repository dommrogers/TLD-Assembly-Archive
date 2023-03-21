using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public void DoSetup(Panel_Clothing parentPanel, string emptySlotSpriteName, ClothingRegion region, ClothingLayer layer, int column, int row, UITexture[] paperDolls, string layerLocID)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "DeselectItems")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
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
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetColumnIndex()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public bool ColumnMatchesLayout(int col)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetDefaultSelection")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectItemIfEquipped")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "DeselectItems")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ClothingSlot), Member = "ActivateMouseHoverHighlight")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetSelected(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DoClickAction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DoDoubleClickAction()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsAtPositionInLayout(int col, int row)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsSelected()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ClothingRegion GetClothingRegion()
	{
		return default(ClothingRegion);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ClothingLayer GetClothingLayer()
	{
		return default(ClothingLayer);
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseThirdAltTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetBlendAmountOnly")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(ClothingSlot), Member = "ToggleWidgetsActive")]
	[Calls(Type = typeof(ClothingSlot), Member = "HasOptionsAvailable")]
	[Calls(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[Calls(Type = typeof(ClothingSlot), Member = "CheckForHide")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public void UpdateSlotInfo()
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForHide")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "ActivateTopLayerOnly")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void ToggleWidgetsActive(bool toggle)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetLayoutRow()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetLayoutColumn()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWetFrozenSprites(ClothingItem clothingItem)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureBlendMap")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureNoBlendMap")]
	[Calls(Type = typeof(ClothingSlot), Member = "ToggleWidgetsActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetPaperDollTexture(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "AdjustForFemaleVariant")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureBlendMap")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Addressables), Member = "LoadResourceLocationsAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsAddressableTexture(string name)
	{
		return false;
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureBlendMap")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureNoBlendMap")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(ClothingSlot), Member = "IsAddressableTexture")]
	[Calls(Type = typeof(StringBuilder), Member = "Remove")]
	[Calls(Type = typeof(StringBuilder), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void AdjustForFemaleVariant()
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseThirdAltTexture")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[Calls(Type = typeof(ClothingSlot), Member = "AdjustForFemaleVariant")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(StringBuilder), Member = "Replace")]
	[Calls(Type = typeof(ClothingSlot), Member = "IsAddressableTexture")]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 2)]
	private void SetPaperDollTextureBlendMap(GearItem gi, bool isFemale, int widgetIndex)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseThirdAltTexture")]
	[Calls(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[Calls(Type = typeof(ClothingSlot), Member = "AdjustForFemaleVariant")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void SetPaperDollTextureNoBlendMap(GearItem gi, bool isFemale, int widgetIndex)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void SetBlendAmountOnly(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetWornCarryingCapacityBuffClothing")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private bool HasOptionsAvailable()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int GetPaperDollTextureLayer()
	{
		return 0;
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Hands")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_FeetTop")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_HeadMid")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Accessory")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Astrid")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdatePaperDollTextureLayer(int newLayer)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureBlendMap")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureNoBlendMap")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 12)]
	private bool ShouldUseAltTexture()
	{
		return false;
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureBlendMap")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureNoBlendMap")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldUseThirdAltTexture()
	{
		return false;
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_HeadMid")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Accessory")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Astrid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void CheckForChangeLayer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdatePaperDollLayer_Hands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdatePaperDollLayer_FeetTop()
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdatePaperDollLayer_HeadMid()
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void UpdatePaperDollLayer_Accessory(int CHEST_MID_DEFAULT_LAYER)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdatePaperDollLayer_Astrid(int CHEST_BASE_LAYER, int CHEST_MID_DEFAULT_LAYER)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetFootwearType")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(ClothingSlot), Member = "ToggleWidgetsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void CheckForHide()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsMatchingGearName(string a, string b)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ClothingSlot()
	{
	}
}
