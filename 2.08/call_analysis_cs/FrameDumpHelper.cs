using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FrameDumpHelper : MonoBehaviour
{
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FrameDumpHelper()
	{
	}
}
