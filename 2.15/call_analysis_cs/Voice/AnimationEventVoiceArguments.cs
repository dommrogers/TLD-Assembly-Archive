using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Voice;

public class AnimationEventVoiceArguments : ScriptableObject
{
	private AK.Wwise.Event m_Event;

	private Priority m_Priority;

	private PlayerVoice.Options m_Options;

	public AK.Wwise.Event Event
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	public Priority Priority
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Priority);
		}
	}

	public PlayerVoice.Options Options
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return default(PlayerVoice.Options);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public AnimationEventVoiceArguments()
	{
	}
}
