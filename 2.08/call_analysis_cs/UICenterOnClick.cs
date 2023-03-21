using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UICenterOnClick : MonoBehaviour
{
	[Calls(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(SpringPanel), Member = "Begin")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UICenterOnClick()
	{
	}
}
