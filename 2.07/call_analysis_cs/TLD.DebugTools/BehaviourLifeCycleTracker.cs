using Cpp2ILInjected.CallAnalysis;
using TLD.Logging;
using UnityEngine;

namespace TLD.DebugTools;

public class BehaviourLifeCycleTracker : MonoBehaviour
{
	public enum CallsToTrack
	{
		None = 0,
		Awake = 1,
		OnEnable = 2,
		Start = 4,
		OnDisable = 8,
		OnDestroy = 0x10
	}

	private static readonly LogFilter s_LogFilter;

	private CallsToTrack m_CallsToTrack;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void LogIfTracked(CallsToTrack mask)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static bool IsSet(CallsToTrack settings, CallsToTrack mask)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BehaviourLifeCycleTracker()
	{
	}
}
