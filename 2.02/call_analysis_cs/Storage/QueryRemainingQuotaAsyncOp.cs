using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class QueryRemainingQuotaAsyncOp : AsyncOp<QueryRemainingQuotaAsyncOp>
{
	public delegate void QueryAsyncCallback(ConnectedStorage storage, QueryRemainingQuotaAsyncOp op, StorageQuota quota);

	public StorageQuota Quota;

	public ConnectedStorage Storage;

	public QueryAsyncCallback Callback;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public QueryRemainingQuotaAsyncOp(ConnectedStorage storage, QueryAsyncCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "QueryRemainingQuotaAsyncThunk")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Complete(uint result, long quota)
	{
	}
}
