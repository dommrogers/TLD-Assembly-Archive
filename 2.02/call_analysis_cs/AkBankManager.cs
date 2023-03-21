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
				return default(int);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			private set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		public BankHandle(string name)
		{
		}

		[Calls(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public virtual AKRESULT DoLoadBank()
		{
			return default(AKRESULT);
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(BankHandle), Member = "LogLoadResult")]
		[CalledBy(Type = typeof(AkBankManager), Member = "LoadBank")]
		[CalledBy(Type = typeof(AkBankManager), Member = "LoadBankAsync")]
		[CallsUnknownMethods(Count = 2)]
		public void LoadBank()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEngine), Member = "UnloadBank")]
		public virtual void UnloadBank()
		{
		}

		[CallerCount(Count = 0)]
		public void IncRef()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		public void DecRef()
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CalledBy(Type = typeof(BankHandle), Member = "LoadBank")]
		[CalledBy(Type = typeof(AsyncBankHandle), Member = "GlobalBankCallback")]
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

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(AkCallbackManager.BankCallback), Member = "Invoke")]
		[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BankHandle), Member = "LogLoadResult")]
		private static void GlobalBankCallback(uint in_bankID, IntPtr in_pInMemoryBankPtr, AKRESULT in_eLoadResult, uint in_memPoolId, object in_Cookie)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEngine), Member = "LoadBank")]
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

		[Calls(Type = typeof(Path), Member = "Combine")]
		[CalledBy(Type = typeof(AkBankManager), Member = "LoadBank")]
		[Calls(Type = typeof(File), Member = "GetLastWriteTime")]
		[Calls(Type = typeof(Path), Member = "Combine")]
		[Calls(Type = typeof(AkBasePathGetter), Member = "GetSoundbankBasePath")]
		[Calls(Type = typeof(File), Member = "Exists")]
		[Calls(Type = typeof(File), Member = "Exists")]
		[Calls(Type = typeof(File), Member = "GetLastWriteTime")]
		[Calls(Type = typeof(Path), Member = "Combine")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Path), Member = "Combine")]
		[Calls(Type = typeof(AkSoundEngineController), Member = "GetDecodedBankFullPath")]
		[Calls(Type = typeof(AkSoundEngine), Member = "GetCurrentLanguage")]
		public DecodableBankHandle(string name, bool save)
			: base(null)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(AkSoundEngine), Member = "SetBasePath")]
		[Calls(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[Calls(Type = typeof(AkBasePathGetter), Member = "GetSoundbankBasePath")]
		[Calls(Type = typeof(AkSoundEngine), Member = "SetBasePath")]
		[CallsUnknownMethods(Count = 1)]
		public override AKRESULT DoLoadBank()
		{
			return default(AKRESULT);
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEngine), Member = "UnloadBank")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		public override void UnloadBank()
		{
		}
	}

	private static readonly Dictionary<string, BankHandle> m_BankHandles;

	private static readonly List<BankHandle> BanksToUnload;

	private static readonly Mutex m_Mutex;

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "LateUpdate")]
	[CalledBy(Type = typeof(AkInitializer), Member = "LateUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	internal static void DoUnloadBanks()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "LoadInitBank")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CallsUnknownMethods(Count = 2)]
	internal static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Bank), Member = "Load")]
	[CalledBy(Type = typeof(AkBank), Member = "HandleEvent")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(BankHandle), Member = "LoadBank")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecodableBankHandle), Member = ".ctor")]
	public static void LoadBank(string name, bool decodeBank, bool saveDecodedBank)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(BankHandle), Member = "LoadBank")]
	[CalledBy(Type = typeof(AkBank), Member = "HandleEvent")]
	[CalledBy(Type = typeof(Bank), Member = "LoadAsync")]
	[CallsUnknownMethods(Count = 13)]
	public static void LoadBankAsync(string name, AkCallbackManager.BankCallback callback = null)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(AkBank), Member = "UnloadBank")]
	[CalledBy(Type = typeof(Bank), Member = "Unload")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	public static void UnloadBank(string name)
	{
	}
}
