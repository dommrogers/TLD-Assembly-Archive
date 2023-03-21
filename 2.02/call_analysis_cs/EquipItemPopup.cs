using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class EquipItemPopup : MonoBehaviour
{
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

	[Calls(Type = typeof(EquipItemPopup), Member = "InitializeValues")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideRemoveDecalPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 14)]
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
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToRemoveDecalInPlace")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateOverlappingDecalInPlace")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	public void OnOverlappingDecalChange(bool isOverlapping)
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 55)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ControlModeAllowsInterface")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[Calls(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void InitializeValues()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsHoveringInteractiveObject()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
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

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CheckForButtomPromptUpdate")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CheckForButtomPromptUpdate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideRemoveDecalPopup")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[Calls(Type = typeof(PlayerManager), Member = "GetPlaceMeshAltFireButtonString")]
	[Calls(Type = typeof(PlayerManager), Member = "GetPlaceMeshFireButtonString")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	public void ShowPlaceMeshItem(bool show, bool isDecal)
	{
	}

	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "GetPlaceMeshFireButtonString")]
	[Calls(Type = typeof(PlayerManager), Member = "GetPlaceMeshAltFireButtonString")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdatePlacementButtonLabels()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnControllerScheme")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Equip_Complete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnIgniteComplete")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnIgniteComplete")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "OnIgniteComplete")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "ShowEquipItemPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnIgniteComplete")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Localization), Member = "Get")]
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
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(EquipItemPopup), Member = "IsHoveringInteractiveObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ShowEquippedItem(GearItem gi)
	{
	}

	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "UpdateButtonDisplay")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Update")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	public void ShowGenericPopup(string fireButtonStr, string fireButtonAction, string altFireButtonStr, string altFireButtonAction)
	{
	}

	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(Action_AddBearkillerRifle), Member = "OnExecute")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[CallerCount(Count = 9)]
	public void HideEquipPopup()
	{
	}

	[CalledBy(Type = typeof(Action_AddBearkillerRifle), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	public void HideAmmoPopup()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	public void HideRemoveDecalPopup()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(FlashlightItem), Member = "GetNormalizedCharge")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool AllowedToHideAmmoPopup()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateButtonStatus()
	{
	}

	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[Calls(Type = typeof(FlareItem), Member = "GetNormalizedBurnTimeLeft")]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(Utils), Member = "GetNumMatches")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(TorchItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[CallsUnknownMethods(Count = 79)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(EquipItemPopup), Member = "SetFillDurationAmount")]
	[Calls(Type = typeof(HUDManager), Member = "DisplayAmmoOnHUDForTime")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EquipItemPopup), Member = "SetFillDurationAmount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetNumStones")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(EquipItemPopup), Member = "SetFillDurationAmount")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(FlashlightItem), Member = "GetNormalizedCharge")]
	[Calls(Type = typeof(EquipItemPopup), Member = "SetFillDurationAmount")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[Calls(Type = typeof(Inventory), Member = "GetNumNoiseMakers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	private void UpdateAmmoStatus()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void ShowEquipPopupWidget()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[Calls(Type = typeof(HUDManager), Member = "DisplayAmmoOnHUDForTime")]
	[Calls(Type = typeof(EquipItemPopup), Member = "InitializeValues")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	private void ShowItemIcons(string fireButtonStr, string altFireButtonStr, bool showAmmo)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShouldHideAmmoPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ControlModeAllowsInterface()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnControllerScheme")]
	[Calls(Type = typeof(EquipItemPopup), Member = "IsHoveringInteractiveObject")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ControlModeAllowsInterface")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ShouldHideEquipPopup()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ControlModeAllowsInterface")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private bool ShouldHideAmmoPopup()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetFillDurationAmount(float value)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EquipItemPopup()
	{
	}
}
