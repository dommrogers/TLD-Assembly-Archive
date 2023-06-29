using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InteractiveObjects;

public interface ITrackable
{
	bool CanTrack();

	bool IsUnlocked();

	Transform GetTransform();

	TrackableItemType GetItemType();

	TrackableItemData GetItemData();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	float GetEstimatedDistance()
	{
		return 0f;
	}
}
