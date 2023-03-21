using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Events;

public class WeatherActivatedEffect : MonoBehaviour
{
	[Serializable]
	public class StopWithCallbackEvent : UnityEvent<Action>
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEventBase), Member = ".ctor")]
		public StopWithCallbackEvent()
		{
			((UnityEvent<T0>)(object)this)._002Ector();
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public int stopsCompleted;

		public int stopEventCount;

		public WeatherActivatedEffect _003C_003E4__this;

		public Action onComplete;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		internal void _003CStop_003Eb__0()
		{
		}
	}

	private UnityEvent m_PlayEvents;

	private StopWithCallbackEvent m_StopEvents;

	[Calls(Type = typeof(UnityEvent), Member = "Invoke")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Play()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherActivatedEffectsController), Member = "StopAndReleaseInstances")]
	[CallsUnknownMethods(Count = 2)]
	public void Stop(Action onComplete)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WeatherActivatedEffect()
	{
	}
}
