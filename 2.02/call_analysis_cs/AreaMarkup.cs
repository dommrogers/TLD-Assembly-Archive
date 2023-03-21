using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AreaMarkup : MonoBehaviour
{
	public AreaMarkupType m_MarkupType;

	public float m_Radius;

	public MarkupPointGenerator m_MarkupPointGenerator;

	public List<AreaMarkup> m_ValidNeighborMarkups;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "RegisterArea")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AreaMarkup()
	{
	}
}
