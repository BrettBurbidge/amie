



















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `sqlserver`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=.;Initial Catalog=traffic;User=CairsUser;password=passw0rd1`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace Amie.Models
{

	public partial class sqlserverDB : Database
	{
		public sqlserverDB() 
			: base("sqlserver")
		{
			CommonConstruct();
		}

		public sqlserverDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			sqlserverDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static sqlserverDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new sqlserverDB();
        }

		[ThreadStatic] static sqlserverDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static sqlserverDB repo { get { return sqlserverDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    
	[TableName("Avaya_CallSummary")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class Avaya_CallSummary : sqlserverDB.Record<Avaya_CallSummary>  
    {



		[Column] public int ID { get; set; }





		[Column] public int VoiceSystemID { get; set; }





		[Column] public DateTime DateRun { get; set; }





		[Column] public int? Hour { get; set; }





		[Column] public int? Voice { get; set; }





		[Column] public int? Data { get; set; }





		[Column] public int? Media { get; set; }





		[Column] public int? Link { get; set; }





		[Column] public int? Total { get; set; }



	}

    
	[TableName("Avaya_TrunkGroupSummary")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class Avaya_TrunkGroupSummary : sqlserverDB.Record<Avaya_TrunkGroupSummary>  
    {



		[Column] public int ID { get; set; }





		[Column] public int VoiceSystemID { get; set; }





		[Column] public DateTime DateRun { get; set; }





		[Column] public int? GrpNum { get; set; }





		[Column] public int? GrpSiz { get; set; }





		[Column] public string GrpType { get; set; }





		[Column] public string GrpDir { get; set; }





		[Column] public int? MeasHour { get; set; }





		[Column] public int? TotalUsage { get; set; }





		[Column] public int? TotalSeize { get; set; }





		[Column] public int? IncSeize { get; set; }





		[Column] public int? GrpOvfl { get; set; }





		[Column] public int? QueSiz { get; set; }





		[Column] public int? CallQued { get; set; }





		[Column] public int? QueOvf { get; set; }





		[Column] public int? QueAbd { get; set; }





		[Column] public int? OutSrv { get; set; }





		[Column] public int? PercentATB { get; set; }





		[Column] public int? PercentOutBlk { get; set; }



	}

    
	[TableName("EscalationAction")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class EscalationAction : sqlserverDB.Record<EscalationAction>  
    {



		[Column] public int ID { get; set; }





		[Column] public int EscalationProfileID { get; set; }





		[Column] public int Order { get; set; }





		[Column] public string Name { get; set; }





		[Column] public string PhoneEmail { get; set; }





		[Column] public int ResponseTime { get; set; }





		[Column] public bool Recurring { get; set; }





		[Column] public string Type { get; set; }



	}

    
	[TableName("EscalationProfile")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class EscalationProfile : sqlserverDB.Record<EscalationProfile>  
    {



		[Column] public int ID { get; set; }





		[Column] public string Name { get; set; }



	}

    
	[TableName("User")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class User : sqlserverDB.Record<User>  
    {



		[Column] public int ID { get; set; }





		[Column] public string Login { get; set; }





		[Column] public string Email { get; set; }





		[Column] public string Name { get; set; }





		[Column] public string PasswordHash { get; set; }





		[Column] public string PasswordSalt { get; set; }





		[Column] public string Profile { get; set; }





		[Column] public string SMSNumber { get; set; }





		[Column] public byte[] CertificateBytes { get; set; }





		[Column] public bool Enabled { get; set; }





		[Column] public DateTime DateAdded { get; set; }





		[Column] public DateTime? LastLogin { get; set; }





		[Column] public string CertificateSerialNumber { get; set; }



	}

    
	[TableName("ReportCommand")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class ReportCommand : sqlserverDB.Record<ReportCommand>  
    {



		[Column] public int ID { get; set; }





		[Column] public string Command1 { get; set; }





		[Column] public string Command2 { get; set; }





		[Column] public string Command3 { get; set; }





		[Column] public string Command4 { get; set; }



	}

    
	[TableName("ReportParseLog")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class ReportParseLog : sqlserverDB.Record<ReportParseLog>  
    {



		[Column] public int ID { get; set; }





		[Column] public int ReportRunLogID { get; set; }





		[Column] public DateTime DateRun { get; set; }





		[Column] public string Status { get; set; }





		[Column] public string ErrorMessage { get; set; }



	}

    
	[TableName("ReportRunLog")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class ReportRunLog : sqlserverDB.Record<ReportRunLog>  
    {



		[Column] public int ID { get; set; }





		[Column] public int VoiceSystemID { get; set; }





		[Column] public string ReportName { get; set; }





		[Column] public DateTime DateRun { get; set; }





		[Column] public string Message { get; set; }





		[Column] public int? ReportRunnerID { get; set; }





		[Column] public string Status { get; set; }





		[Column] public string SwitchData { get; set; }





		[Column] public int RunAttempts { get; set; }



	}

    
	[TableName("WatchLog")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class WatchLog : sqlserverDB.Record<WatchLog>  
    {



		[Column] public int ID { get; set; }





		[Column] public DateTime DateCreated { get; set; }





		[Column] public DateTime? DateUpdated { get; set; }





		[Column] public int FailCount { get; set; }





		[Column] public string Message { get; set; }





		[Column] public string FailureType { get; set; }





		[Column] public int RanSinceLastFail { get; set; }



	}

    
	[TableName("ReportRunner")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class ReportRunner : sqlserverDB.Record<ReportRunner>  
    {



		[Column] public int ID { get; set; }





		[Column] public int VoiceSystemID { get; set; }





		[Column] public string ReportName { get; set; }





		[Column] public bool Enabled { get; set; }





		[Column] public string RunTime { get; set; }





		[Column] public bool Running { get; set; }





		[Column] public int? ReportCommandID { get; set; }





		[Column] public string StartText { get; set; }





		[Column] public string EndText { get; set; }



	}

    
	[TableName("ActivityLogDetail")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class ActivityLogDetail : sqlserverDB.Record<ActivityLogDetail>  
    {



		[Column] public int ID { get; set; }





		[Column] public int ActivityLogID { get; set; }





		[Column] public string OldValue { get; set; }





		[Column] public string NewValue { get; set; }





		[Column] public string FieldName { get; set; }



	}

    
	[TableName("VoiceSystemSession")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class VoiceSystemSession : sqlserverDB.Record<VoiceSystemSession>  
    {



		[Column] public int ID { get; set; }





		[Column] public int VoiceSystemID { get; set; }





		[Column] public DateTime DateRun { get; set; }





		[Column] public string Data { get; set; }



	}

    
	[TableName("ActivityLog")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class ActivityLog : sqlserverDB.Record<ActivityLog>  
    {



		[Column] public int ID { get; set; }





		[Column] public int RecordID { get; set; }





		[Column] public string RecordName { get; set; }





		[Column] public string ChangeType { get; set; }





		[Column] public DateTime ChangeDate { get; set; }





		[Column] public string UserName { get; set; }





		[Column] public string RecordType { get; set; }



	}

    
	[TableName("SystemLog")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class SystemLog : sqlserverDB.Record<SystemLog>  
    {



		[Column] public int ID { get; set; }





		[Column] public DateTime DateCreated { get; set; }





		[Column] public string Message { get; set; }





		[Column] public string Severity { get; set; }



	}

    
	[TableName("TrapMonitor")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class TrapMonitor : sqlserverDB.Record<TrapMonitor>  
    {



		[Column] public int ID { get; set; }





		[Column] public int ElementID { get; set; }





		[Column] public string Name { get; set; }





		[Column] public string Oid { get; set; }





		[Column] public int EscalationProfileID { get; set; }





		[Column] public string Message { get; set; }





		[Column] public string Value { get; set; }





		[Column] public string ClearAlarmKey { get; set; }





		[Column] public string ClearAlarmKeyValue { get; set; }



	}

    
	[TableName("Version")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class Version : sqlserverDB.Record<Version>  
    {



		[Column] public int ID { get; set; }





		[Column] public string CurrentVersion { get; set; }





		[Column] public bool DefaultsLoaded { get; set; }





		[Column] public DateTime DateDefaultsLoaded { get; set; }



	}

    
	[TableName("ServiceCommand")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class ServiceCommand : sqlserverDB.Record<ServiceCommand>  
    {



		[Column] public int ID { get; set; }





		[Column] public string Name { get; set; }





		[Column] public string Command { get; set; }



	}

    
	[TableName("CS2100RawAlarms")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class CS2100RawAlarm : sqlserverDB.Record<CS2100RawAlarm>  
    {



		[Column] public int ID { get; set; }





		[Column] public string AlarmData { get; set; }





		[Column] public int ElementID { get; set; }





		[Column] public DateTime DateAdded { get; set; }



	}

    
	[TableName("Watcher")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class Watcher : sqlserverDB.Record<Watcher>  
    {



		[Column] public int ID { get; set; }





		[Column] public string Address { get; set; }





		[Column] public int Port { get; set; }





		[Column] public int Interval { get; set; }





		[Column] public int FailedIntervalCount { get; set; }





		[Column] public string Username { get; set; }





		[Column] public string Password { get; set; }





		[Column] public bool ConnectAndLogin { get; set; }





		[Column] public string Type { get; set; }





		[Column] public int? WatchLogID { get; set; }





		[Column] public int EscalationProfileID { get; set; }





		[Column] public string Message { get; set; }





		[Column] public bool Enabled { get; set; }



	}

    
	[TableName("CairsCallRecords")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class CairsCallRecord : sqlserverDB.Record<CairsCallRecord>  
    {



		[Column] public int ID { get; set; }





		[Column] public Guid? SwitchID { get; set; }





		[Column] public int Calls { get; set; }





		[Column] public int Seconds { get; set; }





		[Column] public string Trunk { get; set; }





		[Column] public int Hour { get; set; }





		[Column] public int Month { get; set; }





		[Column] public int Day { get; set; }





		[Column] public int Year { get; set; }



	}

    
	[TableName("Trap")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class Trap : sqlserverDB.Record<Trap>  
    {



		[Column] public int ID { get; set; }





		[Column] public int ElementID { get; set; }





		[Column] public DateTime DateReceived { get; set; }





		[Column] public string SNMPVersion { get; set; }





		[Column] public string OriginIP { get; set; }





		[Column] public string DestinationIP { get; set; }





		[Column] public string Community { get; set; }





		[Column] public string Message { get; set; }





		[Column] public string Enterprise { get; set; }





		[Column] public string User { get; set; }





		[Column] public string Specific { get; set; }



	}

    
	[TableName("Element")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class Element : sqlserverDB.Record<Element>  
    {



		[Column] public int ID { get; set; }





		[Column] public string Name { get; set; }





		[Column] public string IpAddress { get; set; }





		[Column] public int Port { get; set; }





		[Column] public string CommunityName { get; set; }





		[Column] public string UserName { get; set; }





		[Column] public string AuthProtocol { get; set; }





		[Column] public string AuthPassword { get; set; }





		[Column] public string PrivacyProtocol { get; set; }





		[Column] public string PrivacyPassword { get; set; }





		[Column] public string Version { get; set; }





		[Column] public int? SNMPSendTimeout { get; set; }





		[Column] public int? SNMPReceiveTimeout { get; set; }





		[Column] public string Type { get; set; }





		[Column] public DateTime? PropertyDate { get; set; }





		[Column] public int Xpos { get; set; }





		[Column] public int Ypos { get; set; }





		[Column] public string CollectorIP { get; set; }





		[Column] public int CollectorPort { get; set; }





		[Column] public string FilePath { get; set; }





		[Column] public string FTPHost { get; set; }





		[Column] public string FTPUsername { get; set; }





		[Column] public string FTPPassword { get; set; }





		[Column] public string FTPRemoteDirectory { get; set; }





		[Column] public string FTPFileNameMatch { get; set; }



	}

    
	[TableName("VoiceSystem")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class VoiceSystem : sqlserverDB.Record<VoiceSystem>  
    {



		[Column] public int ID { get; set; }





		[Column] public string Name { get; set; }





		[Column] public string SwitchType { get; set; }





		[Column] public string SwitchHost { get; set; }





		[Column] public int SwitchPort { get; set; }





		[Column] public string SwitchUsername { get; set; }





		[Column] public string SwitchPassword { get; set; }





		[Column] public string SwitchConnectionType { get; set; }





		[Column] public string TelebossHost { get; set; }





		[Column] public string TelebossUsername { get; set; }





		[Column] public string TelebossPassword { get; set; }





		[Column] public int TelebossPort { get; set; }



	}

    
	[TableName("sysdiagrams")]


	[PrimaryKey("diagram_id")]



	[ExplicitColumns]
    public partial class sysdiagram : sqlserverDB.Record<sysdiagram>  
    {



		[Column] public string name { get; set; }





		[Column] public int principal_id { get; set; }





		[Column] public int diagram_id { get; set; }





		[Column] public int? version { get; set; }





		[Column] public byte[] definition { get; set; }



	}

    
	[TableName("AlarmLog")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class AlarmLog : sqlserverDB.Record<AlarmLog>  
    {



		[Column] public int ID { get; set; }





		[Column] public int AlarmID { get; set; }





		[Column] public DateTime DateSent { get; set; }





		[Column] public string Details { get; set; }





		[Column] public string SentTo { get; set; }





		[Column] public string Type { get; set; }





		[Column] public int EscalationActionID { get; set; }





		[Column] public bool? SendSuccess { get; set; }





		[Column] public string SendMessage { get; set; }



	}

    
	[TableName("ElementCollectionLog")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class ElementCollectionLog : sqlserverDB.Record<ElementCollectionLog>  
    {



		[Column] public int ID { get; set; }





		[Column] public int ElementID { get; set; }





		[Column] public DateTime DateAdded { get; set; }





		[Column] public string Data { get; set; }



	}

    
	[TableName("SystemSetting")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class SystemSetting : sqlserverDB.Record<SystemSetting>  
    {



		[Column] public int ID { get; set; }





		[Column] public string Name { get; set; }





		[Column] public string Value { get; set; }



	}

    
	[TableName("UpdateSetting")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class UpdateSetting : sqlserverDB.Record<UpdateSetting>  
    {



		[Column] public int ID { get; set; }





		[Column] public DateTime DateCreated { get; set; }





		[Column] public string Version { get; set; }





		[Column] public string FileName { get; set; }





		[Column] public byte[] File { get; set; }



	}

    
	[TableName("SchemaChange")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class SchemaChange : sqlserverDB.Record<SchemaChange>  
    {



		[Column] public int ID { get; set; }





		[Column] public double DatabaseVersion { get; set; }





		[Column] public string ScriptName { get; set; }





		[Column] public string Notes { get; set; }





		[Column] public DateTime DateApplied { get; set; }



	}

    
	[TableName("Alarm")]


	[PrimaryKey("ID")]



	[ExplicitColumns]
    public partial class Alarm : sqlserverDB.Record<Alarm>  
    {



		[Column] public int ID { get; set; }





		[Column] public int EscalationProfileID { get; set; }





		[Column] public string AcknowledgedBy { get; set; }





		[Column] public DateTime DateAdded { get; set; }





		[Column] public DateTime? DateAcknowledged { get; set; }





		[Column] public bool Acknowledged { get; set; }





		[Column] public int? TrapMonitorID { get; set; }





		[Column] public string Message { get; set; }





		[Column] public int? TrapID { get; set; }





		[Column] public int? ElementID { get; set; }





		[Column] public int Count { get; set; }





		[Column] public DateTime DateUpdated { get; set; }





		[Column] public int? WatcherID { get; set; }



	}


}



