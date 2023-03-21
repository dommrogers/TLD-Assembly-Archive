using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InaccessibleGearContainer : MonoBehaviour
{
	private static InaccessibleGearContainer[] s_InaccessibleGearContainers;

	private Container m_Container;

	private Vector3 m_Position;

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SceneManager), Member = "OnSceneLoaded")]
	[CalledBy(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "InitializeAllForCurrentScene")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	public static void UpdateVisibilityForAll()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	public static void AddGearToNearestContainer(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "FindNearest")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void AddGearToNearestContainer(GearItem gi, Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[Calls(Type = typeof(ContainerManager), Member = "Deserialize")]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "FindNearest")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public static void LoadSceneIntoNearestContainer(string guid, Vector3 pos)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[CallsUnknownMethods(Count = 2)]
	private static InaccessibleGearContainer FindNearest(Vector3 pos)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public InaccessibleGearContainer()
	{
	}
}
