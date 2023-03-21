using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIToggledObjects : MonoBehaviour
{
	public List<GameObject> activate;

	public List<GameObject> deactivate;

	private GameObject target;

	private bool inverse;

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIToggledObjects), Member = "Set")]
	[Calls(Type = typeof(UIToggledObjects), Member = "Set")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void Toggle()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIToggledObjects), Member = "Toggle")]
	[CalledBy(Type = typeof(UIToggledObjects), Member = "Toggle")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void Set(GameObject go, bool state)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public UIToggledObjects()
	{
	}
}
