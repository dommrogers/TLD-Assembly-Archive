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
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ParlayParams()
	{
	}
}
