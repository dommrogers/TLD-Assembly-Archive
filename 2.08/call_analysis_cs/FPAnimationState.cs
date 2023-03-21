using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FPAnimationState : ScriptableObject
{
	public string m_AnimationStateKey;

	public TextAsset m_SubtitleAsset;

	public string m_AudioEventStart;

	public string m_AudioEventStop;

	public string m_NPCId;

	public bool m_ShouldLockPlayer;

	public bool m_FadedOutOnLoad;

	public bool m_FadedOutOnExit;

	public bool m_UseMotionFromRef;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public FPAnimationState()
	{
	}
}
