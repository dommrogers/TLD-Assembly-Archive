using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class TextureBlenderFallback : TextureBlender
{
	private bool m_doTintColor;

	private Color m_tintColor;

	private Color m_defaultColor;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool DoesShaderNameMatch(string shaderName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Color OnBlendTexturePixel(string shaderPropertyName, Color pixelColor)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool NonTexturePropertiesAreEqual(Material a, Material b)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texProperty)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(TextureBlenderFallback), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderLegacyBumpDiffuse), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderLegacyDiffuse), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "NonTexturePropertiesAreEqual")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 1)]
	public static bool _compareColor(Material a, Material b, Color defaultVal, string propertyName)
	{
		return false;
	}

	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "NonTexturePropertiesAreEqual")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[CallsUnknownMethods(Count = 1)]
	public static bool _compareFloat(Material a, Material b, float defaultVal, string propertyName)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TextureBlenderFallback()
	{
	}
}
