using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScrollListButton : MonoBehaviour
{
	private GameObject m_CallbackObject;

	private string m_CallbackString;

	private int m_Index;

	[CallerCount(Count = 0)]
	public void SetCallback(GameObject callbackObject, string callbackString, int index)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ScrollListButton()
	{
	}
}
