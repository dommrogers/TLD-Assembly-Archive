using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes;

namespace TLD;

[Serializable]
public class SceneSetCount
{
	public SceneSet m_SceneSet;

	public int m_TopLevelIcons;

	public int m_LocationTriggers;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SceneSetCount()
	{
	}
}
