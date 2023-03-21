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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "Initialize")]
	public static void InitializeAllForCurrentScene()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
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

	[Calls(Type = typeof(InaccessibleGearContainer), Member = "FindNearest")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public static void AddGearToNearestContainer(GearItem gi, Vector3 pos)
	{
	}

	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContainerManager), Member = "Deserialize")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "FindNearest")]
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
