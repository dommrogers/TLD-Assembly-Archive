using System;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class RadialMenuArm : MonoBehaviour
{
	private Panel_ActionsRadial m_ActionsRadial;

	private PanelReference<Panel_PickWater> m_PickWater;

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

	private bool m_IsGreyedOut;

	private AK.Wwise.Event m_Audio;

	private bool m_IsHoveredOver;

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public Panel_ActionsRadial.RadialInfo GetRadialInfo()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowToolsRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowWeaponRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetRadialInfo")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowLightSourceRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelSelectSlotRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	public void SetEnabled(bool shouldEnable)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowBodyCarryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowToolsRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowWeaponRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowLightSourceRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelSelectSlotRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	public void SetHoverColor(bool isHovering)
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelSelectSlotRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public void SetRadialInfo(Panel_ActionsRadial.RadialInfo radialInfo, Action callback, bool greyOut = false, bool showHighlight = false)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[Calls(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	public void SetRadialInfoGear(string textureName, Panel_ActionsRadial.RadialGearDelegate callback, GearItem gi)
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void OverrideSpriteWithGearIcon(string textureName, bool greyOut, string hoverNameID)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void OverrideSpriteWithGearIcon(GearItem gi, Panel_ActionsRadial.RadialGearDelegate callback, bool greyOut, string hoverNameID)
	{
	}

	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsBackButton()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ForceRadialMenuArmCallback")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowEatRawMeatConfirmPopup")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShowEatRawMeatConfirmPopup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void DoCallbackAction(bool ignoreConfirmPopup = false)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "MaybeBlockMoveInputUntilReleased")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialMenuArm), Member = "GetWaterPlacementValues")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateStackable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void DoAltClickAction()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "CreateWaterPlacement")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	private bool GetWaterPlacementValues(out GameObject prefab, out float volume)
	{
		prefab = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref volume) = null;
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(RadialMenuArm), Member = "GetWaterPlacementValues")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private GameObject CreateWaterPlacement()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private Color GetRadialIconColor(Panel_ActionsRadial.RadialInfo radialInfo)
	{
		return default(Color);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetRadialInfoGear")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(Inventory), Member = "GetNumTorches")]
	[Calls(Type = typeof(Inventory), Member = "GetNumStones")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateStackLabel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RadialMenuArm()
	{
	}
}
