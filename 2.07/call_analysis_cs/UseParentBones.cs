using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UseParentBones : MonoBehaviour
{
	public GameObject m_TargetSkin;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "SpawnMesh")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "get_bones")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UseParentBones()
	{
	}
}
