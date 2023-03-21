using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public static class Noise3D
{
	private static bool ms_IsSupportedChecked;

	private static bool ms_IsSupported;

	private static Texture3D ms_NoiseTexture;

	private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

	private const int kMinShaderLevel = 35;

	public static bool isSupported
	{
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "get_isNoiseEnabled")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		get
		{
			return default(bool);
		}
	}

	public static bool isProperlyLoaded
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public static string isNotSupportedString
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
	[RuntimeInitializeOnLoadMethod]
	[CallerCount(Count = 0)]
	private static void OnStartUp()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Noise3D), Member = "get_isSupported")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Noise3D), Member = "LoadTexture3D")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(Noise3D), Member = "OnStartUp")]
	[CallsUnknownMethods(Count = 1)]
	public static void LoadIfNeeded()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Texture3D), Member = ".ctor")]
	[Calls(Type = typeof(Texture3D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private static Texture3D LoadTexture3D(TextAsset textData, int size)
	{
		return null;
	}
}
