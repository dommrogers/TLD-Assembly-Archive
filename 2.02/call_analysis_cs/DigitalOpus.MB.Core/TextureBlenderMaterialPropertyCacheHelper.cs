using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class TextureBlenderMaterialPropertyCacheHelper
{
	private struct MaterialPropertyPair
	{
		public Material material;

		public string property;

		[DeduplicatedMethod]
		[CallerCount(Count = 68)]
		public MaterialPropertyPair(Material m, string prop)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ValueType), Member = "GetHashCode")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			return 0;
		}
	}

	private Dictionary<MaterialPropertyPair, object> nonTexturePropertyValuesForSourceMaterials;

	[CalledBy(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "GetValueIfAllSourceAreTheSameOrDefault")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private bool AllNonTexturePropertyValuesAreEqual(string prop)
	{
		return false;
	}

	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "GetColorIfNoTexture")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "GetColorIfNoTexture")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "GetColorIfNoTexture")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void CacheMaterialProperty(Material m, string property, object value)
	{
	}

	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = "SetNonTexturePropertyValuesOnResultMaterial")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(TextureBlenderMaterialPropertyCacheHelper), Member = "AllNonTexturePropertyValuesAreEqual")]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public object GetValueIfAllSourceAreTheSameOrDefault(string property, object defaultValue)
	{
		return null;
	}

	[CalledBy(Type = typeof(TextureBlenderStandardMetallic), Member = ".ctor")]
	[CalledBy(Type = typeof(TextureBlenderStandardMetallicRoughness), Member = ".ctor")]
	[CalledBy(Type = typeof(TextureBlenderStandardSpecular), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public TextureBlenderMaterialPropertyCacheHelper()
	{
	}
}
