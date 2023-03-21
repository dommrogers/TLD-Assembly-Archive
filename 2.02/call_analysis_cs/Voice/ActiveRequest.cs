using Cpp2ILInjected.CallAnalysis;

namespace Voice;

public class ActiveRequest : Request
{
	public float m_Duration;

	public float m_Elapsed;

	public uint m_PlaybackID;

	public bool m_Subtitled;

	[CallerCount(Count = 0)]
	public override void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Request), Member = "Copy")]
	public void Start(Request original, uint playbackID)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CalledBy(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	[CalledBy(Type = typeof(NPCVoice), Member = "HandleNextRequest")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(NPCVoice), Member = "Play")]
	public void Stop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ActiveRequest()
	{
	}
}
