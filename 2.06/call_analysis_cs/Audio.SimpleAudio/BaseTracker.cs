using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Audio.SimpleAudio;

public abstract class BaseTracker
{
	private const float MAX_PLAY_DISTANCE = 500f;

	public float m_Delta;

	protected GameObject m_GameObject;

	protected Vector3 m_Pos;

	protected float m_Radius;

	protected bool m_StopWhenDisabled;

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract void Cleanup();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract bool HasProxy();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract bool IsActive();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void Start();

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	protected abstract void Stop();

	[CalledBy(Type = typeof(VoiceTracker), Member = ".ctor")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "Add")]
	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "AddVoice")]
	[CalledBy(Type = typeof(AmbientTracker), Member = ".ctor")]
	[CalledBy(Type = typeof(LoopTracker), Member = ".ctor")]
	[CalledBy(Type = typeof(LoopTracker), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	protected BaseTracker(GameObject go, float radius, bool stopWhenDisabled)
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	public virtual bool Matches(GameObject go, AK.Wwise.Event akEvent)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	public int MaybeStartOrStop(Vector3 listenerPos)
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldStart()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldStop()
	{
		return default(bool);
	}
}
