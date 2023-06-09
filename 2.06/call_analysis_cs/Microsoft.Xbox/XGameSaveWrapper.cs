using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xbox;

public class XGameSaveWrapper
{
	[StructLayout(0, Size = 1)]
	public struct XUserHandle
	{
	}

	public delegate void InitializeCallback(int hresult);

	public delegate void GetQuotaCallback(int hresult, long remainingQuota);

	public delegate void QueryContainersCallback(int hresult, string[] containerNames);

	public delegate void QueryBlobsCallback(int hresult, Dictionary<string, uint> blobInfos);

	public delegate void LoadCallback(int hresult, byte[] blobData);

	public delegate void SaveCallback(int hresult);

	public delegate void DeleteCallback(int hresult);

	private delegate void UpdateCallback(int hresult);

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	~XGameSaveWrapper()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void InitializeAsync(XUserHandle userHandle, string scid, InitializeCallback callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void GetQuotaAsync(GetQuotaCallback callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void QueryContainers(string containerNamePrefix, QueryContainersCallback callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void QueryContainerBlobs(string containerName, QueryBlobsCallback callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Load(string containerName, string blobName, LoadCallback callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Save(string containerName, string blobName, byte[] blobData, SaveCallback callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Delete(string containerName, DeleteCallback callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Delete(string containerName, string blobName, DeleteCallback callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Delete(string containerName, string[] blobNames, DeleteCallback callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update(string containerName, IDictionary<string, byte[]> blobsToSave, IList<string> blobsToDelete, UpdateCallback callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public XGameSaveWrapper()
	{
	}
}
