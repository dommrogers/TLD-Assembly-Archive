using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ChatInput : MonoBehaviour
{
	public UITextList textList;

	public bool fillWithDummyData;

	private UIInput mInput;

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UITextList), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UITextList), Member = "Add")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUIText), Member = "StripSymbols")]
	public void OnSubmit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ChatInput()
	{
	}
}
