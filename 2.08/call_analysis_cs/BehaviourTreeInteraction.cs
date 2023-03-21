using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

public class BehaviourTreeInteraction : MonoBehaviour
{
	public Blackboard m_Blackboard;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BehaviourTreeInteraction()
	{
	}
}
