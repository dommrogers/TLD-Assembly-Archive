using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Users;

public class XboxUserProfile : IWrappedObject, IDisposable
{
	private IntPtr m_Self;

	private string m_ApplicationDisplayName;

	private Uri m_ApplicationDisplayPictureResizeUri;

	private string m_GameDisplayName;

	private Uri m_GameDisplayPictureResizeUri;

	private string m_Gamerscore;

	private string m_Gamertag;

	private string m_XboxUserId;

	public string ApplicationDisplayName
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Uri ApplicationDisplayPictureResizeUri
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedUri")]
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string GameDisplayName
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Uri GameDisplayPictureResizeUri
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedUri")]
		[CalledBy(Type = typeof(XboxUserProfile), Member = "GetGameDisplayPictureResizeUriForSize")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string Gamerscore
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string Gamertag
	{
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string XboxUserId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public XboxUserProfile(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public XboxUserProfile()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[CallerCount(Count = 52)]
	[DeduplicatedMethod]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	~XboxUserProfile()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(XboxUserProfile), Member = "get_GameDisplayPictureResizeUri")]
	[Calls(Type = typeof(Uri), Member = "get_AbsoluteUri")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsUnknownMethods(Count = 4)]
	public string GetGameDisplayPictureResizeUriForSize(Picture.Size size)
	{
		return null;
	}
}
