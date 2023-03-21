using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using TLD.Encryption;
using UnityEngine;
using UnityEngine.Networking;

public class WebUtils
{
	public class SteamCloudManager
	{
		public enum BatchType
		{
			Parallel,
			Sequence
		}

		private class BatchOperation : CommonCloudOperation
		{
			private sealed class _003CBatch_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public BatchOperation _003C_003E4__this;

				private List<CommonCloudOperation>.Enumerator _003C_003E7__wrap1;

				private CommonCloudOperation _003Coperation_003E5__3;

				private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
				{
					[DeduplicatedMethod]
					[CallerCount(Count = 28)]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[DebuggerHidden]
					[DeduplicatedMethod]
					[CallerCount(Count = 28)]
					get
					{
						return null;
					}
				}

				[DebuggerHidden]
				[DeduplicatedMethod]
				[CallerCount(Count = 0)]
				public _003CBatch_003Ed__10(int _003C_003E1__state)
				{
				}

				[CallsUnknownMethods(Count = 1)]
				[CalledBy(Type = typeof(_003CBatch_003Ed__10), Member = "MoveNext")]
				[CallerCount(Count = 1)]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 2)]
				[Calls(Type = typeof(BatchOperation), Member = "IsBatchCompleted")]
				[Calls(Type = typeof(BatchOperation), Member = "IsBatchSuccess")]
				[Calls(Type = typeof(_003CBatch_003Ed__10), Member = "System.IDisposable.Dispose")]
				[CallsUnknownMethods(Count = 13)]
				private bool MoveNext()
				{
					return default(bool);
				}

				[CallerCount(Count = 0)]
				private void _003C_003Em__Finally1()
				{
				}

				[DebuggerHidden]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
				[CallsUnknownMethods(Count = 4)]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			private Action<ICloudOperation> m_OnOperationComplete;

			private List<CommonCloudOperation> m_OperationList;

			private bool m_IsExecuting;

