using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.UI;

public class SampleInGamePurchasableItem : MonoBehaviour
{
	public Text titleUIElement;

	public Text priceUIElement;

	public Text ownedUIElement;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Purchase()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SampleInGamePurchasableItem()
	{
	}
}
