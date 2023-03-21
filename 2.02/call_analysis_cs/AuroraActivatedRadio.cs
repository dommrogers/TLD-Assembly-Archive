using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraActivatedRadio : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraActivatedRadio()
	{
	}
}
