using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlaceableItem : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public PlaceableItem()
	{
	}
}
