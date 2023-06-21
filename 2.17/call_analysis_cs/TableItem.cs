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
