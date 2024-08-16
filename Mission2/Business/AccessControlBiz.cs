using Mission2.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mission2.Business
{
    public class AccessControlBiz
    {
        public IDataSource<AccessRecord> DataSource { get; set; }

        public List<AccessRecord> AccessRecordList { get; set; }

        public AccessControlBiz(IDataSource<AccessRecord> dataSource)
        {
            DataSource = dataSource;
            LoadAccessRecord();
        }

        public List<AccessRecord> GetAccessRecord(DateTime fromDate, DateTime toDate)
        {
            // Menggunakan LINQ untuk memfilter AccessRecordList
            return AccessRecordList
                .Where(record => record.RecordDate >= fromDate && record.RecordDate < toDate)
                .ToList();
        }

        public List<AccessRecord> GetAccessRecord(string cardId, DateTime fromDate, DateTime toDate)
        {
            // Menggunakan LINQ untuk memfilter AccessRecordList berdasarkan CardId
            return AccessRecordList
                .Where(record => record.CardId == cardId && record.RecordDate >= fromDate && record.RecordDate < toDate)
                .ToList();
        }

        public void AddAccessRecord(AccessRecord record)
        {
            if (record == null)
            {
                throw new ArgumentNullException(nameof(record), "AccessRecord cannot be null");
            }

            AccessRecordList.Add(record);
        }

        public void SaveAccessRecord()
        {
            DataSource.Save(AccessRecordList);
        }

        public void LoadAccessRecord()
        {
            AccessRecordList = DataSource.Load() ?? new List<AccessRecord>();
        }
    }
}
