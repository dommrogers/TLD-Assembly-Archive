using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AudioToggle : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public string m_LoopAudio;

	public string m_TurnOffAudio;

	public bool m_StartOn;

	private uint m_LoopAudioID;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessAudioToggleInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void TurnOn()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void TurnOff()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsPlaying()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AudioToggle()
	{
	}
}
