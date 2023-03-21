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

	[CalledBy(Type = typeof(TitleStorage), Member = "UploadFileAsync")]
	[CalledBy(Type = typeof(TitleStorage), Member = "DownloadFileAsync")]
	[CalledBy(Type = typeof(TitleStorage), Member = "DownloadFileAsync")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SaveLoadOp(TitleStorage storage, byte[] buffer, SaveLoadDelegate callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveLoadDelegate), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Complete(uint result, uint size)
	{
	}
}
