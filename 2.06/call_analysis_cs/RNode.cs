using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RNode : MonoBehaviour
{
	public GameObject[] m_SpawnPrefabs;

	public int[] m_SpawnWeights;

	public int m_PreviewPrefabIndex;

	public GameObject m_PreviewPrefab;

	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public RNode()
	{
	}
}
