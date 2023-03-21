using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkInitializer : MonoBehaviour
{
	private static AkInitializer ms_Instance;

	public AkWwiseInitializationSettings InitializationSettings;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_Instance")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "get_Instance")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "get_Instance")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "ActivateAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "get_Instance")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "ActivateAudio")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnApplicationFocus(bool focus)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "get_Instance")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnApplicationQuit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "get_Instance")]
	[Calls(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
	[Calls(Type = typeof(AkBankManager), Member = "DoUnloadBanks")]
	[Calls(Type = typeof(AkSoundEngine), Member = "RenderAudio")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AkInitializer()
	{
	}
}
