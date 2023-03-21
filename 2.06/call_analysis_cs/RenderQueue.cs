using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderQueue : MonoBehaviour
{
	public int renderQueue;

	private Material m_CachedMaterial;

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	public RenderQueue()
	{
	}
}
