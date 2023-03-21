using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	public GameObject swordPrefab;

	public GameObject hatPrefab;

	public GameObject glassesPrefab;

	public GameObject workerPrefab;

	public GameObject targetCharacter;

	public MB3_MeshBaker skinnedMeshBaker;

	private GameObject swordInstance;

	private GameObject glassesInstance;

	private GameObject hatInstance;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 11)]
	private void Start()
	{
	}

	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 58)]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 63)]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "OnGUI")]
	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "OnGUI")]
	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "OnGUI")]
	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[CallsUnknownMethods(Count = 3)]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MB_SkinnedMeshSceneController()
	{
	}
}
