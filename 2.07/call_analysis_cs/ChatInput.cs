using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ChatInput : MonoBehaviour
{
	public UITextList textList;

	public bool fillWithDummyData;

	private UIInput mInput;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITextList), Member = "Add")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void Start()
	{
	}

	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(NGUIText), Member = "StripSymbols")]
	[Calls(Type = typeof(UITextList), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	public void OnSubmit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ChatInput()
	{
	}
}
