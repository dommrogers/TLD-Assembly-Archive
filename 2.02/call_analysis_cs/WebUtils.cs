using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using Cpp2ILInjected.CallAnalysis;
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
					[DebuggerHidden]
					[DeduplicatedMethod]
					[CallerCount(Count = 35)]
					get
					{
						return null;
					}
				}

				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[DebuggerHidden]
					[DeduplicatedMethod]
					[CallerCount(Count = 35)]
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

				[DebuggerHidden]
				[CalledBy(Type = typeof(_003CBatch_003Ed__10), Member = "MoveNext")]
				[CallerCount(Count = 1)]
				[Calls(Type = typeof(_003CBatch_003Ed__10), Member = "<>m__Finally1")]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[CallerCount(Count = 0)]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.BatchOperation", Member = "IsBatchCompleted")]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.BatchOperation", Member = "IsBatchSuccess")]
				[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
				[Calls(Type = typeof(_003CBatch_003Ed__10), Member = "<>m__Finally1")]
				[Calls(Type = typeof(_003CBatch_003Ed__10), Member = "System.IDisposable.Dispose")]
				[CallsDeduplicatedMethods(Count = 4)]
				[CallsUnknownMethods(Count = 27)]
				private bool MoveNext()
				{
					return false;
				}

				[CalledBy(Type = typeof(_003CBatch_003Ed__10), Member = "System.IDisposable.Dispose")]
				[CalledBy(Type = typeof(_003CBatch_003Ed__10), Member = "MoveNext")]
				[CallerCount(Count = 2)]
				[CallsDeduplicatedMethods(Count = 1)]
				private void _003C_003Em__Finally1()
				{
				}

				[DebuggerHidden]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
				[CallsUnknownMethods(Count = 3)]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			private Action<ICloudOperation> m_OnOperationComplete;

			private List<CommonCloudOperation> m_OperationList;

			private bool m_IsExecuting;

			private BatchType m_Type;

			[CalledBy(Type = typeof(SteamCloudManager), Member = "Sync")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteLocalSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "EnumerateForDeleteAllDone")]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(List<>), Member = ".ctor")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 7)]
			public BatchOperation(Action<ICloudOperation> onOperationComplete, BatchType type)
			{
			}

			[CalledBy(Type = typeof(SteamCloudManager), Member = "Sync")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteLocalSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "EnumerateForDeleteAllDone")]
			[CallerCount(Count = 15)]
			[Calls(Type = typeof(List<>), Member = "Add")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public void AddOperation(CommonCloudOperation operation)
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(List<>), Member = "Remove")]
			[Calls(Type = typeof(BatchOperation), Member = "Batch")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 6)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(List<>), Member = "Remove")]
			[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			private void RemoveSuccessfullOperations()
			{
			}

			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.BatchOperation.<Batch>d__10", Member = "MoveNext")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 3)]
			private bool IsBatchCompleted()
			{
				return false;
			}

			[CalledBy(Type = typeof(BatchOperation), Member = "BatchDone")]
			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.BatchOperation.<Batch>d__10", Member = "MoveNext")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 3)]
			private bool IsBatchSuccess()
			{
				return false;
			}

			[CalledBy(Type = typeof(BatchOperation), Member = "Execute")]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 7)]
			private IEnumerator Batch()
			{
				return null;
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(BatchOperation), Member = "IsBatchSuccess")]
			[CallsDeduplicatedMethods(Count = 2)]
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
			[CallerCount(Count = 24)]
			public LocalFileDeleteOperation(string filename)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
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

				[DeduplicatedMethod]
				[CallerCount(Count = 7)]
				public _003C_003Ec__DisplayClass7_0()
				{
				}

				[CallerCount(Count = 0)]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.DeleteOperation", Member = "RequestDeleteDataCompleted")]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 3)]
				internal void _003CWebRequestDeleteData_003Eb__0(UnityWebRequest response)
				{
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.DeleteOperation", Member = "RequestDeleteDataCompleted")]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 1)]
				internal void _003CWebRequestDeleteData_003Eb__1(UnityWebRequest response)
				{
				}
			}

			private string m_Token;

			private string m_FileName;

			private Action<bool> m_OnOperationComplete;

			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "EnumerateForDeleteAllDone")]
			[CallerCount(Count = 3)]
			public DeleteOperation(string token, string filename, Action<bool> onOperationComplete)
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DeleteOperation), Member = "WebRequestDeleteData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DeleteOperation), Member = "WebRequestDeleteData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			public void RequestDeleteData(string token, string filename)
			{
			}

			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.DeleteOperation.<>c__DisplayClass7_0", Member = "<WebRequestDeleteData>b__0")]
			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.DeleteOperation.<>c__DisplayClass7_0", Member = "<WebRequestDeleteData>b__1")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[CallsDeduplicatedMethods(Count = 2)]
			private void RequestDeleteDataCompleted(DeleteRequestResult result)
			{
			}

			[CalledBy(Type = typeof(DeleteOperation), Member = "Execute")]
			[CalledBy(Type = typeof(DeleteOperation), Member = "RequestDeleteData")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WWWForm), Member = ".ctor")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(Utils), Member = "WebRequest")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 30)]
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

			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 14)]
			public DownloadSaveOperation(string filename, DateTime dateTime, string url, string sha1, Action<bool> onOperationComplete)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DownloadSaveOperation), Member = "OperationFailed")]
			[CallsDeduplicatedMethods(Count = 1)]
			private void DownloadDone(DownloadDataResult result)
			{
			}

			[CalledBy(Type = typeof(DownloadSaveOperation), Member = "DownloadDone")]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 2)]
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

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(WebUtils), Member = "DownloadData")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 7)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "ComputeSha1Hex")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[CallsDeduplicatedMethods(Count = 2)]
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

				[CalledBy(Type = typeof(EnumerateFilesResult), Member = ".cctor")]
				[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.EnumerateFilesOperation.<>c__DisplayClass5_0", Member = "<WebRequestEnumerateFiles>b__0")]
				[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
				[CallerCount(Count = 3)]
				public FileInfo(string fileName, DateTime dateTime, string sha, uint size, string url)
				{
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(string), Member = "EqualsHelper")]
				public bool IsContentIdentical(FileInfo other)
				{
					return false;
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(FileInfo), Member = "op_Equality")]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 1)]
				public override bool Equals(object other)
				{
					return false;
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(ValueType), Member = "GetHashCode")]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 1)]
				public override int GetHashCode()
				{
					return 0;
				}

				[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
				[CalledBy(Type = typeof(SteamCloudManager), Member = "AreFilesIdentical")]
				[CalledBy(Type = typeof(SteamCloudManager), Member = "GetCloudFileSyncStatus")]
				[CalledBy(Type = typeof(SteamCloudManager), Member = "GetLocalFileSyncStatus")]
				[CalledBy(Type = typeof(FileInfo), Member = "Equals")]
				[CallerCount(Count = 6)]
				[Calls(Type = typeof(string), Member = "EqualsHelper")]
				[CallsDeduplicatedMethods(Count = 1)]
				public static bool operator ==(FileInfo a, FileInfo b)
				{
					return false;
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(string), Member = "EqualsHelper")]
				[Calls(Type = typeof(string), Member = "op_Inequality")]
				[CallsDeduplicatedMethods(Count = 1)]
				public static bool operator !=(FileInfo a, FileInfo b)
				{
					return false;
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
				[CallerCount(Count = 7)]
				public _003C_003Ec__DisplayClass5_0()
				{
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
				[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
				[Calls(Type = typeof(WebUtils), Member = "FromUnixTime")]
				[Calls(Type = typeof(string), Member = "Concat")]
				[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
				[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = ".ctor")]
				[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
				[Calls(Type = typeof(string), Member = "FormatHelper")]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.EnumerateFilesOperation", Member = "RequestEnumerateFilesDone")]
				[CallsDeduplicatedMethods(Count = 3)]
				[CallsUnknownMethods(Count = 20)]
				internal void _003CWebRequestEnumerateFiles_003Eb__0(UnityWebRequest response)
				{
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.EnumerateFilesOperation", Member = "RequestEnumerateFilesDone")]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 1)]
				internal void _003CWebRequestEnumerateFiles_003Eb__1(UnityWebRequest response)
				{
				}
			}

			private string m_Token;

			private Action<EnumerateFilesResult> m_OnOperationComplete;

			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateFileEnumerationOperationForSync")]
			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.AuthenticateOperation", Member = "Update")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(Delegate), Member = "Combine")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			public EnumerateFilesOperation(string token, Action<EnumerateFilesResult> onOperationComplete1, Action<EnumerateFilesResult> onOperationComplete2)
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(EnumerateFilesOperation), Member = "WebRequestEnumerateFiles")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(EnumerateFilesOperation), Member = "WebRequestEnumerateFiles")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			private void RequestEnumerateFiles(string token, bool extendedDetails)
			{
			}

			[CalledBy(Type = typeof(EnumerateFilesOperation), Member = "Execute")]
			[CalledBy(Type = typeof(EnumerateFilesOperation), Member = "RequestEnumerateFiles")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "Format")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(Utils), Member = "WebRequest")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 39)]
			private IEnumerator WebRequestEnumerateFiles(string token, bool extendedDetails)
			{
				return null;
			}

			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.EnumerateFilesOperation.<>c__DisplayClass5_0", Member = "<WebRequestEnumerateFiles>b__0")]
			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.EnumerateFilesOperation.<>c__DisplayClass5_0", Member = "<WebRequestEnumerateFiles>b__1")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(Action<>), Member = "Invoke")]
			[CallsDeduplicatedMethods(Count = 1)]
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
						[CallerCount(Count = 7)]
						public FileInfo()
						{
						}
					}

					public List<FileInfo> files;

					public uint total_files;

					[DeduplicatedMethod]
					[CallerCount(Count = 7)]
					public ResponseData()
					{
					}
				}

				public ResponseData response;

				[DeduplicatedMethod]
				[CallerCount(Count = 7)]
				public EnumerateUserFiles_v1()
				{
				}
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
			[CallsDeduplicatedMethods(Count = 1)]
			public static EnumerateUserFiles_v1 ParseJson(string txt)
			{
				return null;
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
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
				[CallerCount(Count = 7)]
				public _003C_003Ec__DisplayClass14_0()
				{
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation", Member = "RequestUploadData_BeginDone")]
				[CallsDeduplicatedMethods(Count = 4)]
				[CallsUnknownMethods(Count = 4)]
				internal void _003CWebRequestBeginUploadData_003Eb__0(UnityWebRequest response)
				{
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation", Member = "RequestUploadData_BeginDone")]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 1)]
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
				[CallerCount(Count = 7)]
				public _003C_003Ec__DisplayClass15_0()
				{
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation", Member = "RequestUploadData_CommitDone")]
				[CallsDeduplicatedMethods(Count = 3)]
				[CallsUnknownMethods(Count = 5)]
				internal void _003CWebRequestCommitUpload_003Eb__0(UnityWebRequest response)
				{
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation", Member = "RequestUploadData_CommitDone")]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 1)]
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
				[CallerCount(Count = 7)]
				public _003C_003Ec__DisplayClass16_0()
				{
				}

				[CallerCount(Count = 0)]
				[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
				[Calls(Type = typeof(string), Member = "FormatHelper")]
				[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation", Member = "RequestUploadData_PutDone")]
				[CallsDeduplicatedMethods(Count = 8)]
				[CallsUnknownMethods(Count = 10)]
				internal void _003CWebRequestUploadData_003Eb__0(UnityWebRequest response)
				{
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation", Member = "RequestUploadData_PutDone")]
				[CallsDeduplicatedMethods(Count = 2)]
				[CallsUnknownMethods(Count = 4)]
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
			[CallsDeduplicatedMethods(Count = 1)]
			public UploadOperation(string token, string filename, byte[] data, Action<bool> onOperationComplete)
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestBeginUploadData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 3)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestBeginUploadData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			public void RequestBeginUploadData(string token, int filesize, string filename, string filesha)
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestUploadData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			public void RequestUploadData(string url_host, string url_path, string filename, Dictionary<string, string> httpHeaders, byte[] data)
			{
			}

			[CalledBy(Type = typeof(UploadOperation), Member = "RequestUploadData_BeginDone")]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestUploadData_PutDone")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestCommitUpload")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			public void RequestCommitUpload(string token, bool transfer_succeeded, string filename, string filesha)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			private void OperationFailed()
			{
			}

			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation.<>c__DisplayClass14_0", Member = "<WebRequestBeginUploadData>b__0")]
			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation.<>c__DisplayClass14_0", Member = "<WebRequestBeginUploadData>b__1")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestUploadData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(UploadOperation), Member = "RequestCommitUpload")]
			[CallsDeduplicatedMethods(Count = 6)]
			[CallsUnknownMethods(Count = 22)]
			private void RequestUploadData_BeginDone(BeginUploadRequestResult result)
			{
			}

			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation.<>c__DisplayClass16_0", Member = "<WebRequestUploadData>b__0")]
			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation.<>c__DisplayClass16_0", Member = "<WebRequestUploadData>b__1")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(UploadOperation), Member = "RequestCommitUpload")]
			[CallsDeduplicatedMethods(Count = 1)]
			private void RequestUploadData_PutDone(UploadPutRequestResult result)
			{
			}

			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation.<>c__DisplayClass15_0", Member = "<WebRequestCommitUpload>b__0")]
			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation.<>c__DisplayClass15_0", Member = "<WebRequestCommitUpload>b__1")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(Debug), Member = "LogError")]
			[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
			[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
			[Calls(Type = typeof(string), Member = "FormatHelper")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[CallsDeduplicatedMethods(Count = 2)]
			private void RequestUploadData_CommitDone(UploadCommitRequestResult result)
			{
			}

			[CalledBy(Type = typeof(UploadOperation), Member = "Execute")]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestBeginUploadData")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
			[Calls(Type = typeof(string), Member = "FormatHelper")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(WWWForm), Member = ".ctor")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
			[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
			[Calls(Type = typeof(Utils), Member = "WebRequest")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 30)]
			private IEnumerator WebRequestBeginUploadData(string token, int filesize, string filename, string filesha)
			{
				return null;
			}

			[CalledBy(Type = typeof(UploadOperation), Member = "RequestCommitUpload")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
			[Calls(Type = typeof(string), Member = "FormatHelper")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(WWWForm), Member = ".ctor")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(bool), Member = "ToString")]
			[Calls(Type = typeof(Utils), Member = "WebRequest")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 30)]
			private IEnumerator WebRequestCommitUpload(string token, bool transfer_succeeded, string filename, string filesha)
			{
				return null;
			}

			[CalledBy(Type = typeof(UploadOperation), Member = "RequestUploadData")]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestUploadData_BeginDone")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "StartsWith")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(Utils), Member = "WebRequestPut")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 23)]
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
						[CallerCount(Count = 7)]
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
					[CallerCount(Count = 7)]
					public ResponseData()
					{
					}
				}

				public ResponseData response;

				[DeduplicatedMethod]
				[CallerCount(Count = 7)]
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
					[CallerCount(Count = 7)]
					public ResponseData()
					{
					}
				}

				public ResponseData response;

				[DeduplicatedMethod]
				[CallerCount(Count = 7)]
				public CommitHTTPUpload_v1()
				{
				}
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
			[CallsDeduplicatedMethods(Count = 1)]
			public static BeginHTTPUpload_v1 ParseJson(string txt)
			{
				return null;
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			public static bool IsCommitHTTPUploadSuccess(string response)
			{
				return false;
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
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

			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			[CallerCount(Count = 2)]
			public UploadSaveOperation(string token, string fileName, Action<bool> onOperationComplete)
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UploadSaveOperation), Member = "OperationFailed")]
			[CallsDeduplicatedMethods(Count = 2)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			private void DownloadDone(bool result)
			{
			}

			[CalledBy(Type = typeof(UploadSaveOperation), Member = "Execute")]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 2)]
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
					[DebuggerHidden]
					[DeduplicatedMethod]
					[CallerCount(Count = 35)]
					get
					{
						return null;
					}
				}

				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[DebuggerHidden]
					[DeduplicatedMethod]
					[CallerCount(Count = 35)]
					get
					{
						return null;
					}
				}

				[DebuggerHidden]
				[DeduplicatedMethod]
				[CallerCount(Count = 0)]
				public _003CWaitSaveOperationComplete_003Ed__3(int _003C_003E1__state)
				{
				}

				[DebuggerHidden]
				[DeduplicatedMethod]
				[CallerCount(Count = 7)]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
				[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
				[CallsDeduplicatedMethods(Count = 3)]
				[CallsUnknownMethods(Count = 10)]
				private bool MoveNext()
				{
					return false;
				}

				[DebuggerHidden]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
				[CallsUnknownMethods(Count = 3)]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			private Action m_OnOperationComplete;

			[DeduplicatedMethod]
			[CallerCount(Count = 24)]
			public WaitSaveOperation(Action onCompleted)
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(WaitSaveOperation), Member = "WaitSaveOperationComplete")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			public override void Execute()
			{
			}

			[CalledBy(Type = typeof(WaitSaveOperation), Member = "Execute")]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 7)]
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
					[CallerCount(Count = 35)]
					get
					{
						return null;
					}
				}

				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[DebuggerHidden]
					[DeduplicatedMethod]
					[CallerCount(Count = 35)]
					get
					{
						return null;
					}
				}

				[DebuggerHidden]
				[DeduplicatedMethod]
				[CallerCount(Count = 0)]
				public _003CAuthenticate_003Ed__6(int _003C_003E1__state)
				{
				}

				[DebuggerHidden]
				[DeduplicatedMethod]
				[CallerCount(Count = 7)]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[CallerCount(Count = 0)]
				[Calls(TypeFullName = "WebUtils.SteamCloudManager.AuthenticateOperation", Member = "Update")]
				[CallsUnknownMethods(Count = 1)]
				private bool MoveNext()
				{
					return false;
				}

				[DebuggerHidden]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
				[CallsUnknownMethods(Count = 3)]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			private string m_Token;

			private Action<bool> m_OnOperationComplete;

			private OperationStatus m_Status;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public AuthenticateOperation(string token, Action<bool> onOperationComplete)
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AuthenticateOperation), Member = "Authenticate")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			public override void Execute()
			{
			}

			[CalledBy(Type = typeof(AuthenticateOperation), Member = "Execute")]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 7)]
			private IEnumerator Authenticate()
			{
				return null;
			}

			[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.AuthenticateOperation.<Authenticate>d__6", Member = "MoveNext")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(AuthenticateOperation), Member = "AuthenticationComplete")]
			[Calls(TypeFullName = "WebUtils.SteamCloudManager.EnumerateFilesOperation", Member = ".ctor")]
			[Calls(Type = typeof(AuthenticateOperation), Member = "RetrieveToken")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 16)]
			private void Update()
			{
			}

			[CalledBy(Type = typeof(AuthenticateOperation), Member = "Update")]
			[CalledBy(Type = typeof(AuthenticateOperation), Member = "EnumerateForAuthenticationDone")]
			[CalledBy(Type = typeof(AuthenticateOperation), Member = "Success")]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[CallsDeduplicatedMethods(Count = 2)]
			private void AuthenticationComplete()
			{
			}

			[CallAnalysisFailed]
			[CalledBy(Type = typeof(AuthenticateOperation), Member = "Update")]
			[CallerCount(Count = 1)]
			private void RetrieveToken()
			{
			}

			[CalledBy(Type = typeof(AuthenticateOperation), Member = "EnumerateForAuthenticationDone")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 15)]
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

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
			[Calls(Type = typeof(SteamCloudManager), Member = "SetToken")]
			[Calls(Type = typeof(Panel_OptionsMenu), Member = "SaveSettings")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 3)]
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
			bool IsCompleted();

			bool IsSuccess();

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
			[CallerCount(Count = 6)]
			public bool IsCompleted()
			{
				return false;
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public bool IsSuccess()
			{
				return false;
			}

			[CallerCount(Count = 0)]
			public bool IsRetryPending()
			{
				return false;
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

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			private void Reset()
			{
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 77)]
			public void SetOnExecuteStarted(Action onExecuteStarted)
			{
			}

			[CallerCount(Count = 0)]
			[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
			[Calls(Type = typeof(string), Member = "FormatHelper")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[CallsDeduplicatedMethods(Count = 2)]
			public bool Retry()
			{
				return false;
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void EnumerateLocalFiles()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private static bool WriteDownloadedSaveFile(DownloadDataResult result, string filename, DateTime dateTime)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		private static bool ReadSaveFile(string filename, out byte[] bytes)
		{
			bytes = null;
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private static bool DeleteSaveFile(string filename)
		{
			return false;
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "FileEnumerationForSyncComplete")]
		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(SaveGameSlots), Member = "IsValidSavedGameName")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public static bool CloudFileRequiresSync(string fileName)
		{
			return false;
		}

		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTime), Member = "get_Now")]
		[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
		[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
		[CallsDeduplicatedMethods(Count = 2)]
		public static DateTime GetDateTimeFromSave(byte[] data)
		{
			return default(DateTime);
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncDone")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
		[Calls(Type = typeof(SaveGameSlots), Member = "ReInit")]
		[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 14)]
		public void ReloadSaves()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool IsSyncSavesEnabled()
		{
			return false;
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "AuthenticateForSyncDone")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "CreateFileEnumerationOperationForSync")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 14)]
		public void RetrieveFilesForSync()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCloudSaveFilename")]
		[CallsDeduplicatedMethods(Count = 1)]
		public void HandleSaveDeleted(string saveFilename)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[CallsDeduplicatedMethods(Count = 1)]
		private void DeleteSaveStarted()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallsDeduplicatedMethods(Count = 2)]
		private void DeleteSaveDone(bool res)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool HasSyncStarted()
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 36)]
		public void Sync()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCloudSaveFilename")]
		[CallsDeduplicatedMethods(Count = 1)]
		public void HandleDataSaved(string filename)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[Calls(Type = typeof(SteamCloudManager), Member = "RetrieveFilesForSync")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private void AuthenticateForSyncDone(ICloudOperation operation)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 15)]
		private void ReplaceCloudSave(string cloudFileName)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[CallsDeduplicatedMethods(Count = 1)]
		private void ReplaceCloudSaveStarted()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallsDeduplicatedMethods(Count = 2)]
		private void ReplaceCloudSaveDone(ICloudOperation operation)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[CallsDeduplicatedMethods(Count = 1)]
		private void SyncStarted()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[CallsDeduplicatedMethods(Count = 1)]
		private void RetrieveFilesForSyncSyncStarted()
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudFilesRetrievedForSync")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AreFilesIdentical")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[Calls(Type = typeof(SteamCloudManager), Member = "RequestUserConfirmation")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		private void SyncInternal()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
		[Calls(Type = typeof(SteamCloudManager), Member = "SyncInternal")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
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

		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudSyncLocalNewerDeclined")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudSyncLocalNewerAccepted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudSyncNewerDeclined")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteLocalSave")]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 46)]
		private void DoSyncOperation()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[CallsDeduplicatedMethods(Count = 1)]
		private void SyncingFilesOperationStarted()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ReloadSaves")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		private void SyncDone(ICloudOperation cloudOperation)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void NotifySyncDone()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[Calls(Type = typeof(SteamCloudManager), Member = "RefreshSaveUI")]
		[CallsDeduplicatedMethods(Count = 3)]
		private void ReloadSavesReady()
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "RequestUserConfirmation")]
		[CallerCount(Count = 1)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 18)]
		private bool AreCloudFilesNewer()
		{
			return false;
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncInternal")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "AreCloudFilesNewer")]
		[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 30)]
		private void RequestUserConfirmation()
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncInternal")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ClearCloudFilesBySyncStatus")]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddToListIfNotFound")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 20)]
		private void GatherFilesStatus()
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary<, >.ValueCollection.Enumerator), Member = "MoveNext")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private void ClearCloudFilesBySyncStatus()
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SteamCloudManager), Member = "FileExists")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private void AddToListIfNotFound(EnumerateFilesResult.FileInfo info, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(DownloadSaveOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 25)]
		private void AddBatchDownloadSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(UploadSaveOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 25)]
		private void AddBatchUploadSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(DeleteOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 25)]
		private void AddBatchDeleteSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 25)]
		private void AddBatchDeleteLocalSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 18)]
		private void AddBatchUploadReplaceSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReplaceCloudSave")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(DeleteOperation), Member = ".ctor")]
		[Calls(Type = typeof(UploadSaveOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 22)]
		private BatchOperation CreateUploadReplaceSaveFileOperation(string cloudFileName, Action<ICloudOperation> onOperationComplete)
		{
			return null;
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncInternal")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		private bool AreFilesIdentical(List<EnumerateFilesResult.FileInfo> filesToCompare)
		{
			return false;
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AreFilesIdentical")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "FileExists")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetCloudFileSyncStatus")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetLocalFileSyncStatus")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		private EnumerateFilesResult.FileInfo FindFile(string filename, List<EnumerateFilesResult.FileInfo> filesToSearch)
		{
			return default(EnumerateFilesResult.FileInfo);
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "AddToListIfNotFound")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(string), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 2)]
		private bool FileExists(EnumerateFilesResult.FileInfo fileInfo, List<EnumerateFilesResult.FileInfo> comparedToList)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		private CloudSyncStatus GetCloudFileSyncStatus(EnumerateFilesResult.FileInfo cloudInfo)
		{
			return default(CloudSyncStatus);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		private CloudSyncStatus GetLocalFileSyncStatus(EnumerateFilesResult.FileInfo localInfo)
		{
			return default(CloudSyncStatus);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "get_Now")]
		[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
		[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
		[CallsDeduplicatedMethods(Count = 1)]
		private static bool TryExtractTimeStampFromSave(byte[] data, out DateTime timestamp)
		{
			timestamp = default(DateTime);
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
		[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
		[CallsDeduplicatedMethods(Count = 1)]
		private static bool IsSaveOperationInProgress()
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		public static AuthenticationResult RequestAuthenticationToken()
		{
			return default(AuthenticationResult);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public static string GetAuthenticationRequestUrl()
		{
			return null;
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 51)]
		private SteamCloudManager()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		public string GetToken()
		{
			return null;
		}

		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
		[CalledBy(Type = typeof(ConsoleManager), Member = "SaveToken")]
		[CalledBy(Type = typeof(AuthenticateOperation), Member = "SaveToken")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[CallsDeduplicatedMethods(Count = 1)]
		public void SetToken(string token)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "UpdateQueue")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void Update()
		{
		}

		[CalledBy(Type = typeof(GameManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "Update")]
		[CallerCount(Count = 2)]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private void UpdateQueue()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		public void Authenticate()
		{
		}

		[CallerCount(Count = 37)]
		[Calls(Type = typeof(SteamCloudManager), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public static SteamCloudManager GetInstance()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private bool HasSyncMessage()
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void UpdateSyncMessage()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void QueueOperation(CommonCloudOperation cloudOperation)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "RetrieveFilesForSync")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetAllFiles")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DeleteAllCloudFiles")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(EnumerateFilesOperation), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 15)]
		private CommonCloudOperation CreateFileEnumerationOperationForSync(Action<EnumerateFilesResult> onActionComplete, Action onOperationStarted)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "CreateFileEnumerationOperationForSync")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		public void GetAllFiles(Action<EnumerateFilesResult> onActionComplete, Action onOperationStarted, int numRetries)
		{
		}

		[CalledBy(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public bool IsOperationPending()
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool IsSyncPending()
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "CreateFileEnumerationOperationForSync")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public void DeleteAllCloudFiles()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public void EnableSyncSaves(bool enabled)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool AreSaveFilesSynchronized()
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void RegisterSyncEnabledChanged(Action<bool> onSyncEnabledChanged)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void UnRegisterSyncEnabledChanged(Action<bool> onSyncEnabledChanged)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void RegisterSyncDone(Action onSyncDone)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void UnRegisterSyncDone(Action onSyncDone)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "ToString")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		public static void DebugLogFiles(EnumerateFilesResult result)
		{
		}

		[CalledBy(Type = typeof(GameManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DeleteSaveStarted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReplaceCloudSaveStarted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncStarted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "RetrieveFilesForSyncSyncStarted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncingFilesOperationStarted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "UpdateSyncMessage")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCurrentMessageLabel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GameObject), Member = "SetActive")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(UILabel), Member = "set_text")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 8)]
		public static void ShowSyncMessage(string locId)
		{
		}

		[CalledBy(Type = typeof(GameManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DeleteSaveDone")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AuthenticateForSyncDone")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReplaceCloudSaveDone")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudFilesRetrievedForSync")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncDone")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReloadSavesReady")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "UpdateSyncMessage")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCurrentMessageLabel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GameObject), Member = "SetActive")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		public static void HideSyncMessage()
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "HandleSaveDeleted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "HandleDataSaved")]
		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		public static string GetCloudSaveFilename(string filename)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		private bool IsCurrentOperationPending()
		{
			return false;
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReloadSaves")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "RetrieveFilesForSync")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "Sync")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReplaceCloudSave")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetAllFiles")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DeleteAllCloudFiles")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(SteamCloudManager), Member = "IsOperationPending")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		private void ProcessOperation(CommonCloudOperation cloudOperation, int numRetries)
		{
		}

		[CallerCount(Count = 0)]
		private bool HasToken()
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "get_Now")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(SteamCloudManager), Member = "CloudFileRequiresSync")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		private void FileEnumerationForSyncComplete(EnumerateFilesResult result)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(DeleteOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 26)]
		private void EnumerateForDeleteAllDone(EnumerateFilesResult result)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
		[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		private static UILabel GetCurrentMessageLabel()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "RefreshSaveUI")]
		[CallsDeduplicatedMethods(Count = 1)]
		private static void RefreshCurrentSaveUI()
		{
		}

		[DeduplicatedMethod]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReloadSavesReady")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "RefreshCurrentSaveUI")]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
		[CallsDeduplicatedMethods(Count = 4)]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(SteamCloudManagerPC), Member = "GetDownloadDirectory")]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
		[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCloudSaveFilename")]
		[Calls(Type = typeof(File), Member = "ReadAllBytes")]
		[Calls(Type = typeof(WebUtils), Member = "ComputeSha1Hex")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetDateTimeFromSave")]
		[Calls(Type = typeof(SteamCloudManager.EnumerateFilesResult.FileInfo), Member = ".ctor")]
		[Calls(Type = typeof(SteamCloudManager), Member = "CloudFileRequiresSync")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 14)]
		public static void EnumerateLocalSaveFiles(List<SteamCloudManager.EnumerateFilesResult.FileInfo> list)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManagerPC), Member = "GetDownloadDirectory")]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(File), Member = "ReadAllBytes")]
		[CallsDeduplicatedMethods(Count = 1)]
		public static bool ReadSaveFile(string filename, out byte[] bytes)
		{
			bytes = null;
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManagerPC), Member = "GetDownloadDirectory")]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(File), Member = "Exists")]
		[Calls(Type = typeof(File), Member = "Delete")]
		[CallsDeduplicatedMethods(Count = 1)]
		public static bool DeleteSaveFile(string filename)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManagerPC), Member = "GetDownloadDirectory")]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Path), Member = "GetDirectoryName")]
		[Calls(Type = typeof(Directory), Member = "Exists")]
		[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
		[Calls(Type = typeof(File), Member = "WriteAllBytes")]
		[Calls(Type = typeof(DateTime), Member = "ToLocalTime")]
		[Calls(Type = typeof(File), Member = "SetCreationTime")]
		[Calls(Type = typeof(File), Member = "SetLastWriteTime")]
		[CallsDeduplicatedMethods(Count = 1)]
		public static bool WriteDownloadedSaveFile(byte[] result, string filename, DateTime dateTime)
		{
			return false;
		}

		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "ReadSaveFile")]
		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "DeleteSaveFile")]
		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "WriteDownloadedSaveFile")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		private static string GetDownloadDirectory()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public SteamCloudManagerPC()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public DownloadDataResult result;

		public Action<DownloadDataResult> onCompleted;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "CopyTo")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		internal void _003CDownloadData_003Eb__0(UnityWebRequest response)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CDownloadData_003Eb__1(UnityWebRequest response)
		{
		}
	}

	private static readonly DateTime EPOCH_TIME;

	private static bool s_DebugVerbose;

	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.DownloadOperation", Member = "Execute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
	[Calls(Type = typeof(Utils), Member = "WebRequest")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	public static void DownloadData(string url, Action<DownloadDataResult> onCompleted)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string ShowWebPage(string requestedUrl, string callbackUrl, string callbackableUrl)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public static string GetParamFromURI(string uri, char fragmentstart, string param)
	{
		return null;
	}

	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.EnumerateFilesOperation.<>c__DisplayClass5_0", Member = "<WebRequestEnumerateFiles>b__0")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DateTime FromUnixTime(ulong unixTime)
	{
		return default(DateTime);
	}

	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.DownloadOperation", Member = "DownloadDone")]
	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation", Member = ".ctor")]
	[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SHA1CryptoServiceProvider), Member = ".ctor")]
	[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash")]
	[Calls(Type = typeof(BitConverter), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static string ComputeSha1Hex(byte[] data)
	{
		return null;
	}

	[CallerCount(Count = 30)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DebugLogVerbose(string txt)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ToggleVerbose()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static string ShowWebPageInternal(string requestedUrl, string callbackUrl, string callbackableUrl)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public WebUtils()
	{
	}
}
