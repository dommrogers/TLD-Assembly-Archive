using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DegradeOnUse : MonoBehaviour
{
	public float m_DegradeHP;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DegradeOnUse()
	{
	}
}
