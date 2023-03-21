using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class ToxicFogSceneOverrideTunables
{
	public string m_SceneName;

	public float m_TimeToFillUpToMaximumMinutes;

	[NonSerialized]
	public uint m_SceneHashName;

	[CallerCount(Count = 0)]
	public ToxicFogSceneOverrideTunables()
	{
	}
}
