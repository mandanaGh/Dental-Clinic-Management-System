using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    using BusinessObjectLayer;

    public class CostReportDAL
    {
        private static string select = "SELECT dbo.GetServiceTypeCOUNT(SERVICETYPEID,@InsuranceTypeId,@DoctorId,@FromDate,@ToDate) AS COUNT, PRICE, SERVICETYPETITLE, SERVICETYPEID, SERVICETYPECODE FROM SERVICETYPE";
        private static string selectPatient = "SELECT ISNULL(SUM(Price), 0) AS Price, ISNULL(SUM(COUNT), 0) AS COUNT, N'ویزیت' AS SERVICETYPETITLE FROM (SELECT SERVICETYPE.PRICE * COUNT(SERVICE.PATIENTID) AS Price, COUNT(SERVICE.PATIENTID) AS COUNT FROM SERVICETYPE LEFT OUTER JOIN SERVICE ON SERVICETYPE.SERVICETYPEID = SERVICE.SERVICETYPEID WHERE (SERVICETYPE.SERVICETYPEID = 1) AND (SERVICE.PATIENTID IN (SELECT PATIENTID FROM PATIENT WHERE (PATIENTID = SERVICE.PATIENTID) AND (ISNORMAL = @ISNORMAL) AND (INSURANCETYPEID = @INSURANCETYPEID))) AND (SERVICE.DATE >= @FROMDATE) AND (SERVICE.DATE <= @TODATE) GROUP BY SERVICETYPE.SERVICETYPEID, SERVICETYPE.PRICE) AS VISITSERVICE_SERVICETYPE UNION SELECT ISNULL(SUM(Price), 0) AS Price, ISNULL(SUM(COUNT), 0) AS COUNT, N'خدمات سرپایی' AS SERVICETYPETITLE FROM         (SELECT     SERVICETYPE_1.PRICE * COUNT(SERVICE_1.PATIENTID) AS Price, COUNT(SERVICE_1.PATIENTID) AS COUNT FROM SERVICETYPE AS SERVICETYPE_1 LEFT OUTER JOIN SERVICE AS SERVICE_1 ON SERVICETYPE_1.SERVICETYPEID = SERVICE_1.SERVICETYPEID WHERE (SERVICETYPE_1.SERVICETYPEID <> 1) AND (SERVICE_1.PATIENTID IN (SELECT PATIENTID FROM PATIENT AS PATIENT_1 WHERE (PATIENTID = SERVICE_1.PATIENTID) AND (ISNORMAL = @ISNORMAL) AND (INSURANCETYPEID = @INSURANCETYPEID))) AND (SERVICE_1.DATE >= @FROMDATE) AND (SERVICE_1.DATE <= @TODATE) GROUP BY SERVICETYPE_1.SERVICETYPEID, SERVICETYPE_1.PRICE) AS OTHERSERVICE_SERVICETYPE";
        private static SqlCommand sqlCommand;

        public static List<CostReportItemsBOL> Select(CostReportFilterBOL _CostReportFilterBOL)
        {
            DataTable table = ExecuteReader(_CostReportFilterBOL);
            List<CostReportItemsBOL> result = new List<CostReportItemsBOL>();
            foreach (DataRow row in table.Rows)
            {
                short ServiceTypeId = Convert.ToInt16(row["SERVICETYPEID"]);
                string ServiceTypeTitle = Convert.ToString(row["SERVICETYPETITLE"]);
                string ServiceTypeCode = Convert.ToString(row["SERVICETYPECODE"]);
                long Price = Convert.ToInt64(row["PRICE"]);
                int Count = Convert.ToInt32(row["COUNT"]);
                result.Add(new CostReportItemsBOL(ServiceTypeId, ServiceTypeTitle, ServiceTypeCode, Price, Count));
            }
            return result;
        }
        public static List<CostReportPatientBOL> SelectPatient(CostReportFilterBOL _CostReportFilterBOL, bool IsNormal)
        {
            DataTable table = ExecuteReader(_CostReportFilterBOL,IsNormal);
            List<CostReportPatientBOL> result = new List<CostReportPatientBOL>();
            foreach (DataRow row in table.Rows)
            {                
                string ServiceTypeTitle = Convert.ToString(row["SERVICETYPETITLE"]);                                
                long Price = Convert.ToInt64(row["PRICE"]);
                int Count = Convert.ToInt32(row["COUNT"]);
                result.Add(new CostReportPatientBOL(ServiceTypeTitle, Price, Count));
            }
            return result;
        }
        private static DataTable ExecuteReader(CostReportFilterBOL _CostReportFilterBOL)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = select;
            sqlCommand.Parameters.Add("@InsuranceTypeId", SqlDbType.TinyInt).Value = ValidateParameter("@InsuranceTypeId", _CostReportFilterBOL.InsuranceTypeId, false);
            sqlCommand.Parameters.Add("@DoctorId", SqlDbType.TinyInt).Value = ValidateParameter("@DoctorId", _CostReportFilterBOL.DoctorID, false);
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = ValidateParameter("@FromDate", _CostReportFilterBOL.FromDate, false);
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = ValidateParameter("@ToDate", _CostReportFilterBOL.ToDate, false);
            ConnectionDAL _ConnectionDAL = new ConnectionDAL();
            sqlCommand.Connection = _ConnectionDAL.OpenConnection();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlCommand.ExecuteReader());
            _ConnectionDAL.CloseConnection();
            return dataTable;
        }
        private static DataTable ExecuteReader(CostReportFilterBOL _CostReportFilterBOL, bool IsNormal)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = selectPatient;
            sqlCommand.Parameters.Add("@InsuranceTypeId", SqlDbType.TinyInt).Value = ValidateParameter("@InsuranceTypeId", _CostReportFilterBOL.InsuranceTypeId, false);
            sqlCommand.Parameters.Add("@DoctorId", SqlDbType.TinyInt).Value = ValidateParameter("@DoctorId", _CostReportFilterBOL.DoctorID, false);
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = ValidateParameter("@FromDate", _CostReportFilterBOL.FromDate, false);
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = ValidateParameter("@ToDate", _CostReportFilterBOL.ToDate, false);
            sqlCommand.Parameters.Add("@IsNormal", SqlDbType.TinyInt).Value = ValidateParameter("@IsNormal", _CostReportFilterBOL.IsNormal, false);
            ConnectionDAL _ConnectionDAL = new ConnectionDAL();
            sqlCommand.Connection = _ConnectionDAL.OpenConnection();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlCommand.ExecuteReader());
            _ConnectionDAL.CloseConnection();
            return dataTable;
        }
        private static object ValidateParameter(string ParameterName, object Value, bool IsNullable)
        {
            if (Value == null && !IsNullable)
                throw new ArgumentNullException(ParameterName);
            return (Value == null ? DBNull.Value : Value);
        }
    }
}