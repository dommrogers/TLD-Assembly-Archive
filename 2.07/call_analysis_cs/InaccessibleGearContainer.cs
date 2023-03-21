using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InaccessibleGearContainer : MonoBehaviour
{
	private static InaccessibleGearContainer[] s_InaccessibleGearContainers;

	private Container m_Container;

	private Vector3 m_Position;

	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "InitializeAllForCurrentScene")]
	[CalledBy(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[CalledBy(Type = typeof(SceneManager), Member = "OnSceneLoaded")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[CallsUnknownMethods(Count = 1)]
	private void AddGearToContainer(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	private float SqrDistanceFrom(Vector3 pos)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	public static void InitializeAllForCurrentScene()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void UpdateVisibilityForAll()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void AddGearToNearestContainer(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "FindNearest")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void AddGearToNearestContainer(GearItem gi, Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "FindNearest")]
	[Calls(Type = typeof(SaveGameSlots), Member = "TryLoadDataFromSlotUsingGuid")]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	[Calls(Type = typeof(ContainerManager), Member = "Deserialize")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void LoadSceneIntoNearestContainer(string guid, Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static InaccessibleGearContainer FindNearest(Vector3 pos)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public InaccessibleGearContainer()
	{
	}
}
