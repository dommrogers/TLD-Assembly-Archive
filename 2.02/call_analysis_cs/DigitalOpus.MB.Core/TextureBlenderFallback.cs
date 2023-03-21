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
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareColor")]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareColor")]
	[CallsUnknownMethods(Count = 1)]
	public bool NonTexturePropertiesAreEqual(Material a, Material b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
	{
	}

	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Equals")]
	public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texProperty)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "NonTexturePropertiesAreEqual")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderLegacyDiffuse), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderFallback), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderFallback), Member = "NonTexturePropertiesAreEqual")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(TextureBlenderLegacyBumpDiffuse), Member = "NonTexturePropertiesAreEqual")]
	public static bool _compareColor(Material a, Material b, Color defaultVal, string propertyName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "NonTexturePropertiesAreEqual")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "NonTexturePropertiesAreEqual")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "NonTexturePropertiesAreEqual")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "NonTexturePropertiesAreEqual")]
	[CallsUnknownMethods(Count = 1)]
	public static bool _compareFloat(Material a, Material b, float defaultVal, string propertyName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TextureBlenderFallback()
	{
	}
}
