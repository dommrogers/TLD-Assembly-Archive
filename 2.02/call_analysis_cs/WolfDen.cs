using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WolfDen : MonoBehaviour
{
	public SpawnRegion m_DenSpawnRegion;

	public SpawnRegion m_WanderSpawnRegion;

	public SpawnRegion m_AlphaSpawnRegion;

	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_DestroyedDisplayName;

	public string m_StartFireIconName;

	public LocalizedString m_StartingFireProgress;

	public float m_StartFireRealTimeSeconds;

	public float m_StartFireGameTimeMinutes;

	private string m_Guid;

	private bool m_IsDestroyed;

	private static List<WolfDen> s_WolfDenObjects;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(WolfDen), Member = "Deserialize")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	public void SetDenEnabled(bool enabled)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(WolfDen), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool HasRequiredItemsInInventory()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WolfDen), Member = "HasRequiredItemsInInventory")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 24)]
	[CallsDeduplicatedMethods(Count = 5)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnStartFire()
	{
	}

	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	public void OnStartFireComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void CancelStartFire()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(WolfDen), Member = "Serialize")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(WolfDen), Member = "FindWolfDenByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WolfDen), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 10)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(WolfDen), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 9)]
	private string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(WolfDen), Member = "DeserializeAll")]
	[Calls(Type = typeof(WolfDen), Member = "SetDenEnabled")]
	private void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(WolfDen), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	private static WolfDen FindWolfDenByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public WolfDen()
	{
	}
}
