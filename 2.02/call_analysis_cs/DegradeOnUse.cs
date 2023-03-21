using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DegradeOnUse : MonoBehaviour
{
	public float m_DegradeHP;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
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
