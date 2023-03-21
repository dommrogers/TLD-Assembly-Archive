using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenVolume : UITweener
{
	public float from;

	public float to;

	private AudioSource mSource;

	public AudioSource audioSource
	{
		[CalledBy(Type = typeof(TweenVolume), Member = "set_value")]
		[CalledBy(Type = typeof(TweenVolume), Member = "get_value")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(TweenVolume), Member = "get_volume")]
		[CalledBy(Type = typeof(TweenVolume), Member = "Begin")]
		[CalledBy(Type = typeof(TweenVolume), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenVolume), Member = "SetEndToCurrentValue")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenVolume), Member = "get_audioSource")]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(TweenVolume), Member = "get_audioSource")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenVolume), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenVolume), Member = "set_volume")]
		[Calls(Type = typeof(AudioSource), Member = "set_volume")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		set
		{
		}
	}

	[Calls(Type = typeof(TweenVolume), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Calls(Type = typeof(TweenVolume), Member = "get_value")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public TweenVolume()
	{
	}
}
