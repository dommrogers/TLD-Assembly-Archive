using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Audio.SimpleAudio;

public class AmbientMultiPositionEnvironmentTracker : MonoBehaviour
{
	private AkGameObjEnvironmentData m_EnvironmentData;

	private Collider m_Collider;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "UpdateAuxSend")]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "AddAkEnvironment")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 0)]
	public AmbientMultiPositionEnvironmentTracker()
	{
	}
}
