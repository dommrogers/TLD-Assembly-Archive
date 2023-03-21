using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericButtonMouseSpawner : MonoBehaviour
{
	public GameObject m_Prefab;

	public string m_LocID;

	public int m_BackgroundWidthOverride;

	public int m_BackgroundHeightOverride;

	public int m_InnerGlowWidthOverride;

	public int m_BackGlowWidthOverride;

	public List<EventDelegate> onClick;

	public GameObject m_SpawnedObject;

	private UIButton[] m_UIButtonArray;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "AssignValuesToSpawnedObject")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CalledBy(Type = typeof(UIControllerScheme), Member = "Awake")]
	public void Awake()
	{
	}

	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "Awake")]
	[CallsUnknownMethods(Count = 62)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CallsDeduplicatedMethods(Count = 31)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 11)]
	public void SetLocID(string locID)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateMouseConfirmText")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	public void SetText(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "EnableStandardSelectionButtons")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "EnableAlternateSelectionButtons")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	public void EnableMouseButton(bool isEnabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void ShowMouseButton(bool show)
	{
	}

	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "AssignValuesToSpawnedObject")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "Awake")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void InstantiateObjectIfNoneExists()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public GenericButtonMouseSpawner()
	{
	}
}
