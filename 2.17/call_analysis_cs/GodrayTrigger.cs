using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GodrayTrigger : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerExit(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerStay(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GodrayTrigger()
	{
	}
}
