using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkBasePathGetter
{
	public static string DefaultBasePath;

	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static string GetPlatformName()
	{
		return null;
	}

	[CalledBy(Type = typeof(AkMemBankLoader), Member = "Start")]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "GetDecodedBankFullPath")]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "LoadLocalizedBank")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "LoadNonLocalizedBank")]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "Start")]
	[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetSoundbankBasePath")]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformName")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AkBasePathGetter), Member = "FixSlashes")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "FixSlashes")]
	public static string GetPlatformBasePath()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AkBasePathGetter), Member = "FixSlashes")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	public static string GetFullSoundBankPath()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "TrimStart")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(AkBasePathGetter), Member = "FixSlashes")]
	[CallsUnknownMethods(Count = 9)]
	public static void FixSlashes(ref string path, char separatorChar, char badChar, bool addTrailingSlash)
	{
	}

	[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetFullSoundBankPath")]
	[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "FixSlashes")]
	public static void FixSlashes(ref string path)
	{
	}

	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	[CalledBy(Type = typeof(AkBankManager.DecodableBankHandle), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(AkBankManager.DecodableBankHandle), Member = "DoLoadBank")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static string GetSoundbankBasePath()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AkBasePathGetter()
	{
	}
}
