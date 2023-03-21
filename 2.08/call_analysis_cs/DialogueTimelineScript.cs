using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;

public class DialogueTimelineScript : ScriptableObject
{
	public AssetReferenceTimeline m_TimelineRef;

	public string m_CameraFramingIn;

	public float m_CameraFramingInDurationSeconds;

	public string m_CameraFramingOut;

	public float m_CameraFramingOutDurationSeconds;

	public bool m_CameraLocked;

	public bool m_LerpCameraOffset;

	public bool m_FadedOutOnLoad;

	public bool m_DisabledBreathFX;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public DialogueTimelineScript()
	{
	}
}
