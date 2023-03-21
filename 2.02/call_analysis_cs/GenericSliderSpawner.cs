using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericSliderSpawner : MonoBehaviour
{
	public GameObject m_Prefab;

	public bool m_LabelWillBeOverridden;

	public List<EventDelegate> onChange;

	public GameObject m_SpawnedObject;

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsUnknownMethods(Count = 19)]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public GenericSliderSpawner()
	{
	}
}
