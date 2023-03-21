using System;
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

	[CalledBy(Type = typeof(UIControllerScheme), Member = "Awake")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "AssignValuesToSpawnedObject")]
	public void Awake()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "Awake")]
	[CallsUnknownMethods(Count = 54)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CallsDeduplicatedMethods(Count = 36)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshDismantlePanel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdatePanelDisplays")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdatePanelDisplays")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void SetLocID(string locID)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "ActivateBackButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CalledBy(Type = typeof(BasicMenu), Member = "UpdateMouseConfirmText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	public void SetText(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "EnableStandardSelectionButtons")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "EnableAlternateSelectionButtons")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "Awake")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "AssignValuesToSpawnedObject")]
	[CalledBy(Type = typeof(GenericButtonMouseSpawner), Member = "SetText")]
	private void InstantiateObjectIfNoneExists()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GenericButtonMouseSpawner()
	{
	}
}
