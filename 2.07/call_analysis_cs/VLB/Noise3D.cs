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
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "get_isNoiseEnabled")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 4)]
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
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[RuntimeInitializeOnLoadMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
	private static void OnStartUp()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Noise3D), Member = "OnStartUp")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Noise3D), Member = "LoadTexture3D")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Noise3D), Member = "get_isSupported")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	public static void LoadIfNeeded()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Texture3D), Member = ".ctor")]
	[Calls(Type = typeof(Texture3D), Member = "Apply")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
	[CallsUnknownMethods(Count = 8)]
	private static Texture3D LoadTexture3D(TextAsset textData, int size)
	{
		return null;
	}
}
