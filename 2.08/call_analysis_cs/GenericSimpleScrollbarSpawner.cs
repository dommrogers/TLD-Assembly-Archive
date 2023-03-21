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

	[CalledBy(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(GenericSimpleScrollbarSpawner), Member = "AssignValuesToSpawnedObject")]
	[CalledBy(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Awake")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Initialize")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
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
