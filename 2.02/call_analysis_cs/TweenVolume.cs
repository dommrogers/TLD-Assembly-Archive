using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenVolume : UITweener
{
	public float from;

	public float to;

	private AudioSource mSource;

	public AudioSource audioSource
	{
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenVolume), Member = "set_value")]
		[CalledBy(Type = typeof(TweenVolume), Member = "get_value")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenVolume), Member = "set_value")]
		set
		{
		}
	}

	public float value
	{
		[CalledBy(Type = typeof(TweenVolume), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenVolume), Member = "Begin")]
		[CalledBy(Type = typeof(TweenVolume), Member = "get_volume")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(TweenVolume), Member = "get_audioSource")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(TweenVolume), Member = "SetEndToCurrentValue")]
		get
		{
			return default(float);
		}
		[CalledBy(Type = typeof(TweenVolume), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenVolume), Member = "set_volume")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(AudioSource), Member = "set_volume")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(TweenVolume), Member = "get_audioSource")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TweenVolume), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TweenVolume), Member = "get_value")]
	[CallsUnknownMethods(Count = 1)]
	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
		return null;
	}

	[Calls(Type = typeof(TweenVolume), Member = "get_value")]
	[CallerCount(Count = 0)]
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
