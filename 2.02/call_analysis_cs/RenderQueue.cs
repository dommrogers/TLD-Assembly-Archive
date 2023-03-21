using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderQueue : MonoBehaviour
{
	public int renderQueue;

	private Material m_CachedMaterial;

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public RenderQueue()
	{
	}
}
