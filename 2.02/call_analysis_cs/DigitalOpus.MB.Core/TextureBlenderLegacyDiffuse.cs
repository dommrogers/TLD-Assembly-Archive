using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class TextureBlenderLegacyDiffuse : TextureBlender
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsUnknownMethods(Count = 3)]
	public Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TextureBlenderLegacyDiffuse()
	{
	}
}
