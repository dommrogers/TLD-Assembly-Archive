using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LandmarkLocator : MonoBehaviour
{
	public string m_LandmarkName;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LandmarkLocator()
	{
	}
}
