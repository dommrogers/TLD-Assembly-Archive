using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public static class Utils
{
	public enum FloatPackingPrecision
	{
		High = 64,
		Low = 8,
		Undef = 0
	}

	private static FloatPackingPrecision ms_FloatPackingPrecision;

	private const int kFloatPackingHighMinShaderLevel = 35;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
	{
		return default(float);
	}

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public static void Swap<T>(ref T a, ref T b)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetPath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
	[CalledBy(Type = typeof(Utils), Member = "GetPath")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetPath(Transform current)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static T NewWithComponent<T>(string name) where T : Component
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static T GetOrAddComponent<T>(this GameObject self) where T : Component
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static bool HasFlag(this Enum mask, Enum flags)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static Vector2 xy(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static Vector2 xz(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Vector2 yz(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static Vector2 yx(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static Vector2 zx(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Vector2 zy(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static Vector4 AsVector4(this Vector3 vec3, float w)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	public static float GetVolumeCubic(this Bounds self)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float GetMaxArea2D(this Bounds self)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static Color Opaque(this Color self)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallsUnknownMethods(Count = 1)]
	public static Plane TranslateCustom(this Plane plane, Vector3 translation)
	{
		return default(Plane);
	}

	[CallerCount(Count = 0)]
	public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public static bool IsAlmostZero(float f)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsValid(this Plane plane)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(MaterialManager.StaticProperties), Member = "ApplyToMaterial")]
	[CalledBy(Type = typeof(MaterialManager.StaticProperties), Member = "ApplyToMaterial")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MaterialManager.StaticProperties), Member = "ApplyToMaterial")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CalledBy(Type = typeof(MaterialManager.StaticProperties), Member = "ApplyToMaterial")]
	[CalledBy(Type = typeof(MaterialManager.StaticProperties), Member = "ApplyToMaterial")]
	[CalledBy(Type = typeof(MaterialManager.StaticProperties), Member = "ApplyToMaterial")]
	[CalledBy(Type = typeof(MaterialManager.StaticProperties), Member = "ApplyToMaterial")]
	[CalledBy(Type = typeof(MaterialManager.StaticProperties), Member = "ApplyToMaterial")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "SetDynamicOcclusionCallback")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(MaterialManager.StaticProperties), Member = "ApplyToMaterial")]
	public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetShaderKeywordEnabled(string name, bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
	{
		return default(Matrix4x4);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Color[] SampleInArray(this Gradient self, int samplesCount)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private static Vector4 Vector4_Floor(Vector4 vec)
	{
		return default(Vector4);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static float PackToFloat(this Color color, int floatPackingPrecision)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
	public static FloatPackingPrecision GetFloatPackingPrecision()
	{
		return default(FloatPackingPrecision);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void MarkCurrentSceneDirty()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void MarkObjectDirty(UnityEngine.Object obj)
	{
	}
}
