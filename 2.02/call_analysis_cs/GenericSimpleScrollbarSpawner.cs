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

	[CalledBy(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Awake")]
	[CalledBy(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(GenericSimpleScrollbarSpawner), Member = "AssignValuesToSpawnedObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Initialize()
	{
	}

	[CalledBy(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 24)]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDragFinished()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public GenericSimpleScrollbarSpawner()
	{
	}
}
