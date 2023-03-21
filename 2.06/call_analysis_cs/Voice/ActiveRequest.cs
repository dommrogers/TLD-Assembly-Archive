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
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Request), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start(Request original, uint playbackID)
	{
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "HandleNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void Stop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ActiveRequest()
	{
	}
}
