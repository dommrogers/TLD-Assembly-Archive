using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TableItem : MonoBehaviour
{
	public bool m_JustClicked;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void OnItemClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public TableItem()
	{
	}
}