			private BatchType m_Type;

			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteLocalSave")]
			[CallsUnknownMethods(Count = 1)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "EnumerateForDeleteAllDone")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "Sync")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 9)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
			public BatchOperation(Action<ICloudOperation> onOperationComplete, BatchType type)
			{
			}

			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteLocalSave")]
			[CallsUnknownMethods(Count = 2)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteLocalSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "EnumerateForDeleteAllDone")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "Sync")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "Sync")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
			[CallerCount(Count = 15)]
			public void AddOperation(CommonCloudOperation operation)
			{
			}

			[CallsUnknownMethods(Count = 2)]
			[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
			[CallsUnknownMethods(Count = 2)]
			private void RemoveSuccessfullOperations()
			{
			}

			[CallsUnknownMethods(Count = 4)]
			[CallerCount(Count = 1)]
			[CalledBy(Type = typeof(_003CBatch_003Ed__10), Member = "MoveNext")]
			private bool IsBatchCompleted()
			{
				return default(bool);
			}

			[CalledBy(Type = typeof(BatchOperation), Member = "BatchDone")]
			[CallsUnknownMethods(Count = 4)]
			[CallerCount(Count = 2)]
			[CalledBy(Type = typeof(_003CBatch_003Ed__10), Member = "MoveNext")]
			private bool IsBatchSuccess()
			{
				return default(bool);
			}

			[IteratorStateMachine(typeof(_003CBatch_003Ed__10))]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			private IEnumerator Batch()
			{
				return null;
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(BatchOperation), Member = "IsBatchSuccess")]
			private void BatchDone()
			{
			}
		}

		public struct DeleteRequestResult
		{
			public string m_Filename;

			public bool m_Success;

			public string m_Error;
		}

		private class LocalFileDeleteOperation : CommonCloudOperation
		{
			private string m_FileName;

			[DeduplicatedMethod]
			[CallerCount(Count = 40)]
			public LocalFileDeleteOperation(string filename)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			public override void Execute()
			{
			}
		}

		private class DeleteOperation : CommonCloudOperation
		{
			private sealed class _003C_003Ec__DisplayClass7_0
			{
				public DeleteRequestResult result;

				public string filename;

				public DeleteOperation _003C_003E4__this;

				[CallerCount(Count = 6)]
				[DeduplicatedMethod]
				public _003C_003Ec__DisplayClass7_0()
				{
				}

				[CallsUnknownMethods(Count = 1)]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(DeleteOperation), Member = "RequestDeleteDataCompleted")]
				internal void _003CWebRequestDeleteData_003Eb__0(UnityWebRequest response)
				{
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				[Calls(Type = typeof(DeleteOperation), Member = "RequestDeleteDataCompleted")]
				[CallsUnknownMethods(Count = 1)]
				internal void _003CWebRequestDeleteData_003Eb__1(UnityWebRequest response)
				{
				}
			}

			private string m_Token;

			private string m_FileName;

			private Action<bool> m_OnOperationComplete;

			[CalledBy(Type = typeof(SteamCloudManager), Member = "EnumerateForDeleteAllDone")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
			[CallerCount(Count = 3)]
			public DeleteOperation(string token, string filename, Action<bool> onOperationComplete)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(DeleteOperation), Member = "WebRequestDeleteData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsUnknownMethods(Count = 1)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DeleteOperation), Member = "WebRequestDeleteData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsUnknownMethods(Count = 1)]
			public void RequestDeleteData(string token, string filename)
			{
			}

			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass7_0), Member = "<WebRequestDeleteData>b__1")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass7_0), Member = "<WebRequestDeleteData>b__0")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			private void RequestDeleteDataCompleted(DeleteRequestResult result)
			{
			}

			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			[CalledBy(Type = typeof(DeleteOperation), Member = "RequestDeleteData")]
			[CalledBy(Type = typeof(DeleteOperation), Member = "Execute")]
			[Calls(Type = typeof(Utils), Member = "WebRequest")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(WWWForm), Member = ".ctor")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			private IEnumerator WebRequestDeleteData(string token, string filename)
			{
				return null;
			}
		}

		private class DownloadSaveOperation : CommonCloudOperation
		{
			private string m_FileName;

			private DateTime m_DateTime;

			private DownloadOperation m_DownloadOperation;

			private Action<bool> m_OnOperationComplete;

			[CallsUnknownMethods(Count = 2)]
			[CallerCount(Count = 1)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
			public DownloadSaveOperation(string filename, DateTime dateTime, string url, string sha1, Action<bool> onOperationComplete)
			{
			}

			[CallsUnknownMethods(Count = 1)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 0)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 3)]
			private void DownloadDone(DownloadDataResult result)
			{
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			private void OperationFailed()
			{
			}
		}

		private class DownloadOperation : CommonCloudOperation
		{
			private string m_Url;

			private string m_FileName;

			private string m_Sha1;

			private Action<DownloadDataResult> m_OnOperationComplete;

			[CallerCount(Count = 0)]
			public DownloadOperation(string filename, string url, string sha1, Action<DownloadDataResult> onOperationComplete)
			{
			}

			[Calls(Type = typeof(WebUtils), Member = "DownloadData")]
			[CallsUnknownMethods(Count = 2)]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "ComputeSha1Hex")]
			[Calls(Type = typeof(string), Member = "Concat")]
			private void DownloadDone(DownloadDataResult result)
			{
			}
		}

		public struct EnumerateFilesResult
		{
			public enum ResultType
			{
				Success,
				Error,
				Empty
			}

			public struct FileInfo
			{
				public readonly string m_Filename;

				public readonly DateTime m_DateTime;

				public readonly string m_Sha;

				public readonly uint m_Filesize;

				public readonly string m_Url;

				[CallerCount(Count = 3)]
				[CalledBy(Type = typeof(EnumerateFilesResult), Member = ".cctor")]
				[CalledBy(Type = typeof(EnumerateFilesOperation._003C_003Ec__DisplayClass5_0), Member = "<WebRequestEnumerateFiles>b__0")]
				[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
				public FileInfo(string fileName, DateTime dateTime, string sha, uint size, string url)
				{
				}

				[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
				[CallerCount(Count = 0)]
				public bool IsContentIdentical(FileInfo other)
				{
					return default(bool);
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(FileInfo), Member = "op_Equality")]
				[CallsUnknownMethods(Count = 1)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(ValueType), Member = "GetHashCode")]
				public override int GetHashCode()
				{
					return default(int);
				}

				[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
				[CalledBy(Type = typeof(SteamCloudManager), Member = "GetLocalFileSyncStatus")]
				[CalledBy(Type = typeof(SteamCloudManager), Member = "GetCloudFileSyncStatus")]
				[CalledBy(Type = typeof(SteamCloudManager), Member = "AreFilesIdentical")]
				[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
				[CalledBy(Type = typeof(FileInfo), Member = "Equals")]
				[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
				[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
				[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
				[CallerCount(Count = 6)]
				public static bool operator ==(FileInfo a, FileInfo b)
				{
					return default(bool);
				}

				[CalledBy(Type = typeof(SteamCloudManager), Member = "AddToListIfNotFound")]
				[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
				[CalledBy(Type = typeof(SteamCloudManager), Member = "FileExists")]
				[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
				[CallerCount(Count = 2)]
				[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
				public static bool operator !=(FileInfo a, FileInfo b)
				{
					return default(bool);
				}
			}

			public static FileInfo INVALID_FILEINFO;

			public ResultType m_ResultType;

			public string m_Error;

			public List<FileInfo> m_Files;

			public ICloudOperation m_CloudOperation;
		}

		private class EnumerateFilesOperation : CommonCloudOperation
		{
			private sealed class _003C_003Ec__DisplayClass5_0
			{
				public EnumerateFilesResult result;

				public EnumerateFilesOperation _003C_003E4__this;

				[DeduplicatedMethod]
				[CallerCount(Count = 6)]
				public _003C_003Ec__DisplayClass5_0()
				{
				}

				[Calls(Type = typeof(string), Member = "Format")]
				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 3)]
				[Calls(Type = typeof(DateTime), Member = "Add")]
				[Calls(Type = typeof(string), Member = "Concat")]
				[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = ".ctor")]
				[CallsUnknownMethods(Count = 6)]
				internal void _003CWebRequestEnumerateFiles_003Eb__0(UnityWebRequest response)
				{
				}

				[CallsUnknownMethods(Count = 1)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallerCount(Count = 0)]
				internal void _003CWebRequestEnumerateFiles_003Eb__1(UnityWebRequest response)
				{
				}
			}

			private string m_Token;

			private Action<EnumerateFilesResult> m_OnOperationComplete;

			[CallsUnknownMethods(Count = 8)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "GetAllFiles")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateFileEnumerationOperationForSync")]
			[Calls(Type = typeof(Delegate), Member = "Combine")]
			[Calls(Type = typeof(Delegate), Member = "Combine")]
			[CallerCount(Count = 3)]
			[CalledBy(Type = typeof(AuthenticateOperation._003CAuthenticate_003Ed__6), Member = "MoveNext")]
			public EnumerateFilesOperation(string token, Action<EnumerateFilesResult> onOperationComplete1, Action<EnumerateFilesResult> onOperationComplete2)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(EnumerateFilesOperation), Member = "WebRequestEnumerateFiles")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsUnknownMethods(Count = 1)]
			public override void Execute()
			{
			}

			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[Calls(Type = typeof(EnumerateFilesOperation), Member = "WebRequestEnumerateFiles")]
			[CallerCount(Count = 0)]
			private void RequestEnumerateFiles(string token, bool extendedDetails)
			{
			}

			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(string), Member = "Format")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(Utils), Member = "WebRequest")]
			[CalledBy(Type = typeof(EnumerateFilesOperation), Member = "Execute")]
			[CalledBy(Type = typeof(EnumerateFilesOperation), Member = "RequestEnumerateFiles")]
			[CallsUnknownMethods(Count = 17)]
			private IEnumerator WebRequestEnumerateFiles(string token, bool extendedDetails)
			{
				return null;
			}

			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 0)]
			private void RequestEnumerateFilesDone(EnumerateFilesResult result)
			{
			}
		}

		public class Enumerate
		{
			public class EnumerateUserFiles_v1
			{
				public class ResponseData
				{
					public class FileInfo
					{
						public uint file_size;

						public ulong timestamp;

						public string filename;

						public string file_sha;

						public string url;

						[DeduplicatedMethod]
						[CallerCount(Count = 6)]
						public FileInfo()
						{
						}
					}

					public List<FileInfo> files;

					public uint total_files;

					[DeduplicatedMethod]
					[CallerCount(Count = 6)]
					public ResponseData()
					{
					}
				}

				public ResponseData response;

				[DeduplicatedMethod]
				[CallerCount(Count = 6)]
				public EnumerateUserFiles_v1()
				{
				}
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			public static EnumerateUserFiles_v1 ParseJson(string txt)
			{
				return null;
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 6)]
			public Enumerate()
			{
			}
		}

		private enum CloudSyncStatus
		{
			CloudOnly,
			LocalOnly,
			CloudNewer,
			LocalNewer,
			CloudOlder,
			LocalOlder,
			ContentIdentical
		}

		private enum SyncConflictResult
		{
			AcceptCloud,
			AcceptLocal
		}

		public struct BeginUploadRequestResult
		{
			public bool m_Success;

			public Upload.BeginHTTPUpload_v1 m_Result;

			public string m_Response;

			public string m_Filename;

			public string m_Error;
		}

		public struct UploadPutRequestResult
		{
			public bool m_Success;

			public long m_ResponseCode;

			public string m_Error;
		}

		public struct UploadCommitRequestResult
		{
			public bool m_Success;

			public string m_Error;

			public bool m_TransferSuccess;
		}

		private class UploadOperation : CommonCloudOperation
		{
			private sealed class _003C_003Ec__DisplayClass14_0
			{
				public BeginUploadRequestResult result;

				public string filename;

				public UploadOperation _003C_003E4__this;

				[DeduplicatedMethod]
				[CallerCount(Count = 6)]
				public _003C_003Ec__DisplayClass14_0()
				{
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 3)]
				[Calls(Type = typeof(UploadOperation), Member = "RequestUploadData_BeginDone")]
				[CallsUnknownMethods(Count = 1)]
				internal void _003CWebRequestBeginUploadData_003Eb__0(UnityWebRequest response)
				{
				}

				[CallsUnknownMethods(Count = 1)]
				[Calls(Type = typeof(UploadOperation), Member = "RequestUploadData_BeginDone")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				internal void _003CWebRequestBeginUploadData_003Eb__1(UnityWebRequest response)
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass15_0
			{
				public UploadCommitRequestResult result;

				public bool transfer_succeeded;

				public UploadOperation _003C_003E4__this;

				[DeduplicatedMethod]
				[CallerCount(Count = 6)]
				public _003C_003Ec__DisplayClass15_0()
				{
				}

				[CallsUnknownMethods(Count = 1)]
				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 2)]
				[Calls(Type = typeof(UploadOperation), Member = "RequestUploadData_CommitDone")]
				internal void _003CWebRequestCommitUpload_003Eb__0(UnityWebRequest response)
				{
				}

				[CallsUnknownMethods(Count = 1)]
				[Calls(Type = typeof(UploadOperation), Member = "RequestUploadData_CommitDone")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				internal void _003CWebRequestCommitUpload_003Eb__1(UnityWebRequest response)
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass16_0
			{
				public UploadPutRequestResult result;

				public UploadOperation _003C_003E4__this;

				public string filename;

				[DeduplicatedMethod]
				[CallerCount(Count = 6)]
				public _003C_003Ec__DisplayClass16_0()
				{
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 7)]
				[Calls(Type = typeof(string), Member = "Format")]
				[Calls(Type = typeof(UploadOperation), Member = "RequestUploadData_PutDone")]
				[CallsUnknownMethods(Count = 7)]
				internal void _003CWebRequestUploadData_003Eb__0(UnityWebRequest response)
				{
				}

				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 2)]
				[Calls(Type = typeof(UploadOperation), Member = "RequestUploadData_PutDone")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				internal void _003CWebRequestUploadData_003Eb__1(UnityWebRequest response)
				{
				}
			}

			private string m_Token;

			private string m_FileName;

			private byte[] m_Bytes;

			private string m_FileSha;

			private Action<bool> m_OnOperationComplete;

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(WebUtils), Member = "ComputeSha1Hex")]
			public UploadOperation(string token, string filename, byte[] data, Action<bool> onOperationComplete)
			{
			}

			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestBeginUploadData")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 0)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestBeginUploadData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsUnknownMethods(Count = 1)]
			public void RequestBeginUploadData(string token, int filesize, string filename, string filesha)
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestUploadData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsUnknownMethods(Count = 1)]
			public void RequestUploadData(string url_host, string url_path, string filename, Dictionary<string, string> httpHeaders, byte[] data)
			{
			}

			[CallsUnknownMethods(Count = 1)]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestUploadData_PutDone")]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestUploadData_BeginDone")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestCommitUpload")]
			[CallerCount(Count = 2)]
			public void RequestCommitUpload(string token, bool transfer_succeeded, string filename, string filesha)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			private void OperationFailed()
			{
			}

			[CallsUnknownMethods(Count = 4)]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass14_0), Member = "<WebRequestBeginUploadData>b__1")]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass14_0), Member = "<WebRequestBeginUploadData>b__0")]
			[Calls(Type = typeof(UploadOperation), Member = "RequestCommitUpload")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestUploadData")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			private void RequestUploadData_BeginDone(BeginUploadRequestResult result)
			{
			}

			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass16_0), Member = "<WebRequestUploadData>b__0")]
			[Calls(Type = typeof(UploadOperation), Member = "RequestCommitUpload")]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass16_0), Member = "<WebRequestUploadData>b__1")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			private void RequestUploadData_PutDone(UploadPutRequestResult result)
			{
			}

			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(Debug), Member = "LogError")]
			[Calls(Type = typeof(string), Member = "Format")]
			[Calls(Type = typeof(string), Member = "Format")]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass15_0), Member = "<WebRequestCommitUpload>b__0")]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass15_0), Member = "<WebRequestCommitUpload>b__1")]
			private void RequestUploadData_CommitDone(UploadCommitRequestResult result)
			{
			}

			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(int), Member = "ToString")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(Utils), Member = "WebRequest")]
			[CalledBy(Type = typeof(UploadOperation), Member = "Execute")]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestBeginUploadData")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Format")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WWWForm), Member = ".ctor")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(string), Member = "Concat")]
			private IEnumerator WebRequestBeginUploadData(string token, int filesize, string filename, string filesha)
			{
				return null;
			}

			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(Utils), Member = "WebRequest")]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestCommitUpload")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(string), Member = "Format")]
			[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
			[Calls(Type = typeof(WWWForm), Member = ".ctor")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			private IEnumerator WebRequestCommitUpload(string token, bool transfer_succeeded, string filename, string filesha)
			{
				return null;
			}

			[CalledBy(Type = typeof(UploadOperation), Member = "RequestUploadData")]
			[Calls(Type = typeof(Utils), Member = "WebRequestPut")]
			[CallsUnknownMethods(Count = 1)]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestUploadData_BeginDone")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "StartsWith")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 2)]
			private IEnumerator WebRequestUploadData(string url_host, string url_path, string filename, Dictionary<string, string> httpHeaders, byte[] data)
			{
				return null;
			}
		}

		public class Upload
		{
			public class BeginHTTPUpload_v1
			{
				public class ResponseData
				{
					public class HttpHeader
					{
						public string name;

						public string value;

						[DeduplicatedMethod]
						[CallerCount(Count = 6)]
						public HttpHeader()
						{
						}
					}

					public ulong ugcid;

					public uint timestamp;

					public string url_host;

					public string url_path;

					public bool use_https;

					public List<HttpHeader> request_headers;

					[DeduplicatedMethod]
					[CallerCount(Count = 6)]
					public ResponseData()
					{
					}
				}

				public ResponseData response;

				[DeduplicatedMethod]
				[CallerCount(Count = 6)]
				public BeginHTTPUpload_v1()
				{
				}
			}

			public class CommitHTTPUpload_v1
			{
				public class ResponseData
				{
					public bool file_committed;

					[DeduplicatedMethod]
					[CallerCount(Count = 6)]
					public ResponseData()
					{
					}
				}

				public ResponseData response;

				[CallerCount(Count = 6)]
				[DeduplicatedMethod]
				public CommitHTTPUpload_v1()
				{
				}
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			public static BeginHTTPUpload_v1 ParseJson(string txt)
			{
				return null;
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public static bool IsCommitHTTPUploadSuccess(string response)
			{
				return default(bool);
			}

			[CallerCount(Count = 6)]
			[DeduplicatedMethod]
			public Upload()
			{
			}
		}

		private class UploadSaveOperation : CommonCloudOperation
		{
			private string m_FileName;

			private string m_Token;

			private UploadOperation m_UploadOperation;

			private Action<bool> m_OnOperationComplete;

			[CallerCount(Count = 2)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			public UploadSaveOperation(string token, string fileName, Action<bool> onOperationComplete)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 3)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			private void DownloadDone(bool result)
			{
			}

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[CallsDeduplicatedMethods(Count = 1)]
			private void OperationFailed()
			{
			}
		}

		private class WaitSaveOperation : CommonCloudOperation
		{
			private sealed class _003CWaitSaveOperationComplete_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public WaitSaveOperation _003C_003E4__this;

				private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
				{
					[CallerCount(Count = 28)]
					[DeduplicatedMethod]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[DebuggerHidden]
					[DeduplicatedMethod]
					[CallerCount(Count = 28)]
					get
					{
						return null;
					}
				}

				[DeduplicatedMethod]
				[CallerCount(Count = 0)]
				[DebuggerHidden]
				public _003CWaitSaveOperationComplete_003Ed__3(int _003C_003E1__state)
				{
				}

				[CallerCount(Count = 6)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
				[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
				[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
				[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
				[CallsUnknownMethods(Count = 1)]
				private bool MoveNext()
				{
					return default(bool);
				}

				[DebuggerHidden]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
				[CallsUnknownMethods(Count = 4)]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			private Action m_OnOperationComplete;

			[CallerCount(Count = 40)]
			[DeduplicatedMethod]
			public WaitSaveOperation(Action onCompleted)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsUnknownMethods(Count = 1)]
			public override void Execute()
			{
			}

			[IteratorStateMachine(typeof(_003CWaitSaveOperationComplete_003Ed__3))]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			private IEnumerator WaitSaveOperationComplete()
			{
				return null;
			}
		}

		private class AuthenticateOperation : CommonCloudOperation
		{
			private enum OperationStatus
			{
				Cancel,
				Retry,
				Success,
				ShowingRetryDialog,
				RetrieveToken,
				RetrievingToken,
				VerifyToken,
				VerifyingToken
			}

			private sealed class _003CAuthenticate_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public AuthenticateOperation _003C_003E4__this;

				private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
				{
					[DebuggerHidden]
					[DeduplicatedMethod]
					[CallerCount(Count = 28)]
					get
					{
						return null;
					}
				}

				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[DeduplicatedMethod]
					[DebuggerHidden]
					[CallerCount(Count = 28)]
					get
					{
						return null;
					}
				}

				[CallerCount(Count = 0)]
				[DeduplicatedMethod]
				[DebuggerHidden]
				public _003CAuthenticate_003Ed__6(int _003C_003E1__state)
				{
				}

				[DebuggerHidden]
				[DeduplicatedMethod]
				[CallerCount(Count = 6)]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Calls(Type = typeof(AuthenticateOperation), Member = "RetrieveToken")]
				[Calls(Type = typeof(EnumerateFilesOperation), Member = ".ctor")]
				[CallsUnknownMethods(Count = 2)]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(AuthenticateOperation), Member = "AuthenticationComplete")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[DebuggerHidden]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
				[CallsUnknownMethods(Count = 4)]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			private string m_Token;

			private Action<bool> m_OnOperationComplete;

			private OperationStatus m_Status;

			[CalledBy(Type = typeof(SteamCloudManager), Member = "Sync")]
			[CallerCount(Count = 2)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "Authenticate")]
			public AuthenticateOperation(string token, Action<bool> onOperationComplete)
			{
			}

			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			public override void Execute()
			{
			}

			[IteratorStateMachine(typeof(_003CAuthenticate_003Ed__6))]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			private IEnumerator Authenticate()
			{
				return null;
			}

			[CallAnalysisFailed]
			[CallerCount(Count = 0)]
			private void Update()
			{
			}

			[CalledBy(Type = typeof(AuthenticateOperation), Member = "EnumerateForAuthenticationDone")]
			[CalledBy(Type = typeof(AuthenticateOperation), Member = "Success")]
			[CalledBy(Type = typeof(_003CAuthenticate_003Ed__6), Member = "MoveNext")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallerCount(Count = 3)]
			private void AuthenticationComplete()
			{
			}

			[CallAnalysisFailed]
			[CallerCount(Count = 1)]
			[CalledBy(Type = typeof(_003CAuthenticate_003Ed__6), Member = "MoveNext")]
			private void RetrieveToken()
			{
			}

			[CalledBy(Type = typeof(AuthenticateOperation), Member = "EnumerateForAuthenticationDone")]
			[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 3)]
			private void ShowRetryDialog()
			{
			}

			[CallerCount(Count = 0)]
			private void CancelAuthentication(bool wasCanceled)
			{
			}

			[CallerCount(Count = 0)]
			private void RetryAuthentication()
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AuthenticateOperation), Member = "ShowRetryDialog")]
			[Calls(Type = typeof(AuthenticateOperation), Member = "AuthenticationComplete")]
			private void EnumerateForAuthenticationDone(EnumerateFilesResult result)
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AuthenticateOperation), Member = "AuthenticationComplete")]
			private void Success()
			{
			}

			[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(SteamCloudManager), Member = "SetToken")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
			private static void SaveToken(string token)
			{
			}
		}

		public struct AuthenticationResult
		{
			public enum ResultType
			{
				Success,
				AccessDenied,
				MalformedUrlError,
				Canceled
			}

			public ResultType m_Result;

			public string m_Token;
		}

		public interface ICloudOperation
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 101262)]
			bool IsCompleted();

			[DeduplicatedMethod]
			[CallerCount(Count = 101262)]
			bool IsSuccess();

			[DeduplicatedMethod]
			[CallerCount(Count = 101262)]
			bool IsRetryPending();
		}

		private class CommonCloudOperation : ICloudOperation
		{
			protected bool m_Completed;

			protected bool m_Success;

			protected Action m_OnExecuteStarted;

			private int m_NumRetries;

			private int m_RetryCount;

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			public bool IsCompleted()
			{
				return default(bool);
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			public bool IsSuccess()
			{
				return default(bool);
			}

			[CallerCount(Count = 0)]
			public bool IsRetryPending()
			{
				return default(bool);
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			public void SetNumRetries(int numRetries)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			public virtual void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			private void Reset()
			{
			}

			[CallerCount(Count = 79)]
			[DeduplicatedMethod]
			public void SetOnExecuteStarted(Action onExecuteStarted)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(string), Member = "Format")]
			public bool Retry()
			{
				return default(bool);
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 6)]
			public CommonCloudOperation()
			{
			}
		}

		public const int MAX_SYNCOPERATION_RETRIES = 3;

		private Dictionary<CloudSyncStatus, List<EnumerateFilesResult.FileInfo>> m_CloudFilesBySyncStatus;

		private static readonly int s_CloudSyncStatusCount;

		private SyncConflictResult m_SyncConflictResult;

		private bool m_SaveFilesSynchronized;

		private bool m_SaveFilesSynchronizationStarted;

		private bool m_AreCloudFilesNewer;

		public const string STEAMCLOUD_SYNCING_LOCID = "STEAMCLOUD_Syncing";

		public const string STEAMCLOUD_SYNC_LOCID = "STEAMCLOUD_Sync";

		public const string STEAMCLOUD_SYNC_ON_LOCID = "STEAMCLOUD_SyncOn";

		public const string STEAMCLOUD_SYNC_OFF_LOCID = "STEAMCLOUD_SyncOff";

		public const string STEAMCLOUD_RETRIEVINGFILES_LOCID = "STEAMCLOUD_RetrievingFiles";

		public const string STEAMCLOUD_SYNCFAILED_LOCID = "STEAMCLOUD_SynchronizationFailed";

		public const string STEAMCLOUD_AUTH_FAILED_LOCID = "STEAMCLOUD_AuthenticationFailed";

		public const string STEAMCLOUD_AUTH_RETRY_LOCID = "STEAMCLOUD_RetryAuthentication";

		public const string STEAMCLOUD_CONFLICT_TITLE_LOCID = "STEAMCLOUD_ConflictTitle";

		public const string STEAMCLOUD_CLOUD_NEWER_LOCID = "STEAMCLOUD_CloudFilesNewerConfirm";

		public const string STEAMCLOUD_LOCAL_NEWER_LOCID = "STEAMCLOUD_LocalFilesNewerConfirm";

		private const string STEAM_AUTH_URL = "https://steamcommunity.com/oauth/login?response_type=token&state=void&mobileminimal=1";

		private const string STEAM_CLIENT_ID = "CEF005FA";

		private const string STEAMAUTH_CALLBACKURL = "https://tldnewseditor.com/steamauth";

		private const string STEAMAUTH_CALLBACKABLEURL = "https://steamcommunity.com/oauth";

		private const string STEAMAUTH_TOKENPARAM = "access_token";

		private const string STEAMAUTH_ERRORARAM = "error";

		private const string STEAMAUTH_ACCESSDENIED_ERROR = "access_denied";

		private string m_Token;

		private static SteamCloudManager s_Instance;

		private CommonCloudOperation m_CurrentCloudOperation;

		private DateTime m_LastEnumerationTime;

		private List<EnumerateFilesResult.FileInfo> m_CloudFiles;

		private List<EnumerateFilesResult.FileInfo> m_LocalFiles;

		private Queue<CommonCloudOperation> m_OperationsQueue;

		private string m_CurrentMessageId;

		private const string STEAM_URL_ENUMERATE = "https://api.steampowered.com/ICloudService/EnumerateUserFiles/v1/";

		private const string STEAM_URL_REQUESTUPLOAD = "https://api.steampowered.com/ICloudService/BeginHTTPUpload/v1";

		private const string STEAM_URL_COMMITUPLOAD = "https://api.steampowered.com/ICloudService/CommitHTTPUpload/v1";

		private const string STEAM_URL_REQUESTDELETE = "https://api.steampowered.com/ICloudService/Delete/v1";

		public const string SAVE_CLOUD_PATH = "%WinAppDataLocal%Hinterland/TheLongDark/";

		private const string STEAM_APP_ID = "305620";

		private const string PLATFORM_TO_SYNC = "All";

		private Action<bool> m_OnSyncEnabledChanged;

		private Action m_OnSyncDone;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsUnknownMethods(Count = 1)]
		private void EnumerateLocalFiles()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		private static bool WriteDownloadedSaveFile(DownloadDataResult result, string filename, DateTime dateTime)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private static bool ReadSaveFile(string filename, out byte[] bytes)
		{
			bytes = null;
			return default(bool);
		}

		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		private static bool DeleteSaveFile(string filename)
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "FileEnumerationForSyncComplete")]
		[Calls(Type = typeof(string), Member = "Contains")]
		[Calls(Type = typeof(SaveGameSlots), Member = "IsValidSavedGameName")]
		[Calls(Type = typeof(SaveGameSystem), Member = "IsProfileFilename")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[Calls(Type = typeof(SaveGameSystem), Member = "IsSettingsFilename")]
		[Calls(Type = typeof(Path), Member = "ChangeExtension")]
		public static bool CloudFileRequiresSync(string fileName)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(DateTime), Member = "get_Now")]
		[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
		public static DateTime GetDateTimeFromSave(byte[] data)
		{
			return default(DateTime);
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
		[Calls(Type = typeof(SaveGameSlots), Member = "ReInit")]
		[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		public void ReloadSaves()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		public bool IsSyncSavesEnabled()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetAllFiles")]
		[CallsUnknownMethods(Count = 2)]
		public void RetrieveFilesForSync()
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "GetCloudSaveFilename")]
		[CallerCount(Count = 0)]
		public void HandleSaveDeleted(string saveFilename)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		private void DeleteSaveStarted()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		private void DeleteSaveDone(bool res)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool HasSyncStarted()
		{
			return default(bool);
		}

		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(AuthenticateOperation), Member = ".ctor")]
		public void Sync()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCloudSaveFilename")]
		public void HandleDataSaved(string filename)
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "GetAllFiles")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void AuthenticateForSyncDone(ICloudOperation operation)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[CallsUnknownMethods(Count = 1)]
		private void ReplaceCloudSave(string cloudFileName)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		private void ReplaceCloudSaveStarted()
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void ReplaceCloudSaveDone(ICloudOperation operation)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		private void SyncStarted()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		private void RetrieveFilesForSyncSyncStarted()
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "AreFilesIdentical")]
		[Calls(Type = typeof(SteamCloudManager), Member = "RequestUserConfirmation")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		private void SyncInternal()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AreFilesIdentical")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(SteamCloudManager), Member = "RequestUserConfirmation")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
		private void CloudFilesRetrievedForSync(EnumerateFilesResult res)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		private void CloudSyncLocalNewerDeclined(bool wasCancelled)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		private void CloudSyncLocalNewerAccepted()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		private void CloudSyncNewerDeclined(bool wasCancelled)
		{
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
		private void CloudSyncNewerAccepted()
		{
		}

		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudSyncLocalNewerDeclined")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudSyncNewerDeclined")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "RequestUserConfirmation")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudSyncLocalNewerAccepted")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 17)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteLocalSave")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
		private void DoSyncOperation()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		private void SyncingFilesOperationStarted()
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
		[Calls(Type = typeof(SaveGameSlots), Member = "ReInit")]
		[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
		[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		private void SyncDone(ICloudOperation cloudOperation)
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private void NotifySyncDone()
		{
		}

		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallerCount(Count = 0)]
		private void ReloadSavesReady()
		{
		}

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "RequestUserConfirmation")]
		[CallsUnknownMethods(Count = 9)]
		private bool AreCloudFilesNewer()
		{
			return default(bool);
		}

		[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudFilesRetrievedForSync")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncInternal")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AreCloudFilesNewer")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		private void RequestUserConfirmation()
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "AddToListIfNotFound")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudFilesRetrievedForSync")]
		[CallsUnknownMethods(Count = 11)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncInternal")]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddToListIfNotFound")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ClearCloudFilesBySyncStatus")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		private void GatherFilesStatus()
		{
		}

		[CallsUnknownMethods(Count = 8)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		private void ClearCloudFilesBySyncStatus()
		{
		}

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Inequality")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[CallsUnknownMethods(Count = 2)]
		private void AddToListIfNotFound(EnumerateFilesResult.FileInfo info, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(DownloadSaveOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		private void AddBatchDownloadSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(UploadSaveOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CallsUnknownMethods(Count = 4)]
		private void AddBatchUploadSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DeleteOperation), Member = ".ctor")]
		private void AddBatchDeleteSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		private void AddBatchDeleteLocalSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CallsUnknownMethods(Count = 3)]
		private void AddBatchUploadReplaceSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReplaceCloudSave")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(UploadSaveOperation), Member = ".ctor")]
		[Calls(Type = typeof(DeleteOperation), Member = ".ctor")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		private BatchOperation CreateUploadReplaceSaveFileOperation(string cloudFileName, Action<ICloudOperation> onOperationComplete)
		{
			return null;
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudFilesRetrievedForSync")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncInternal")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		private bool AreFilesIdentical(List<EnumerateFilesResult.FileInfo> filesToCompare)
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetLocalFileSyncStatus")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetCloudFileSyncStatus")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "FileExists")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AreFilesIdentical")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AddToListIfNotFound")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(Path), Member = "ChangeExtension")]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[Calls(Type = typeof(Path), Member = "ChangeExtension")]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		private EnumerateFilesResult.FileInfo FindFile(string filename, List<EnumerateFilesResult.FileInfo> filesToSearch)
		{
			return default(EnumerateFilesResult.FileInfo);
		}

		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Inequality")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		private bool FileExists(EnumerateFilesResult.FileInfo fileInfo, List<EnumerateFilesResult.FileInfo> comparedToList)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		private CloudSyncStatus GetCloudFileSyncStatus(EnumerateFilesResult.FileInfo cloudInfo)
		{
			return default(CloudSyncStatus);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		private CloudSyncStatus GetLocalFileSyncStatus(EnumerateFilesResult.FileInfo localInfo)
		{
			return default(CloudSyncStatus);
		}

		[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
		[Calls(Type = typeof(DateTime), Member = "get_Now")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private static bool TryExtractTimeStampFromSave(byte[] data, out DateTime timestamp)
		{
			System.Runtime.CompilerServices.Unsafe.As<DateTime, @null>(ref timestamp) = null;
			return default(bool);
		}

		[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
		[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
		[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
		private static bool IsSaveOperationInProgress()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		public static AuthenticationResult RequestAuthenticationToken()
		{
			return default(AuthenticationResult);
		}

		[CallerCount(Count = 0)]
		public static string GetAuthenticationRequestUrl()
		{
			return null;
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[CallsUnknownMethods(Count = 5)]
		private SteamCloudManager()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		public string GetToken()
		{
			return null;
		}

		[CalledBy(Type = typeof(AuthenticateOperation), Member = "SaveToken")]
		[CalledBy(Type = typeof(ConsoleManager), Member = "SaveToken")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 3)]
		public void SetToken(string token)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "UpdateQueue")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallsUnknownMethods(Count = 1)]
		public void Update()
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "Update")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(GameManager), Member = "Update")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Format")]
		private void UpdateQueue()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(AuthenticateOperation), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void Authenticate()
		{
		}

		[CallerCount(Count = 28)]
		[Calls(Type = typeof(SteamCloudManager), Member = ".ctor")]
		[CallsUnknownMethods(Count = 1)]
		public static SteamCloudManager GetInstance()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private bool HasSyncMessage()
		{
			return default(bool);
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[CallerCount(Count = 0)]
		private void UpdateSyncMessage()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private void QueueOperation(CommonCloudOperation cloudOperation)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EnumerateFilesOperation), Member = ".ctor")]
		[CallsUnknownMethods(Count = 2)]
		private CommonCloudOperation CreateFileEnumerationOperationForSync(Action<EnumerateFilesResult> onActionComplete, Action onOperationStarted)
		{
			return null;
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "DeleteAllCloudFiles")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AuthenticateForSyncDone")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(EnumerateFilesOperation), Member = ".ctor")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "RetrieveFilesForSync")]
		public void GetAllFiles(Action<EnumerateFilesResult> onActionComplete, Action onOperationStarted, int numRetries)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public bool IsOperationPending()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		public bool IsSyncPending()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetAllFiles")]
		[CallsUnknownMethods(Count = 2)]
		public void DeleteAllCloudFiles()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public void EnableSyncSaves(bool enabled)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		public bool AreSaveFilesSynchronized()
		{
			return default(bool);
		}

		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 4)]
		[CallerCount(Count = 0)]
		public void RegisterSyncEnabledChanged(Action<bool> onSyncEnabledChanged)
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		public void UnRegisterSyncEnabledChanged(Action<bool> onSyncEnabledChanged)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		public void RegisterSyncDone(Action onSyncDone)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		public void UnRegisterSyncDone(Action onSyncDone)
		{
		}

		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.DateTimeFormat), Member = "Format")]
		public static void DebugLogFiles(EnumerateFilesResult result)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "DeleteSaveStarted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReplaceCloudSaveStarted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncStarted")]
		[Calls(Type = typeof(GameObject), Member = "SetActive")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncingFilesOperationStarted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "Update")]
		[CalledBy(Type = typeof(GameManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "RetrieveFilesForSyncSyncStarted")]
		[Calls(Type = typeof(UILabel), Member = "set_text")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "UpdateSyncMessage")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCurrentMessageLabel")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 4)]
		public static void ShowSyncMessage(string locId)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncDone")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReloadSavesReady")]
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReplaceCloudSaveDone")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "UpdateSyncMessage")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AuthenticateForSyncDone")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudFilesRetrievedForSync")]
		[CalledBy(Type = typeof(GameManager), Member = "Update")]
		[CallerCount(Count = 9)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DeleteSaveDone")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GameObject), Member = "SetActive")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCurrentMessageLabel")]
		public static void HideSyncMessage()
		{
		}

		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[Calls(Type = typeof(Path), Member = "ChangeExtension")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "HandleSaveDeleted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "HandleDataSaved")]
		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
		public static string GetCloudSaveFilename(string filename)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		private bool IsCurrentOperationPending()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetAllFiles")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReplaceCloudSave")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncDone")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReloadSaves")]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "Sync")]
		[CallsDeduplicatedMethods(Count = 1)]
		private void ProcessOperation(CommonCloudOperation cloudOperation, int numRetries)
		{
		}

		[CallerCount(Count = 0)]
		private bool HasToken()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "get_Now")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(SteamCloudManager), Member = "CloudFileRequiresSync")]
		[CallsUnknownMethods(Count = 5)]
		private void FileEnumerationForSyncComplete(EnumerateFilesResult result)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(DeleteOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[CallsUnknownMethods(Count = 4)]
		private void EnumerateForDeleteAllDone(EnumerateFilesResult result)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 9)]
		private static UILabel GetCurrentMessageLabel()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		private static void RefreshCurrentSaveUI()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
		private static void RefreshSaveUI<T>(SaveSlotType saveSlotType) where T : Panel_Base
		{
		}
	}

	public struct DownloadDataResult
	{
		public bool m_Success;

		public byte[] m_Result;

		public string m_Error;
	}

	public class SteamCloudManagerPC
	{
		[Calls(Type = typeof(WebUtils), Member = "ComputeSha1Hex")]
		[Calls(Type = typeof(SteamCloudManager), Member = "CloudFileRequiresSync")]
		[Calls(Type = typeof(SteamCloudManager.EnumerateFilesResult.FileInfo), Member = ".ctor")]
		[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
		[Calls(Type = typeof(DateTime), Member = "get_Now")]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(File), Member = "ReadAllBytes")]
		[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCloudSaveFilename")]
		public static void EnumerateLocalSaveFiles(List<SteamCloudManager.EnumerateFilesResult.FileInfo> list)
		{
		}

		[Calls(Type = typeof(File), Member = "ReadAllBytes")]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		public static bool ReadSaveFile(string filename, out byte[] bytes)
		{
			bytes = null;
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(File), Member = "Exists")]
		[Calls(Type = typeof(File), Member = "Delete")]
		public static bool DeleteSaveFile(string filename)
		{
			return default(bool);
		}

		[Calls(Type = typeof(Path), Member = "InsecureGetFullPath")]
		[Calls(Type = typeof(System.IO.FileSystem), Member = "SetCreationTime")]
		[Calls(Type = typeof(File), Member = "GetUtcDateTimeOffset")]
		[Calls(Type = typeof(File), Member = "GetUtcDateTimeOffset")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[Calls(Type = typeof(System.IO.FileSystem), Member = "SetLastWriteTime")]
		[Calls(Type = typeof(Path), Member = "InsecureGetFullPath")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
		[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
		[Calls(Type = typeof(Directory), Member = "Exists")]
		[Calls(Type = typeof(Path), Member = "GetDirectoryName")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
		[CallsUnknownMethods(Count = 17)]
		public static bool WriteDownloadedSaveFile(byte[] result, string filename, DateTime dateTime)
		{
			return default(bool);
		}

		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		private static string GetDownloadDirectory()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SteamCloudManagerPC()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public DownloadDataResult result;

		public Action<DownloadDataResult> onCompleted;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Array), Member = "CopyTo")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CDownloadData_003Eb__0(UnityWebRequest response)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void _003CDownloadData_003Eb__1(UnityWebRequest response)
		{
		}
	}

	private static readonly DateTime EPOCH_TIME;

	private static bool s_DebugVerbose;

	[CallerCount(Count = 0)]
	public static string ShowWebPage(string requestedUrl, string callbackUrl, string callbackableUrl)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static string GetParamFromURI(string uri, char fragmentstart, string param)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "Add")]
	public static DateTime FromUnixTime(ulong unixTime)
	{
		return default(DateTime);
	}

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
	[CalledBy(Type = typeof(SteamCloudManager.UploadOperation), Member = ".ctor")]
	[CalledBy(Type = typeof(SteamCloudManager.DownloadOperation), Member = "DownloadDone")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(SHA1CryptoServiceProvider), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(HashAlgorithm), Member = "CaptureHashCodeAndReinitialize")]
	[Calls(Type = typeof(BitConverter), Member = "ToString")]
	public static string ComputeSha1Hex(byte[] data)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static void DebugLogVerbose(string txt)
	{
	}

	[CallerCount(Count = 0)]
	public static void ToggleVerbose()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static string ShowWebPageInternal(string requestedUrl, string callbackUrl, string callbackableUrl)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "WebRequest")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(SteamCloudManager.DownloadOperation), Member = "Execute")]
	public static void DownloadData(string url, Action<DownloadDataResult> onCompleted)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public WebUtils()
	{
	}
}
