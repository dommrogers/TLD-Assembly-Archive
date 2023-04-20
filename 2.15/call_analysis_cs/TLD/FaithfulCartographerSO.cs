using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using UnityEngine;

namespace TLD;

public class FaithfulCartographerSO : ScriptableObject
{
	public List<SceneSetCount> m_CrosscheckAchievementsByRegion;

	public List<CartographyAchievementRegion> m_CartographyAchievementsByRegion;

	public SandboxConfig m_Pilgrim;

	public SandboxConfig m_Voyageur;

	public SandboxConfig m_Stalker;

	public SandboxConfig m_Interloper;

	[CalledBy(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 7)]
	public SceneSetCount FindPresetCartographyAchevementSceneSetCount(string regionName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public FaithfulCartographerSO()
	{
	}
}
