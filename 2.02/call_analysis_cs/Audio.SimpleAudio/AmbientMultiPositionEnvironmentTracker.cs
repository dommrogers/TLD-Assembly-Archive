using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Audio.SimpleAudio;

public class AmbientMultiPositionEnvironmentTracker : MonoBehaviour
{
	private AkGameObjEnvironmentData m_EnvironmentData;

	private Collider m_Collider;

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "UpdateAuxSend")]
	private void Update()
	{
	}

	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "AddAkEnvironment")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "RemoveAkEnvironment")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerExit(Collider other)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AmbientMultiPositionEnvironmentTracker()
	{
	}
}
