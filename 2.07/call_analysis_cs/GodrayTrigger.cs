using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GodrayTrigger : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void OnTriggerExit(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerStay(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GodrayTrigger()
	{
	}
}
