using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class QualityLevelFilter : MonoBehaviour
{
	public GraphicsQuality m_MinimumQualityLevel;

	private Quality m_MinQualityLevel;

	private bool m_Enabled;

	private List<GameObject> m_Children;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 13)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool PassesFilter()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public QualityLevelFilter()
	{
	}
}
