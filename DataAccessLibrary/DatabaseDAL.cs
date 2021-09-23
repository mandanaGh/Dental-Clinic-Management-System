using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using DataAccessLayer;

namespace DataAccessLibrary
{
    public class DatabaseDAL : System.ComponentModel.Component
    {
        private static Server _Server;
        public bool BackUp(string Path, string Name)
        {
            string _ConnectionString = new ConnectionDAL().GetConnectionString();
            SqlConnection _SqlConnection = new SqlConnection(_ConnectionString);
            _SqlConnection.Open();
            ServerConnection _ServerConnection = new ServerConnection(_SqlConnection);
            _Server = new Server(_ServerConnection);
            if (_Server != null)
                return BackupDataBase(Path, Name);
            else
                return false;
        }
        private bool BackupDataBase(string Path, string Name)
        {
            string databaseName = string.Format("{0}Clinic.mdf", ServerDAL.GetServerPath());
            string databasePath = string.Format("{0}\\{1}{2}", Path, Name, ".bak");
            Backup _Backup = new Backup();
            _Backup.Action = BackupActionType.Database;
            _Backup.BackupSetDescription = databaseName;
            _Backup.BackupSetName = databaseName;
            _Backup.Database = databaseName;
            BackupDeviceItem deviceItem = new BackupDeviceItem(databasePath, DeviceType.File);
            _Backup.Initialize = true;
            _Backup.Checksum = true;
            _Backup.ContinueAfterError = true;
            _Backup.Devices.Add(deviceItem);
            _Backup.Incremental = false;
            _Backup.LogTruncation = BackupTruncateLogType.Truncate;
            _Backup.FormatMedia = false;
            _Backup.SqlBackup(_Server);
            _Server.Refresh();
            return true;
        }
        public bool RestoreBackUp(string Path, string Name)
        {
            string _ConnectionString = new ConnectionDAL().GetConnectionString();
            SqlConnection _SqlConnection = new SqlConnection(_ConnectionString);
            _SqlConnection.Open();
            _SqlConnection.ChangeDatabase("master");
            ServerConnection _ServerConnection = new ServerConnection(_SqlConnection);
            _Server = new Server(_ServerConnection);
            if (_Server != null)
            {
                string databaseName = string.Format("{0}Clinic.mdf", ServerDAL.GetServerPath());
                string backUpPath = string.Format("{0}\\{1}{2}", Path, Name, ".bak");
                BackupDeviceItem _BackupDeviceItem = new BackupDeviceItem(backUpPath, DeviceType.File);
                Restore _Restore = new Restore();
                _Restore.PercentCompleteNotification = 1;
                _Restore.Devices.Add(_BackupDeviceItem);
                _Restore.NoRecovery = false;
                _Restore.ReplaceDatabase = true;
                _Restore.Database = databaseName;
                _Restore.Action = RestoreActionType.Database;
                _Restore.SqlRestore(_Server);
                 return true;
            }
            else
                return false;
        }
    }
}