using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Audio.SimpleAudio;

public class AmbientMultiPositionEnvironmentTracker : MonoBehaviour
{
	private AkGameObjEnvironmentData m_EnvironmentData;

	private Collider m_Collider;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "UpdateAuxSend")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "AddAkEnvironment")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "RemoveAkEnvironment")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerExit(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AmbientMultiPositionEnvironmentTracker()
	{
	}
}
