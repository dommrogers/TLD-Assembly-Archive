using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UseParentBones : MonoBehaviour
{
	public GameObject m_TargetSkin;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "SpawnMesh")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "get_bones")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UseParentBones()
	{
	}
}
