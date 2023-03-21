using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AlternateTools : MonoBehaviour
{
	public GameObject[] m_AlternateToolsList;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AlternateTools()
	{
	}
}
