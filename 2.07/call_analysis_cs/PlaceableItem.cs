using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlaceableItem : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PlaceableItem()
	{
	}
}
