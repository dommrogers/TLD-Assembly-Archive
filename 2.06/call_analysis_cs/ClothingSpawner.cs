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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[Calls(Type = typeof(ClothingSpawner), Member = "MaybeSpawnTorso")]
	private void Update()
	{
	}

	[Calls(Type = typeof(ClothingSpawner), Member = "SpawnMesh")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "Update")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ClothingSpawner), Member = "ListContains")]
	[Calls(Type = typeof(ClothingSpawner), Member = "ListContains")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(ClothingSpawner), Member = "GetCurrentHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void MaybeSpawnHands()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CallsUnknownMethods(Count = 13)]
	public void EnableActiveClothing(bool enable)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingSpawner), Member = "GetCurrentHands")]
	public string SetHandMeshState(string name)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "SetHandMeshState")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	private List<MeshSet> GetCurrentHands()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[CallsUnknownMethods(Count = 2)]
	private bool ListContains(List<GameObject> gs, GameObject prefab)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private bool ListContains(List<MeshAssociation> mas, GameObject prefab)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ClothingSpawner), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "Start")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ClothingSpawner), Member = "SpawnMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	private void MaybeSpawnTorso()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_rootBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode")]
	[Calls(Type = typeof(UseParentBones), Member = "DoWork")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnTorso")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_updateWhenOffscreen")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private GameObject SpawnMesh(GameObject prefab)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public ClothingSpawner()
	{
	}
}
