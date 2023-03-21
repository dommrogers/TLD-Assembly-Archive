using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UICenterOnClick : MonoBehaviour
{
	[Calls(Type = typeof(UICenterOnChild), Member = "CenterOn")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpringPanel), Member = "Begin")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UICenterOnClick()
	{
	}
}
