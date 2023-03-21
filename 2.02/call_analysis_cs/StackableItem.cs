using Cpp2ILInjected.CallAnalysis;
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
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_MultipleUnitText
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public StackableItem()
	{
	}
}
