using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DoubleClickButton : MonoBehaviour
{
	public List<EventDelegate> m_OnClick;

	public List<EventDelegate> m_OnDoubleClick;

	private float m_DoubleClickTimer;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public DoubleClickButton()
	{
	}
}
