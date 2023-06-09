using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using Storage;

namespace UnityPlugin;

internal class StorageLog
{
	[PreserveSig]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "InitializedThunk")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "OnUserSignedOutThunk")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteContainerAsyncThunk")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "QueryRemainingQuotaAsyncThunk")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "ContainerInfoQueryAsyncThunk")]
	[CalledBy(Type = typeof(ContainerContext), Member = "GetAsyncThunk")]
	[CalledBy(Type = typeof(ContainerContext), Member = "ReadAsyncThunk")]
	[CalledBy(Type = typeof(ContainerContext), Member = "SubmitUpdatesAsyncThunk")]
	[CalledBy(Type = typeof(ContainerContext), Member = "BlobInfoQueryAsyncThunk")]
	[CalledBy(Type = typeof(TitleStorage), Member = "QuotaRequestThunk")]
	[CalledBy(Type = typeof(TitleStorage), Member = "SaveLoadRequestThunk")]
	[CalledBy(Type = typeof(TitleStorage), Member = "DeleteRequestThunk")]
	[CalledBy(Type = typeof(TitleStorage), Member = "UserSignedOutInvalidThunk")]
	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void LogCallbackException(string message);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public StorageLog()
	{
	}
}
