using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderQueue : MonoBehaviour
{
	public int renderQueue;

	private Material m_CachedMaterial;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RenderQueue()
	{
	}
}
