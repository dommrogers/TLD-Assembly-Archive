using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class BlueprintDataSet : ScriptableObject
{
	public List<BlueprintData> m_Blueprints;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public BlueprintDataSet()
	{
	}
}
