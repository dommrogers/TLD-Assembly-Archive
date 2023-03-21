using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InaccessibleGearContainer : MonoBehaviour
{
	private static InaccessibleGearContainer[] s_InaccessibleGearContainers;

	private Container m_Container;

	private Vector3 m_Position;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "InitializeAllForCurrentScene")]
	[CalledBy(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[CallsUnknownMethods(Count = 6)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[CallsUnknownMethods(Count = 2)]
	private void AddGearToContainer(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "FindNearest")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float SqrDistanceFrom(Vector3 pos)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "Initialize")]
	[CallsUnknownMethods(Count = 5)]
	public static void InitializeAllForCurrentScene()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 7)]
	public static void UpdateVisibilityForAll()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	public static void AddGearToNearestContainer(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "FindNearest")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public static void AddGearToNearestContainer(GearItem gi, Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "FindNearest")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlotUsingGuid")]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	[Calls(Type = typeof(ContainerManager), Member = "Deserialize")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[CallsUnknownMethods(Count = 10)]
	public static void LoadSceneIntoNearestContainer(string guid, Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "SqrDistanceFrom")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private static InaccessibleGearContainer FindNearest(Vector3 pos)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public InaccessibleGearContainer()
	{
	}
}
