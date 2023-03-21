using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenVolume : UITweener
{
	public float from;

	public float to;

	private AudioSource mSource;

	public AudioSource audioSource
	{
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CalledBy(Type = typeof(TweenVolume), Member = "get_value")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(TweenVolume), Member = "set_value")]
		get
		{
			return null;
		}
	}

	public float volume
	{
		[Calls(Type = typeof(TweenVolume), Member = "get_value")]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(TweenVolume), Member = "set_value")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float value
	{
		[Calls(Type = typeof(TweenVolume), Member = "get_audioSource")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(TweenVolume), Member = "Begin")]
		[CalledBy(Type = typeof(TweenVolume), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenVolume), Member = "SetEndToCurrentValue")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(TweenVolume), Member = "get_volume")]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(TweenVolume), Member = "get_audioSource")]
		[Calls(Type = typeof(AudioSource), Member = "set_volume")]
		[CalledBy(Type = typeof(TweenVolume), Member = "set_volume")]
		[CalledBy(Type = typeof(TweenVolume), Member = "OnUpdate")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TweenVolume), Member = "set_value")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenVolume), Member = "get_value")]
	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
		return null;
	}

	[Calls(Type = typeof(TweenVolume), Member = "get_value")]
	[CallerCount(Count = 0)]
	public override void SetStartToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenVolume), Member = "get_value")]
	[CallerCount(Count = 0)]
	public override void SetEndToCurrentValue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[DeduplicatedMethod]
	public TweenVolume()
	{
	}
}
