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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RegisterInstancingScript(RenderObjectInstance newRoi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[CallsUnknownMethods(Count = 9)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	public RenderObjectInstanceTriggerVolume()
	{
	}
}
