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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "AssignValuesToSpawnedObject")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CalledBy(Type = typeof(UIControllerScheme), Member = "Awake")]
	public void Awake()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "Awake")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 30)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	public void SetLocID(string locID)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateMouseConfirmText")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	public void SetText(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "EnableAlternateSelectionButtons")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "EnableStandardSelectionButtons")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public void EnableMouseButton(bool isEnabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void ShowMouseButton(bool show)
	{
	}

	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "AssignValuesToSpawnedObject")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "Awake")]
	private void InstantiateObjectIfNoneExists()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public GenericButtonMouseSpawner()
	{
	}
}
