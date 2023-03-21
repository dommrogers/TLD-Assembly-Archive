using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraActivatedRadio : MonoBehaviour
{
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
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AuroraActivatedRadio()
	{
	}
}
