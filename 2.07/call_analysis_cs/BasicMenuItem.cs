using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BasicMenuItem : MonoBehaviour
{
	public BasicMenu.BasicMenuItemView m_View;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BasicMenuItem()
	{
	}
}
