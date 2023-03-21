using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIInputOnGUI : MonoBehaviour
{
	[NonSerialized]
	private UIInput mInput;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIInputOnGUI()
	{
	}
}
