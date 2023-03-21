using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderQueue : MonoBehaviour
{
	public int renderQueue;

	private Material m_CachedMaterial;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	public RenderQueue()
	{
	}
}
