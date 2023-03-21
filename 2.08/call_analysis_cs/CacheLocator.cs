using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CacheLocator : MonoBehaviour
{
	public LandmarkLocator[] m_NearbyLandmarks;

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public LandmarkLocator ChooseLandmark()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CacheLocator()
	{
	}
}
