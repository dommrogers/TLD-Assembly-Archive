using System.IO;
using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_TestRenderTextureTestHarness : MonoBehaviour
{
	public Texture2D input;

	public bool doColor;

	public Color32 color;

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	public Texture2D Create3x3Tex()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsUnknownMethods(Count = 28)]
	public Texture2D Create3x3Clone()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixel")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Application), Member = "get_dataPath")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[CallsUnknownMethods(Count = 92)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB3_AtlasPackerRenderTexture), Member = "OnRenderAtlas")]
	[Calls(Type = typeof(ImageConversion), Member = "EncodeToPNG")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_one")]
	[Calls(Type = typeof(MB_TexSet), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static void TestRender(Texture2D input, Texture2D output)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB3_TestRenderTextureTestHarness()
	{
	}
}
