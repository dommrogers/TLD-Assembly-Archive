using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CacheLocator : MonoBehaviour
{
	public LandmarkLocator[] m_NearbyLandmarks;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public LandmarkLocator ChooseLandmark()
	{
		return null;
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public CacheLocator()
	{
	}
}
