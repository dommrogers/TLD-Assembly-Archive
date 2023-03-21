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
	[CallerCount(Count = 121780)]
	public abstract void Cleanup();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract bool HasProxy();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract bool IsActive();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void Start();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void Stop();

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LoopTracker), Member = ".ctor")]
	[CalledBy(Type = typeof(AmbientTracker), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "AddAmbient")]
	protected BaseTracker(GameObject go, float radius, bool stopWhenDisabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public virtual bool Matches(GameObject go, AK.Wwise.Event akEvent)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public int MaybeStartOrStop(Vector3 listenerPos)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldStart()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldStop()
	{
		return default(bool);
	}
}
