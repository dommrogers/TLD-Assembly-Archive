using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkSoundEngineController
{
	private static AkSoundEngineController ms_Instance;

	public static AkSoundEngineController Instance
	{
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(AkInitializer), Member = "LateUpdate")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationQuit")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationFocus")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationPause")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnDisable")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnEnable")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 6)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private AkSoundEngineController()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	~AkSoundEngineController()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetDecodedBankFolder()
	{
		return null;
	}

	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	[CalledBy(Type = typeof(AkBankManager.DecodableBankHandle), Member = ".ctor")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	public static string GetDecodedBankFullPath()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
	[Calls(Type = typeof(AkBankManager), Member = "DoUnloadBanks")]
	[Calls(Type = typeof(AkSoundEngine), Member = "RenderAudio")]
	public void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AkInitializer), Member = "OnEnable")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	public void Init(AkInitializer akInitializer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void OnDisable()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	public void Terminate()
	{
	}

	[Calls(Type = typeof(AkSoundEngineController), Member = "ActivateAudio")]
	[CallerCount(Count = 0)]
	public void OnApplicationPause(bool pauseStatus)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnApplicationFocus(bool focus)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "OnApplicationPause")]
	[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationPause")]
	[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationFocus")]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "RenderAudio")]
	private void ActivateAudio(bool activate, bool renderAnyway = false)
	{
	}
}
