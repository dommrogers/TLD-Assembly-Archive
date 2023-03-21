using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BreakableIceComponentSaveDataProxy
{
	public Vector3 m_Position;

	public List<string> m_BrokenIceData;

	[CalledBy(Type = typeof(BreakableIce), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public BreakableIceComponentSaveDataProxy()
	{
	}
}
