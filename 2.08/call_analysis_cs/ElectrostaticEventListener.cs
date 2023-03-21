using Cpp2ILInjected.CallAnalysis;
using TLD.Electrostatic;
using UnityEngine;
using UnityEngine.Events;

public class ElectrostaticEventListener : MonoBehaviour
{
	private UnityEvent<bool> m_ActiveChanged;

	private UnityEvent<bool> m_FullyActiveChanged;

	private UnityEvent<float> m_NormalizedActiveChanged;

	private UnityEvent<float> m_StrengthChanged;

	[Calls(Type = typeof(ElectrostaticForce), Member = "add_m_NormalizedActiveChanged")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ElectrostaticForce), Member = "add_m_IsFullyActiveChanged")]
	[Calls(Type = typeof(ElectrostaticForce), Member = "add_m_StrengthChanged")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ElectrostaticForce), Member = "add_m_IsActiveChanged")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElectrostaticForce), Member = "remove_m_IsActiveChanged")]
	[Calls(Type = typeof(ElectrostaticForce), Member = "remove_m_IsFullyActiveChanged")]
	[Calls(Type = typeof(ElectrostaticForce), Member = "remove_m_NormalizedActiveChanged")]
	[Calls(Type = typeof(ElectrostaticForce), Member = "remove_m_StrengthChanged")]
	[CallsUnknownMethods(Count = 5)]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ElectrostaticEventListener()
	{
	}
}
