using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RNode : MonoBehaviour
{
	public GameObject[] m_SpawnPrefabs;

	public int[] m_SpawnWeights;

	public int m_PreviewPrefabIndex;

	public GameObject m_PreviewPrefab;

	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RNode()
	{
	}
}
