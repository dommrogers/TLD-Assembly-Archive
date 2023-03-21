using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraScreenAudio : MonoBehaviour
{
	private string m_ScreenOffWwiseEvent;

	private string m_ScreenLowWwiseEvent;

	private string m_ScreenStableWwiseEvent;

	public GameObject m_LinkedScreen;

	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetState(AuroraScreenDisplay.State state)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraScreenAudio()
	{
	}
}
