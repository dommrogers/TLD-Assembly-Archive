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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	public void Start(Request original, uint playbackID)
	{
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "HandleNextRequest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	public void Stop()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public ActiveRequest()
	{
	}
}
