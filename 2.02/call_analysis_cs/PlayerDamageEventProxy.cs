using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class PlayerDamageEventProxy
{
	public string m_IconName;

	public string m_BackgroundName;

	public string m_DamageType;

	public string m_DamageName;

	public float m_DisplayTime;

	public float m_FadeOutTime;

	public float m_TimeActive;

	public bool m_FadeOut;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PlayerDamageEventProxy()
	{
	}
}
