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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GenericSimpleScrollbarSpawner), Member = "AssignValuesToSpawnedObject")]
	[CalledBy(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Awake")]
	[CalledBy(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	public void Initialize()
	{
	}

	[Calls(Type = typeof(Transform), Member = "Find")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Initialize")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	private void OnDragFinished()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public GenericSimpleScrollbarSpawner()
	{
	}
}
