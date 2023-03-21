using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;

namespace Audio.SimpleAudio;

public class PlayAmbientSimple : BaseSimpleAudioComponent
{
	public Event m_Event;

	public MultiPositionTypeLabel m_MultiPositionType;

	public float m_Radius;

	public bool m_StopWhenDisabled;

	public bool IsSimpleAmbient
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "AddAmbient")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public PlayAmbientSimple()
	{
	}
}
