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
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public StackableItem()
	{
	}
}
