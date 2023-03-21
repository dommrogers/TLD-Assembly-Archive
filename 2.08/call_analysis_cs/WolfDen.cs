using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class WolfDen : MonoBehaviour
{
	public SpawnRegion m_DenSpawnRegion;

	public SpawnRegion m_WanderSpawnRegion;

	public SpawnRegion m_AlphaSpawnRegion;

	public LocalizedString m_DestroyedDisplayName;

	public string m_StartFireIconName;

	public LocalizedString m_StartingFireProgress;

	public float m_StartFireRealTimeSeconds;

	public float m_StartFireGameTimeMinutes;

	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private string m_Guid;

	private bool m_IsDestroyed;

	private List<ActionPickerItemData> m_ItemData;

	private static List<WolfDen> s_WolfDenObjects;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(WolfDen), Member = "Deserialize")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	public void SetDenEnabled(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(WolfDen), Member = "PerformInteraction")]
	public bool HasRequiredItemsInInventory()
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(WolfDen), Member = "HasRequiredItemsInInventory")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsUnknownMethods(Count = 1)]
	public void OnStartFire()
	{
	}

	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	public void OnStartFireComplete(bool success, bool playerCancel, float progress)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void CancelStartFire()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(WolfDen), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WolfDen), Member = "SetDenEnabled")]
	[CalledBy(Type = typeof(WolfDen), Member = "DeserializeAll")]
	private void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static WolfDen FindWolfDenByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public WolfDen()
	{
	}
}
