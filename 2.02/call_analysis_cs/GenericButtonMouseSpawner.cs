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

	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CalledBy(Type = typeof(UIControllerScheme), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "AssignValuesToSpawnedObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 62)]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void SetLocID(string locID)
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateMouseConfirmText")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetText(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "EnableAlternateSelectionButtons")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "EnableStandardSelectionButtons")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void EnableMouseButton(bool isEnabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void ShowMouseButton(bool show)
	{
	}

	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "AssignValuesToSpawnedObject")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void InstantiateObjectIfNoneExists()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public GenericButtonMouseSpawner()
	{
	}
}
