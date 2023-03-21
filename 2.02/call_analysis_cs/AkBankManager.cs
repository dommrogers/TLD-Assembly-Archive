using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class AkBankManager
{
	private class BankHandle
	{
		protected readonly string bankName;

		protected uint m_BankID;

		private int _003CRefCount_003Ek__BackingField;

		public int RefCount
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			private set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		public BankHandle(string name)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[CallsDeduplicatedMethods(Count = 1)]
		public virtual AKRESULT DoLoadBank()
		{
			return default(AKRESULT);
		}

		[CalledBy(Type = typeof(AkBankManager), Member = "LoadBank")]
		[CalledBy(Type = typeof(AkBankManager), Member = "LoadBankAsync")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(List<>), Member = "Contains")]
		[Calls(Type = typeof(BankHandle), Member = "LogLoadResult")]
		[Calls(Type = typeof(List<>), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public void LoadBank()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEngine), Member = "UnloadBank")]
		[CallsDeduplicatedMethods(Count = 1)]
		public virtual void UnloadBank()
		{
		}

		[CallerCount(Count = 0)]
		public void IncRef()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void DecRef()
		{
		}

		[CalledBy(Type = typeof(BankHandle), Member = "LoadBank")]
		[CalledBy(TypeFullName = "AkBankManager.AsyncBankHandle", Member = "GlobalBankCallback")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 21)]
		protected void LogLoadResult(AKRESULT result)
		{
		}
	}

	private class AsyncBankHandle : BankHandle
	{
		private readonly AkCallbackManager.BankCallback bankCallback;

		[CallerCount(Count = 0)]
		public AsyncBankHandle(string name, AkCallbackManager.BankCallback callback)
			: base(null)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "AkBankManager.BankHandle", Member = "LogLoadResult")]
		[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
		[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
		[Calls(Type = typeof(AkCallbackManager.BankCallback), Member = "Invoke")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		private static void GlobalBankCallback(uint in_bankID, IntPtr in_pInMemoryBankPtr, AKRESULT in_eLoadResult, uint in_memPoolId, object in_Cookie)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public override AKRESULT DoLoadBank()
		{
			return default(AKRESULT);
		}
	}

	private class DecodableBankHandle : BankHandle
	{
		private readonly bool decodeBank;

		private readonly string decodedBankPath;

		private readonly bool saveDecodedBank;

		[CalledBy(Type = typeof(AkBankManager), Member = "LoadBank")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(AkSoundEngine), Member = "GetCurrentLanguage")]
		[Calls(Type = typeof(AkSoundEngineController), Member = "GetDecodedBankFullPath")]
		[Calls(Type = typeof(Path), Member = "Combine")]
		[Calls(Type = typeof(File), Member = "Exists")]
		[Calls(Type = typeof(File), Member = "GetLastWriteTime")]
		[Calls(Type = typeof(AkBasePathGetter), Member = "GetSoundbankBasePath")]
		[CallsDeduplicatedMethods(Count = 1)]
		public DecodableBankHandle(string name, bool save)
			: base(null)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEngine), Member = "SetBasePath")]
		[Calls(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[Calls(Type = typeof(AkBasePathGetter), Member = "GetSoundbankBasePath")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public override AKRESULT DoLoadBank()
		{
			return default(AKRESULT);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEngine), Member = "UnloadBank")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public override void UnloadBank()
		{
		}
	}

	private static readonly Dictionary<string, BankHandle> m_BankHandles;

	private static readonly List<BankHandle> BanksToUnload;

	private static readonly Mutex m_Mutex;

	[CalledBy(Type = typeof(AkInitializer), Member = "LateUpdate")]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal static void DoUnloadBanks()
	{
	}

	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "LoadInitBank")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void Reset()
	{
	}

	[CalledBy(Type = typeof(AkBank), Member = "HandleEvent")]
	[CalledBy(Type = typeof(Bank), Member = "Load")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(DecodableBankHandle), Member = ".ctor")]
	[Calls(Type = typeof(BankHandle), Member = "LoadBank")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	public static void LoadBank(string name, bool decodeBank, bool saveDecodedBank)
	{
	}

	[CalledBy(Type = typeof(AkBank), Member = "HandleEvent")]
	[CalledBy(Type = typeof(Bank), Member = "LoadAsync")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(BankHandle), Member = "LoadBank")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static void LoadBankAsync(string name, AkCallbackManager.BankCallback callback = null)
	{
	}

	[CalledBy(Type = typeof(AkBank), Member = "UnloadBank")]
	[CalledBy(Type = typeof(Bank), Member = "Unload")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public static void UnloadBank(string name)
	{
	}
}
