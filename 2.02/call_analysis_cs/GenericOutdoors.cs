using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericOutdoors : MonoBehaviour
{
	public GameObject m_Aurora;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public GenericOutdoors()
	{
	}
}
