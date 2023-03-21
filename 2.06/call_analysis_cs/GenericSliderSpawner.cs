using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericSliderSpawner : MonoBehaviour
{
	public GameObject m_Prefab;

	public bool m_LabelWillBeOverridden;

	public List<EventDelegate> onChange;

	public GameObject m_SpawnedObject;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public GenericSliderSpawner()
	{
	}
}
