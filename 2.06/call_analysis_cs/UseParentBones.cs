using System.Collections.Generic;
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

	[CalledBy(Type = typeof(ClothingSpawner), Member = "SpawnMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "get_bones")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 19)]
	public void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UseParentBones()
	{
	}
}
