using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LandmarkLocator : MonoBehaviour
{
	public string m_LandmarkName;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public LandmarkLocator()
	{
	}
}
