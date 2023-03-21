using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class BlueprintDataSet : ScriptableObject
{
	public List<BlueprintData> m_Blueprints;

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BlueprintDataSet()
	{
	}
}
