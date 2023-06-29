using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenVolume : UITweener
{
	public float from;

	public float to;

	private AudioSource mSource;

	public AudioSource audioSource
	{
		[CalledBy(Type = typeof(TweenVolume), Member = "get_value")]
		[CalledBy(Type = typeof(TweenVolume), Member = "set_value")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public float volume
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenVolume), Member = "get_value")]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenVolume), Member = "set_value")]
		set
		{
		}
	}

	public float value
	{
		[CalledBy(Type = typeof(TweenVolume), Member = "get_volume")]
		[CalledBy(Type = typeof(TweenVolume), Member = "Begin")]
		[CalledBy(Type = typeof(TweenVolume), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenVolume), Member = "SetEndToCurrentValue")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(TweenVolume), Member = "get_audioSource")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0f;
		}
		[CalledBy(Type = typeof(TweenVolume), Member = "set_volume")]
		[CalledBy(Type = typeof(TweenVolume), Member = "OnUpdate")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TweenVolume), Member = "get_audioSource")]
		[Calls(Type = typeof(AudioSource), Member = "set_volume")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenVolume), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "Begin")]
	[Calls(Type = typeof(TweenVolume), Member = "get_value")]
	[CallsUnknownMethods(Count = 1)]
	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenVolume), Member = "get_value")]
	public override void SetStartToCurrentValue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenVolume), Member = "get_value")]
	public override void SetEndToCurrentValue()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenVolume()
	{
	}
}
