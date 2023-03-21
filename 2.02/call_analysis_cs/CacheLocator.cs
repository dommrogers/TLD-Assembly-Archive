using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CacheLocator : MonoBehaviour
{
	public LandmarkLocator[] m_NearbyLandmarks;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public LandmarkLocator ChooseLandmark()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CacheLocator()
	{
	}
}
