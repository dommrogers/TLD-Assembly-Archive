using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

public class TriggerVolumeSetBBValue : MonoBehaviour
{
	public Blackboard m_BlackBoard;

	public string m_VariableName;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TriggerVolumeSetBBValue()
	{
	}
}
