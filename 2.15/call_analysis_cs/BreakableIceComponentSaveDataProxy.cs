using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BreakableIceComponentSaveDataProxy
{
	public Vector3 m_Position;

	public List<string> m_BrokenIceData;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BreakableIceComponentSaveDataProxy()
	{
	}
}
