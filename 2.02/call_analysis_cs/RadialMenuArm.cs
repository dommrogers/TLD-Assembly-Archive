using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RadialMenuArm : MonoBehaviour
{
	public UISprite m_BG;

	public UISprite m_Sprite;

	public UISprite m_GlowSprite;

	public UITexture m_Texture;

	public Animator m_NewItemHighlightAnim;

	public bool m_IsCenterButton;

	public UILabel m_CenterLabel;

	public UILabel m_StackLabel;

	public Color m_CenterLabelColorNormal;

	public Color m_CenterLabelColorHover;

	public bool m_RadialArmEnabled;

	public UISprite m_NotificationSprite;

	private Action m_Callback;

	private Panel_ActionsRadial.RadialGearDelegate m_GearCallback;

	private Panel_ActionsRadial.RadialInfo m_RadialInfo;

	private GearItem m_GearItem;

	private string m_NameWhenHoveredOver;

	private bool m_ShowCraftingUI;

	private bool m_IsGreyedOut;

	private string m_Audio;

	private bool m_IsHoveredOver;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Panel_ActionsRadial.RadialInfo GetRadialInfo()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowToolsRadial")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowLightSourceRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetRadialInfo")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowWeaponRadial")]
	public void SetEnabled(bool shouldEnable)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowLightSourceRadial")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowWeaponRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowBodyCarryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelSelectSlotRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowToolsRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(RadialMenuArm), Member = "GetRadialIconColor")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(RadialMenuArm), Member = "IsBackButton")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void SetHoverColor(bool isHovering)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(RadialMenuArm), Member = "GetRadialIconColor")]
	[Calls(Type = typeof(RadialMenuArm), Member = "GetRadialIconColor")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	public void SetRadialInfo(Panel_ActionsRadial.RadialInfo radialInfo, Action callback, bool greyOut = false, bool showHighlight = false)
	{
	}

	[Calls(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	public void SetRadialInfoGear(string textureName, Panel_ActionsRadial.RadialGearDelegate callback, GearItem gi, bool greyOut = false, bool showCrafting = false, int numItems = 1)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	public void OverrideSpriteWithGearIcon(string textureName, bool greyOut, string hoverNameID)
	{
	}

	[Calls(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	public void OverrideSpriteWithGearIcon(GearItem gi, Panel_ActionsRadial.RadialGearDelegate callback, bool greyOut, string hoverNameID)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowBodyCarryRadial")]
	public void OverrideHoverText(string overrideID)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsHoveredOver()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GearItem GetGearItem()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ShouldShowCraftingUI()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[CallsUnknownMethods(Count = 7)]
	public bool IsBackButton()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ForceRadialMenuArmCallback")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShowEatRawMeatConfirmPopup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void DoCallbackAction(bool ignoreConfirmPopup = false)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "MaybeBlockMoveInputUntilReleased")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(RadialMenuArm), Member = "CreateWaterPlacement")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateStackable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void DoAltClickAction()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "InstantiateWater")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[CallsUnknownMethods(Count = 8)]
	private GameObject CreateWaterPlacement()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetRadialInfo")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetRadialInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	private Color GetRadialIconColor(Panel_ActionsRadial.RadialInfo radialInfo)
	{
		return default(Color);
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetRadialInfoGear")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(Inventory), Member = "GetNumTorches")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GetNumStones")]
	private void UpdateStackLabel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RadialMenuArm()
	{
	}
}
