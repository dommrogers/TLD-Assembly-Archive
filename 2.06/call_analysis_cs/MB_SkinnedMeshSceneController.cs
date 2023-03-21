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

	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 55)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[CallsDeduplicatedMethods(Count = 63)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void OnGUI()
	{
	}

	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "OnGUI")]
	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "OnGUI")]
	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "OnGUI")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MB_SkinnedMeshSceneController()
	{
	}
}
