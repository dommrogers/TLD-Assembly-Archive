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
	public QueryRemainingQuotaAsyncOp(ConnectedStorage storage, QueryAsyncCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CalledBy(Type = typeof(ConnectedStorage), Member = "QueryRemainingQuotaAsyncThunk")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void Complete(uint result, long quota)
	{
	}
}
