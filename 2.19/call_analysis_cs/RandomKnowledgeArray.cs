using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RandomKnowledgeArray : MonoBehaviour
{
	public GameObject[] m_Prefabs;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RandomKnowledgeArray()
	{
	}
}
