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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Request), Member = "Copy")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start(Request original, uint playbackID)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(NPCVoice), Member = "HandleNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	public void Stop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ActiveRequest()
	{
	}
}
