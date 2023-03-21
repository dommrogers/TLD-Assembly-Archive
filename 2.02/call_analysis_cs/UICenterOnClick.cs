using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UICenterOnClick : MonoBehaviour
{
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SpringPanel), Member = "Begin")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[CallsDeduplicatedMethods(Count = 11)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UICenterOnClick()
	{
	}
}
