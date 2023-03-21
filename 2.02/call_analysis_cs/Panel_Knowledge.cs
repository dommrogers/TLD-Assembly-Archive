using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Knowledge : Panel_Base
{
	public GameObject TableObject;

	public GameObject KnowledgeItemPrefab;

	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDone()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Panel_Knowledge()
	{
	}
}
