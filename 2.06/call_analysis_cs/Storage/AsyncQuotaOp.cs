using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class AsyncQuotaOp : AsyncOp<AsyncQuotaOp>
{
	public delegate void QuotaRequestDelegate(TitleStorage storage, AsyncQuotaOp op, StorageQuota quota);

	public TitleStorage Storage;

	public StorageQuota Quota;

	private QuotaRequestDelegate Callback;

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(TitleStorage), Member = "RequestQuotaAsync")]
	[CallsUnknownMethods(Count = 6)]
	public AsyncQuotaOp(TitleStorage storage, QuotaRequestDelegate callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Complete(uint result, StorageQuota quota)
	{
	}
}
