using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DialogueTimelineScript : ScriptableObject
{
	public TimelineRef m_TimelineRef;

	public string m_CameraFramingIn;

	public float m_CameraFramingInDurationSeconds;

	public string m_CameraFramingOut;

	public float m_CameraFramingOutDurationSeconds;

	public bool m_CameraLocked;

	public bool m_LerpCameraOffset;

	public bool m_FadedOutOnLoad;

	public bool m_DisabledBreathFX;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public DialogueTimelineScript()
	{
	}
}
