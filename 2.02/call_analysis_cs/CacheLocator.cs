using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CacheLocator : MonoBehaviour
{
	public LandmarkLocator[] m_NearbyLandmarks;

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LandmarkLocator ChooseLandmark()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public CacheLocator()
	{
	}
}
