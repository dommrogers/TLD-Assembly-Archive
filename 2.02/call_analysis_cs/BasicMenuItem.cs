using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BasicMenuItem : MonoBehaviour
{
	public BasicMenu.BasicMenuItemView m_View;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BasicMenuItem()
	{
	}
}
