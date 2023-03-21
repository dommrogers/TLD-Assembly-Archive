using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Parlay;

public class ParlayParams : MonoBehaviour
{
	public float m_CharacterResolve;

	public StateOfMind m_InitialStateOfMind;

	private float m_CurrentStateResolve;

	private StateOfMind m_CurentStateOfMind;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ParlayParams()
	{
	}
}
