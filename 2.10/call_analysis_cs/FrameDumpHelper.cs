using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FrameDumpHelper : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FrameDumpHelper()
	{
	}
}
