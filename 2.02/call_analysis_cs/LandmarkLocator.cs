using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LandmarkLocator : MonoBehaviour
{
	public string m_LandmarkName;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public LandmarkLocator()
	{
	}
}
