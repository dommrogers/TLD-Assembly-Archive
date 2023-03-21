using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderObjectInstanceTriggerVolume : MonoBehaviour
{
	public float m_Lod1Distance;

	public float m_Lod2Distance;

	public float m_CullDistance;

	private List<RenderObjectInstance> m_InstancingScriptList;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Awake")]
	[CallsUnknownMethods(Count = 8)]
	public void RegisterInstancingScript(RenderObjectInstance newRoi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[CallsUnknownMethods(Count = 8)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public RenderObjectInstanceTriggerVolume()
	{
	}
}
