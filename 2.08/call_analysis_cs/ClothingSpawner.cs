using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ClothingSpawner : MonoBehaviour
{
	[Serializable]
	public class MeshSet
	{
		public string m_Name;

		public List<GameObject> m_MeshPrefabs;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public MeshSet()
		{
		}
	}

	private struct MeshAssociation
	{
		public GameObject m_Instantiated;

		public GameObject m_Prefab;
	}

	public GameObject m_ClothingParent;

	public GameObject m_Origin;

	public GameObject m_SkinnedMeshReference;

	public GameObject m_SandboxTorsoPrefab;

	public GameObject m_StoryTorsoPrefab;

	private List<MeshSet> m_MaleHands;

	private List<MeshSet> m_FemaleHands;

	private List<MeshSet> m_MaleHandsStory;

	private List<MeshSet> m_FemaleHandsStory;

	private MeshAssociation m_CurrentTorso;

	private List<MeshAssociation> m_CurrentHands;

	private int m_CurrentHandState;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[Calls(Type = typeof(ClothingSpawner), Member = "MaybeSpawnTorso")]
	private void Start()
	{
	}

	[Calls(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingSpawner), Member = "MaybeSpawnTorso")]
	private void Update()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ClothingSpawner), Member = "SpawnMesh")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "Update")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "Start")]
	[Calls(Type = typeof(ClothingSpawner), Member = "ListContains")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(ClothingSpawner), Member = "ListContains")]
	[Calls(Type = typeof(ClothingSpawner), Member = "GetCurrentHands")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	private void MaybeSpawnHands()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void EnableActiveClothing(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingSpawner), Member = "GetCurrentHands")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string SetHandMeshState(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "SetHandMeshState")]
	private List<MeshSet> GetCurrentHands()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[CallerCount(Count = 1)]
	private bool ListContains(List<GameObject> gs, GameObject prefab)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[CallsUnknownMethods(Count = 4)]
	private bool ListContains(List<MeshAssociation> mas, GameObject prefab)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "Update")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "Start")]
	[Calls(Type = typeof(ClothingSpawner), Member = "SpawnMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeSpawnTorso()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnTorso")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[Calls(Type = typeof(UseParentBones), Member = "DoWork")]
	[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_updateWhenOffscreen")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_rootBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private GameObject SpawnMesh(GameObject prefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public ClothingSpawner()
	{
	}
}
