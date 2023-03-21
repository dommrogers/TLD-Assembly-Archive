using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScrollListButton : MonoBehaviour
{
	private GameObject m_CallbackObject;

	private string m_CallbackString;

	private int m_Index;

	[CalledBy(Type = typeof(ScrollList), Member = "CreateFromList")]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateFromList")]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateList")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateList")]
	public void SetCallback(GameObject callbackObject, string callbackString, int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ScrollListButton()
	{
	}
}
