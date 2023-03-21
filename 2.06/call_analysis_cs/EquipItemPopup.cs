using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gear;
using TLD.SaveState;
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
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
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
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ControlModeAllowsInterface")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[CallsDeduplicatedMethods(Count = 29)]
	[CallsUnknownMethods(Count = 14)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Awake")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void InitializeValues()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CheckForButtomPromptUpdate")]
	[CallerCount(Count = 5)]
	public void ShowPlaceMeshItem(bool show, bool isDecal)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetPlaceMeshFireButtonString")]
	[Calls(Type = typeof(PlayerManager), Member = "GetPlaceMeshAltFireButtonString")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionFireButtonPrompt")]
	[Calls(Type = typeof(EquipItemPopup), Member = "MaybeRepositionAltFireButtonPrompt")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdatePlacementButtonLabels()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnIgniteComplete")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "ShowEquipItemPopup")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnIgniteComplete")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnIgniteComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Generic_Equip_Complete")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "OnIgniteComplete")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EquipItemPopup), Member = "IsHoveringInteractiveObject")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
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
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 1)]
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
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[CalledBy(Type = typeof(Action_AddBearkillerRifle), Member = "OnExecute")]
	[CallerCount(Count = 8)]
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
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void HideRemoveDecalPopup()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlashlightItem), Member = "GetNormalizedCharge")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 5)]
	private bool AllowedToHideAmmoPopup()
	{
		return false;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateButtonStatus()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Inventory), Member = "GetNumNoiseMakers")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(FlashlightItem), Member = "GetNormalizedCharge")]
	[Calls(Type = typeof(Inventory), Member = "GetNumStones")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(TorchItem), Member = "GetBurnProgress")]
	[Calls(Type = typeof(Inventory), Member = "GetNumMatches")]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(FlareItem), Member = "GetNormalizedBurnTimeLeft")]
	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[Calls(Type = typeof(HUDManager), Member = "DisplayAmmoOnHUDForTime")]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 16)]
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
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EquipItemPopup), Member = "InitializeValues")]
	[Calls(Type = typeof(HUDManager), Member = "DisplayAmmoOnHUDForTime")]
	[Calls(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private void ShowItemIcons(string fireButtonStr, string altFireButtonStr, bool showAmmo)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShouldHideEquipPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShouldHideAmmoPopup")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 6)]
	private bool ShouldHideEquipPopup()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ControlModeAllowsInterface")]
	[CallsUnknownMethods(Count = 3)]
	private bool ShouldHideAmmoPopup()
	{
		return false;
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
