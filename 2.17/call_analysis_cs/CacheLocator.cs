using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CacheLocator : MonoBehaviour
{
	public LandmarkLocator[] m_NearbyLandmarks;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public LandmarkLocator ChooseLandmark()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CacheLocator()
	{
	}
}
