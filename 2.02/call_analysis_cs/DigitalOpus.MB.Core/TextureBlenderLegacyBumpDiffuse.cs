using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class TextureBlenderLegacyBumpDiffuse : TextureBlender
{
	private bool doColor;

	private Color m_tintColor;

	private Color m_defaultTintColor;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsUnknownMethods(Count = 1)]
	public bool DoesShaderNameMatch(string shaderName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CallsUnknownMethods(Count = 2)]
	public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TextureBlenderFallback), Member = "_compareColor")]
	public bool NonTexturePropertiesAreEqual(Material a, Material b)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 1)]
	public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals")]
	public Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName)
	{
		return default(Color);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TextureBlenderLegacyBumpDiffuse()
	{
	}
}
