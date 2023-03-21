using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Marketplace;

public class DownloadableContentPackage : IWrappedObject, IDisposable
{
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public IntPtr mountPoint;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 98)]
		internal IntPtr _003CMount_003Eb__0()
		{
			return default(IntPtr);
		}
	}

	private IntPtr m_Self;

	private string m_ContentId;

	private string m_Description;

	private string m_DisplayName;

	private string m_MountPath;

	private string m_PackageFullName;

	private string m_ProductId;

	private string m_Publisher;

	private string m_TitleId;

	private string m_Version;

	public string ContentId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public uint ContentType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public string Description
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string DisplayName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public bool IsMounted
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(DownloadableContentPackage), Member = "Mount")]
		[CalledBy(Type = typeof(DownloadableContentPackage), Member = "UnMount")]
		get
		{
			return default(bool);
		}
	}

	public string MountPath
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string PackageFullName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public string ProductId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public string Publisher
	{
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string TitleId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public string Version
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(DownloadableContentPackage), Member = "get_IsMounted")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public string Mount()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadableContentPackage), Member = "get_IsMounted")]
	[CallsUnknownMethods(Count = 1)]
	public void UnMount()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool CheckLicense(out bool isTrial)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref isTrial) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DownloadableContentPackage(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	public DownloadableContentPackage()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 98)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
