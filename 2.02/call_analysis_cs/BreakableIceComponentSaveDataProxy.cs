using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BreakableIceComponentSaveDataProxy
{
	public Vector3 m_Position;

	public List<string> m_BrokenIceData;

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BreakableIce), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public BreakableIceComponentSaveDataProxy()
	{
	}
}
