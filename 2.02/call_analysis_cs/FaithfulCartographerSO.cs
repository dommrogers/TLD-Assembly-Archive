using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FaithfulCartographerSO : ScriptableObject
{
	public List<CartographyAchievementRegion> m_CartographyAchievementsByRegion;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public FaithfulCartographerSO()
	{
	}
}
