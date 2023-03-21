using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DegradeOnUse : MonoBehaviour
{
	public float m_DegradeHP;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DegradeOnUse()
	{
	}
}
