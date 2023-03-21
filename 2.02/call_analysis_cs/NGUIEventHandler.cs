using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NGUIEventHandler : MonoBehaviour
{
	private GameObject LastSelectedByKeys;

	[CallsUnknownMethods(Count = 15)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void OnSelectDelegate(GameObject go, bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	private void OnKeyDelegate(GameObject go, KeyCode keyCode)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NGUIEventHandler()
	{
	}
}
