using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIInputOnGUI : MonoBehaviour
{
	[NonSerialized]
	private UIInput mInput;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIInputOnGUI()
	{
	}
}
