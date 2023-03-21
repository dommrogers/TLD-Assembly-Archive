using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class SaveLoadOp : AsyncOp<SaveLoadOp>
{
	public delegate void SaveLoadDelegate(TitleStorage storage, SaveLoadOp op, uint size);

	public TitleStorage Storage;

	public byte[] Buffer;

	public uint Size;

	private SaveLoadDelegate Callback;

	[CalledBy(Type = typeof(TitleStorage), Member = "DownloadFileAsync")]
	[CalledBy(Type = typeof(TitleStorage), Member = "DownloadFileAsync")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(TitleStorage), Member = "UploadFileAsync")]
	public SaveLoadOp(TitleStorage storage, byte[] buffer, SaveLoadDelegate callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Complete(uint result, uint size)
	{
	}
}
