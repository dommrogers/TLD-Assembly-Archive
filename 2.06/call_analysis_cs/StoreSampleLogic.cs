using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.UI;

public class StoreSampleLogic : MonoBehaviour
{
	public GameObject inGamePurchasableItemPrefab;

	public Transform canvasTransform;

	public Text hresultText;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ShowDLC()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public StoreSampleLogic()
	{
	}
}
