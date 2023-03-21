using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using UnityEngine;

public class SetChildOnOff : MonoBehaviour
{
	public Activation[] m_Activations;

	private float m_ActivationTimer;

	private int m_CurrentActivation;

	private bool m_ActivationEnabled;

	private GameObject m_Child;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 7)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "PlayerSparkParticlesOnSpecific")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "PlayerSparkParticlesOnSpecific")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void StartOnOffCycle()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "StopSparkParticles")]
	[CallsUnknownMethods(Count = 5)]
	public void CancelOnOffCycle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SetChildOnOff()
	{
	}
}
