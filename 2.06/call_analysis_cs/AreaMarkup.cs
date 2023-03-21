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
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public AreaMarkup()
	{
	}
}
