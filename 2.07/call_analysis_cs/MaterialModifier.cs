using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class MaterialModifier
{
	public interface Interface
	{
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		void SetMaterialProp(int nameID, float value);

		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		void SetMaterialProp(int nameID, Vector4 value);

		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		void SetMaterialProp(int nameID, Color value);

		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		void SetMaterialProp(int nameID, Matrix4x4 value);

		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		void SetMaterialProp(int nameID, Texture value);
	}

	public delegate void Callback(Interface owner);
}
