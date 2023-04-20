using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericOutdoors : MonoBehaviour
{
	public GameObject m_Aurora;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GenericOutdoors()
	{
	}
}
