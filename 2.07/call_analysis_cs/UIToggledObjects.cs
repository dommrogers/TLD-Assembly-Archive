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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIToggledObjects), Member = "Set")]
	[Calls(Type = typeof(UIToggledObjects), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Toggle()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIToggledObjects), Member = "Toggle")]
	[CalledBy(Type = typeof(UIToggledObjects), Member = "Toggle")]
	private void Set(GameObject go, bool state)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIToggledObjects()
	{
	}
}
