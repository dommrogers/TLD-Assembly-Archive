using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class StackableItem : MonoBehaviour
{
	public int m_Units;

	public int m_UnitsPerItem;

	public LocalizedString m_LocalizedSingleUnitText;

	public LocalizedString m_LocalizedMultipleUnitText;

	public StackableItem[] m_ShareStackWithGear;

	public string m_StackSpriteName;

	public GearItem m_InstantiateStackItem;

	public bool m_StackByCondition;

	public float m_StackConditionDifferenceConstraint;

	private static StackableItemSaveDataProxy m_StackableItemSaveDataProxy;

	public string m_SingleUnitText
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_MultipleUnitText
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	public StackableItem FindBestFitForUnits(int units)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public StackableItem()
	{
	}
}
