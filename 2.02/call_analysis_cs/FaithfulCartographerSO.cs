using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FaithfulCartographerSO : ScriptableObject
{
	public List<CartographyAchievementRegion> m_CartographyAchievementsByRegion;

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FaithfulCartographerSO()
	{
	}
}
