using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Scenes;

[Serializable]
public class SceneResolutionOverride
{
	public RuntimePlatform m_Platform;

	public int m_MaxResolution;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SceneResolutionOverride()
	{
	}
}
