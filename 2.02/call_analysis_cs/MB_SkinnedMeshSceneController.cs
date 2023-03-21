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
	[Calls(Type = typeof(Animation), Member = "Play")]
	[CallsUnknownMethods(Count = 16)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsUnknownMethods(Count = 126)]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[CallsDeduplicatedMethods(Count = 64)]
	[CallerCount(Count = 0)]
	private void OnGUI()
	{
	}

	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "OnGUI")]
	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "OnGUI")]
	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "OnGUI")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(MB_SkinnedMeshSceneController), Member = "SearchHierarchyForBone")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
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
