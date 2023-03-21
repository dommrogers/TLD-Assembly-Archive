using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderObjectInstanceTriggerVolume : MonoBehaviour
{
	public float m_Lod1Distance;

	public float m_Lod2Distance;

	public float m_CullDistance;

	private List<RenderObjectInstance> m_InstancingScriptList;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Awake")]
	public void RegisterInstancingScript(RenderObjectInstance newRoi)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[CallsUnknownMethods(Count = 8)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	public RenderObjectInstanceTriggerVolume()
	{
	}
}
