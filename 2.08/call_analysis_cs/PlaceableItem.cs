using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlaceableItem : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlaceableItem()
	{
	}
}
