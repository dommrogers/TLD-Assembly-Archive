using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FrameDumpHelper : MonoBehaviour
{
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[CallerCount(Count = 0)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FrameDumpHelper()
	{
	}
}
