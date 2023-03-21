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

	public abstract void Cleanup();

	public abstract bool HasProxy();

	public abstract bool IsActive();

	protected abstract void Start();

	protected abstract void Stop();

	[CalledBy(Type = typeof(AmbientTracker), Member = ".ctor")]
	[CalledBy(Type = typeof(LoopTracker), Member = ".ctor")]
	[CalledBy(Type = typeof(LoopTracker), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected BaseTracker(GameObject go, float radius, bool stopWhenDisabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Matches(GameObject go, AK.Wwise.Event akEvent)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public int MaybeStartOrStop(Vector3 listenerPos)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldStart()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldStop()
	{
		return false;
	}
}
