using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public interface TextureBlender
{
	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	bool DoesShaderNameMatch(string shaderName);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	Color OnBlendTexturePixel(string shaderPropertyName, Color pixelColor);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool NonTexturePropertiesAreEqual(Material a, Material b);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName);
}
