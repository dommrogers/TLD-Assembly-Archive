using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AlternateTools : MonoBehaviour
{
	public GameObject[] m_AlternateToolsList;

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public AlternateTools()
	{
	}
}
