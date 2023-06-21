using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraScreenAudio : MonoBehaviour
{
	private string m_ScreenOffWwiseEvent;

	private string m_ScreenLowWwiseEvent;

	private string m_ScreenStableWwiseEvent;

	public GameObject m_LinkedScreen;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public void SetState(AuroraScreenDisplay.State state)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AuroraScreenAudio()
	{
	}
}
