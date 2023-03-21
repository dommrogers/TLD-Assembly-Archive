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
		[CallerCount(Count = 2)]
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
	[Calls(Type = typeof(ClothingSpawner), Member = "MaybeSpawnTorso")]
	[Calls(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(ClothingSpawner), Member = "MaybeSpawnTorso")]
	[Calls(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void Update()
	{
	}

	[Calls(Type = typeof(ClothingSpawner), Member = "SpawnMesh")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "Start")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "Update")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(ClothingSpawner), Member = "ListContains")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(ClothingSpawner), Member = "ListContains")]
	[Calls(Type = typeof(ClothingSpawner), Member = "GetCurrentHands")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void MaybeSpawnHands()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public void EnableActiveClothing(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ClothingSpawner), Member = "GetCurrentHands")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public string SetHandMeshState(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "SetHandMeshState")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	private List<MeshSet> GetCurrentHands()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private bool ListContains(List<GameObject> gs, GameObject prefab)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[CallsUnknownMethods(Count = 8)]
	private bool ListContains(List<MeshAssociation> mas, GameObject prefab)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ClothingSpawner), Member = "SpawnMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeSpawnTorso()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnHands")]
	[Calls(Type = typeof(UseParentBones), Member = "DoWork")]
	[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_updateWhenOffscreen")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_rootBone")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(ClothingSpawner), Member = "MaybeSpawnTorso")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private GameObject SpawnMesh(GameObject prefab)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public ClothingSpawner()
	{
	}
}
