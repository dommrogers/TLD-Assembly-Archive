using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TableItem : MonoBehaviour
{
	public bool m_JustClicked;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnItemClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TableItem()
	{
	}
}
