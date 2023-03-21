using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gear;
using TLD.UI.Generics;
using UnityEngine;

public class EquipItemPopup : MonoBehaviour
{
	private Panel_HUD m_HUD;

	private PanelReference<Panel_Actions> m_Actions;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	public ButtonPrompt m_ButtonPromptFire;

	public ButtonPrompt m_ButtonPromptAltFire;

	public ButtonPrompt m_ButtonPromptReload;

	public ButtonPrompt m_ButtonPromptHolster;

	public ButtonPrompt m_ButtonPromptLeft;

	public ButtonPrompt m_ButtonPromptRight;

	public ButtonPrompt m_ButtonPromptScrollWheel;

	public ButtonPrompt m_ButtonPromptRemoveDecal;

	public UILabel m_LabelDurationValue;

	public UISprite m_SpriteFillDuration;

	public float m_SpriteFillDurationOffset;

	public GameObject m_ObjectDuration;

	public UIWidget m_EquipPopupWidget;

	public GameObject m_EquipPopupTopLeft;

	public GameObject m_EquipPopupBottom;

	public UIWidget m_AmmoWidget;

	public UISprite[] m_ListAmmoSprites;

	public UILabel m_LabelAmmoReserve;

	public UILabel m_LabelItemCount;

	public UIWidget m_RemoveDecalWidget;

	private float m_TimeToHidePopup;

	private float m_TimeToHideAmmo;

	private bool m_ShowingPlaceMeshIcons;

	private string m_FireText;

	private string m_AltFireText;

	private bool m_ShowedAmmoCountForNoRoundsInClip;

	private Vector3 m_ButtonPromptFireOriginalPosition;

	private Vector3 m_ButtonPromptAltFireOriginalPosition;

	private Vector3 m_ButtonPromptCenteredOriginalPosition;

	private bool m_HasInitialized;

	private GearItem m_GearItem;

	private int m_LastReserveValue;

	[Calls(Type = typeof(EquipItemPopup), Member = "HideRemoveDecalPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "InitializeValues")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToRemoveDecalInPlace")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateOverlappingDecalInPlace")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	public void OnOverlappingDecalChange(bool isOverlapping)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ControlModeAllowsInterface")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void InitializeValues()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsHoveringInteractiveObject()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	private void MaybeRepositionAltFireButtonPrompt(string otherButtonText)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	private void MaybeRepositionFireButtonPrompt(string otherButtonText)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CheckForButtomPromptUpdate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CheckForButtomPromptUpdate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallerCount(Count = 5)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	public void ShowPlaceMeshItem(bool show, bool isDecal)
	{
	}

	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnControllerScheme")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetPlaceMeshFireButtonString")]
	[Calls(Type = typeof(PlayerManager), Member = "GetPlaceMeshAltFireButtonString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdatePlacementButtonLabels()
	{
	}

	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Equip_Complete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnIgniteComplete")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnIgniteComplete")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "ShowEquipItemPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnControllerScheme")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnIgniteComplete")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "OnIgniteComplete")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EquipItemPopup), Member = "IsHoveringInteractiveObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void ShowEquippedItem(GearItem gi)
	{
	}

	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "UpdateButtonDisplay")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Update")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	public void ShowGenericPopup(string fireButtonStr, string fireButtonAction, string altFireButtonStr, string altFireButtonAction)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	public void ShowGenericPopupWithDefaultActions(string fireButtonStr, string altFireButtonStr)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ShowAmmoForTime(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void HideEquipPopupWidget()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_AddBearkillerRifle), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	public void HideEquipPopup()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(Action_AddBearkillerRifle), Member = "OnExecute")]
	[Calls(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	public void HideAmmoPopup()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[CallsUnknownMethods(Count = 3)]
	public void HideRemoveDecalPopup()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(FlashlightItem), Member = "GetNormalizedCharge")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool AllowedToHideAmmoPopup()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[Calls(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateButtonStatus()
	{
	}

	[Calls(Type = typeof(HUDManager), Member = "DisplayAmmoOnHUDForTime")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(TorchItem), Member = "GetBurnProgress")]
	[Calls(Type = typeof(Inventory), Member = "GetNumMatches")]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(FlareItem), Member = "GetNormalizedBurnTimeLeft")]
	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetNumNoiseMakers")]
	[Calls(Type = typeof(Inventory), Member = "GetNumStones")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(FlashlightItem), Member = "GetNormalizedCharge")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateAmmoStatus()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void ShowEquipPopupWidget()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(EquipItemPopup), Member = "InitializeValues")]
	[Calls(Type = typeof(HUDManager), Member = "DisplayAmmoOnHUDForTime")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[CallsUnknownMethods(Count = 6)]
	private void ShowItemIcons(string fireButtonStr, string altFireButtonStr, bool showAmmo)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShouldHideAmmoPopup")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	private bool ControlModeAllowsInterface()
	{
		return default(bool);
	}

	[Calls(Type = typeof(EquipItemPopup), Member = "IsHoveringInteractiveObject")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnControllerScheme")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ControlModeAllowsInterface")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallerCount(Count = 2)]
	private bool ShouldHideEquipPopup()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ControlModeAllowsInterface")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private bool ShouldHideAmmoPopup()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	private void SetFillDurationAmount(float value)
	{
	}

	[CallerCount(Count = 0)]
	public EquipItemPopup()
	{
	}
}
