using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIInputOnGUI : MonoBehaviour
{
	[NonSerialized]
	private UIInput mInput;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Event), Member = "get_current")]
	[Calls(Type = typeof(Event), Member = "get_current")]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UIInputOnGUI()
	{
	}
}
