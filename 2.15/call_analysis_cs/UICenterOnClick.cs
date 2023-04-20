using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UICenterOnClick : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(SpringPanel), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UICenterOnClick()
	{
	}
}
