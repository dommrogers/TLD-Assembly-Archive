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

	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "PlayerSparkParticlesOnSpecific")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "PlayerSparkParticlesOnSpecific")]
	[CallsUnknownMethods(Count = 3)]
	public void StartOnOffCycle()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "StopSparkParticles")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void CancelOnOffCycle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SetChildOnOff()
	{
	}
}
