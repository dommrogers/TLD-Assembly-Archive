using System;
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
	[CallerCount(Count = 5)]
	public Panel_ActionsRadial.RadialInfo GetRadialInfo()
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetRadialInfo")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelSelectSlotRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowLightSourceRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowWeaponRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowToolsRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public void SetEnabled(bool shouldEnable)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelSelectSlotRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowLightSourceRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowWeaponRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowToolsRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowBodyCarryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void SetHoverColor(bool isHovering)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelSelectSlotRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowSatchelRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelection")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RadialMenuArm), Member = "SetEnabled")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	public void SetRadialInfo(Panel_ActionsRadial.RadialInfo radialInfo, Action callback, bool greyOut = false, bool showHighlight = false)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "AddRadialSelectionGear")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowGearRadial")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 8)]
	public void SetRadialInfoGear(Panel_ActionsRadial.RadialGearDelegate callback, GearItem gi)
	{
	}

	[CalledBy(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public void OverrideSpriteWithGearIcon(string textureName, bool greyOut, string hoverNameID)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[Calls(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CallsUnknownMethods(Count = 1)]
	public void OverrideSpriteWithGearIcon(GearItem gi, Panel_ActionsRadial.RadialGearDelegate callback, bool greyOut, string hoverNameID)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowBodyCarryRadial")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void OverrideHoverText(string overrideID)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsHoveredOver()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public string GetHoverText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public GearItem GetGearItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEmpty()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsBackButton()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowEatRawMeatConfirmPopup")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ForceRadialMenuArmCallback")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShowEatRawMeatConfirmPopup")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void DoCallbackAction(bool ignoreConfirmPopup = false)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateStackable")]
	[Calls(Type = typeof(RadialMenuArm), Member = "GetWaterPlacementValues")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GameManager), Member = "MaybeBlockMoveInputUntilReleased")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void DoAltClickAction()
	{
	}

	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "CreateWaterPlacement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool GetWaterPlacementValues(out GameObject prefab, out float volume)
	{
		prefab = null;
		volume = default(float);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadialMenuArm), Member = "GetWaterPlacementValues")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetRadialInfoGear")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "OverrideSpriteWithGearIcon")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetNumStones")]
	[Calls(Type = typeof(Inventory), Member = "GetNumTorches")]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateStackLabel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RadialMenuArm()
	{
	}
}
