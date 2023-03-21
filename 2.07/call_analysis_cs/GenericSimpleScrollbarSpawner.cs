using System;
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GenericSimpleScrollbarSpawner), Member = "AssignValuesToSpawnedObject")]
	[CalledBy(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Awake")]
	[CalledBy(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	public void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Initialize")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
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
	[CallsUnknownMethods(Count = 1)]
	public GenericSimpleScrollbarSpawner()
	{
	}
}
