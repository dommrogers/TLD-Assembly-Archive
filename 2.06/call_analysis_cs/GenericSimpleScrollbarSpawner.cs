using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericSimpleScrollbarSpawner : MonoBehaviour
{
	public GameObject m_Prefab;

	public int m_Depth;

	public List<EventDelegate> onChange;

	public GameObject m_SpawnedObject;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Initialize")]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(GenericSimpleScrollbarSpawner), Member = "AssignValuesToSpawnedObject")]
	[CalledBy(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Initialize")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	private void OnDragFinished()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public GenericSimpleScrollbarSpawner()
	{
	}
}
