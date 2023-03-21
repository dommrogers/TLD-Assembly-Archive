using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DegradeOnUse : MonoBehaviour
{
	public float m_DegradeHP;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DegradeOnUse()
	{
	}
}
