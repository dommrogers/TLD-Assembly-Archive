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
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Animation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 61)]
	[CallsUnknownMethods(Count = 126)]
	private void OnGUI()
	{
	}

	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "OnGUI")]
	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
