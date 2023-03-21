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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 12)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIToggledObjects), Member = "Set")]
	[Calls(Type = typeof(UIToggledObjects), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Toggle()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIToggledObjects), Member = "Toggle")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(UIToggledObjects), Member = "Toggle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Set(GameObject go, bool state)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIToggledObjects()
	{
	}
}
