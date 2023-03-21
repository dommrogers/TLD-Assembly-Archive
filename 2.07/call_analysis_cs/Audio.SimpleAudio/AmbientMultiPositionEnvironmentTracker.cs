using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Audio.SimpleAudio;

public class AmbientMultiPositionEnvironmentTracker : MonoBehaviour
{
	private AkGameObjEnvironmentData m_EnvironmentData;

	private Collider m_Collider;

	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "UpdateAuxSend")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AmbientMultiPositionEnvironmentTracker()
	{
	}
}
