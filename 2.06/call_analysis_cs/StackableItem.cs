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
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_MultipleUnitText
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsUnknownMethods(Count = 2)]
	public StackableItem FindBestFitForUnits(int units)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public StackableItem()
	{
	}
}
