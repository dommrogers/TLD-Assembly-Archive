using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraEffectNode : MonoBehaviour
{
	public GameObject m_Prefab;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraEffectNode()
	{
	}
}
