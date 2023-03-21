using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FrameDumpHelper : MonoBehaviour
{
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public FrameDumpHelper()
	{
	}
}
