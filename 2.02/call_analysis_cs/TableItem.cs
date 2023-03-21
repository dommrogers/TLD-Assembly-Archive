using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TableItem : MonoBehaviour
{
	public bool m_JustClicked;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TableItem()
	{
	}
}
