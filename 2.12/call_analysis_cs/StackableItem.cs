using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
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
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public StackableItem FindBestFitForUnits(int units)
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "AddToExistingStackable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 12)]
	public static GearItem GetClosestMatchStackable(List<GearItemObject> gearObjects, GearItem gearToAdd, float stackCondition)
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "AddToExistingStackable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 1)]
	public static bool CanAddToExistingStackable(GearItem existingGear, GearItem gearToAdd, float stackCondition)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public StackableItem()
	{
	}
}
