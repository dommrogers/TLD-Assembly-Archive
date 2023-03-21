using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

public class TriggerVolumeSetBBValue : MonoBehaviour
{
	public Blackboard m_BlackBoard;

	public string m_VariableName;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TriggerVolumeSetBBValue()
	{
	}
}
