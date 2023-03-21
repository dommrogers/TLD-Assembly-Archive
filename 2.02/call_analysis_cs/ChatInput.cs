using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ChatInput : MonoBehaviour
{
	public UITextList textList;

	public bool fillWithDummyData;

	private UIInput mInput;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UITextList), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "set_isSelected")]
	[Calls(Type = typeof(UITextList), Member = "Add")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(NGUIText), Member = "StripSymbols")]
	public void OnSubmit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ChatInput()
	{
	}
}
