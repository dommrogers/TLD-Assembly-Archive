using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

public class BehaviourTreeInteraction : MonoBehaviour
{
	public Blackboard m_Blackboard;

	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void PerformInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BehaviourTreeInteraction()
	{
	}
}
