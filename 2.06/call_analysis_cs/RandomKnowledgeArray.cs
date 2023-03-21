using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RandomKnowledgeArray : MonoBehaviour
{
	public GameObject[] m_Prefabs;

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public RandomKnowledgeArray()
	{
	}
}
