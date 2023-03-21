using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InaccessibleGearContainer : MonoBehaviour
{
	private static InaccessibleGearContainer[] s_InaccessibleGearContainers;

	private Container m_Container;

	private Vector3 m_Position;

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "InitializeAllForCurrentScene")]
	[CalledBy(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[CalledBy(Type = typeof(SceneManager), Member = "OnSceneLoaded")]
	[CallsUnknownMethods(Count = 5)]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	private void AddGearToContainer(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	private float SqrDistanceFrom(Vector3 pos)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	public static void InitializeAllForCurrentScene()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void UpdateVisibilityForAll()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[CallsUnknownMethods(Count = 3)]
	public static void AddGearToNearestContainer(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "FindNearest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	public static void AddGearToNearestContainer(GearItem gi, Vector3 pos)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "FindNearest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContainerManager), Member = "Deserialize")]
	public static void LoadSceneIntoNearestContainer(string guid, Vector3 pos)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
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
