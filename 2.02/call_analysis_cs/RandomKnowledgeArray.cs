using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RandomKnowledgeArray : MonoBehaviour
{
	public GameObject[] m_Prefabs;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RandomKnowledgeArray()
	{
	}
}
