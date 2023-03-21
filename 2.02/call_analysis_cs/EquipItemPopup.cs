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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideRemoveDecalPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "InitializeValues")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateOverlappingDecalInPlace")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToRemoveDecalInPlace")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnOverlappingDecalChange(bool isOverlapping)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ControlModeAllowsInterface")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallsUnknownMethods(Count = 55)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void InitializeValues()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsHoveringInteractiveObject()
	{
		return false;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeRepositionAltFireButtonPrompt(string otherButtonText)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeRepositionFireButtonPrompt(string otherButtonText)
	{
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CheckForButtomPromptUpdate")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "GetPlaceMeshFireButtonString")]
	[Calls(Type = typeof(PlayerManager), Member = "GetPlaceMeshAltFireButtonString")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideRemoveDecalPopup")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void ShowPlaceMeshItem(bool show, bool isDecal)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetPlaceMeshFireButtonString")]
	[Calls(Type = typeof(PlayerManager), Member = "GetPlaceMeshAltFireButtonString")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 24)]
	private void UpdatePlacementButtonLabels()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnIgniteComplete")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "ShowEquipItemPopup")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "OnIgniteComplete")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnIgniteComplete")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnIgniteComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Equip_Complete")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(EquipItemPopup), Member = "IsHoveringInteractiveObject")]
	[Calls(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 39)]
	public void ShowEquippedItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Update")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "UpdateButtonDisplay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void ShowGenericPopup(string fireButtonStr, string fireButtonAction, string altFireButtonStr, string altFireButtonAction)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void ShowGenericPopupWithDefaultActions(string fireButtonStr, string altFireButtonStr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ShowAmmoForTime(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void HideEquipPopupWidget()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[CalledBy(Type = typeof(Action_AddBearkillerRifle), Member = "OnExecute")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void HideEquipPopup()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(Action_AddBearkillerRifle), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void HideAmmoPopup()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void HideRemoveDecalPopup()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlashlightItem), Member = "GetNormalizedCharge")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	private bool AllowedToHideAmmoPopup()
	{
		return false;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	private void UpdateButtonStatus()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Inventory), Member = "GetNumNoiseMakers")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[Calls(Type = typeof(EquipItemPopup), Member = "SetFillDurationAmount")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(FlashlightItem), Member = "GetNormalizedCharge")]
	[Calls(Type = typeof(Inventory), Member = "GetNumStones")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(TorchItem), Member = "GetModifiedBurnLifetimeMinutes")]
	[Calls(Type = typeof(Utils), Member = "GetNumMatches")]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(FlareItem), Member = "GetNormalizedBurnTimeLeft")]
	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(HUDManager), Member = "DisplayAmmoOnHUDForTime")]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 79)]
	private void UpdateAmmoStatus()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void ShowEquipPopupWidget()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EquipItemPopup), Member = "InitializeValues")]
	[Calls(Type = typeof(HUDManager), Member = "DisplayAmmoOnHUDForTime")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	private void ShowItemIcons(string fireButtonStr, string altFireButtonStr, bool showAmmo)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShouldHideAmmoPopup")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool ControlModeAllowsInterface()
	{
		return false;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ControlModeAllowsInterface")]
	[Calls(Type = typeof(EquipItemPopup), Member = "IsHoveringInteractiveObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private bool ShouldHideEquipPopup()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ControlModeAllowsInterface")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private bool ShouldHideAmmoPopup()
	{
		return false;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetFillDurationAmount(float value)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EquipItemPopup()
	{
	}
}
