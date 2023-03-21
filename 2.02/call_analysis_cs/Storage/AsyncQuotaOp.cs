using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class AsyncQuotaOp : AsyncOp<AsyncQuotaOp>
{
	public delegate void QuotaRequestDelegate(TitleStorage storage, AsyncQuotaOp op, StorageQuota quota);

	public TitleStorage Storage;

	public StorageQuota Quota;

	private QuotaRequestDelegate Callback;

	[CalledBy(Type = typeof(TitleStorage), Member = "RequestQuotaAsync")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public AsyncQuotaOp(TitleStorage storage, QuotaRequestDelegate callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Complete(uint result, StorageQuota quota)
	{
	}
}
