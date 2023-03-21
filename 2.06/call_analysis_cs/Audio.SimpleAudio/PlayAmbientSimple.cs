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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "AddAmbient")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public PlayAmbientSimple()
	{
	}
}
