using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class Record
    {
        public string RecordID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string RecordType { get; set; }
        public string ProcessStatus { get; set; }
        public string ManagerID { get; set; }

        // Methods
        private string GenerateNewID()
        {
            return "HS" + DateTime.Now.Ticks.ToString();
        }
        public Record(string id, DateTime created, DateTime update, string recordType, string status, string managerID)
        {
            RecordID = GenerateNewID();
            RecordType = recordType;
            ManagerID = managerID;
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ProcessStatus = "Mới tạo";
        }
        public static Record GetRecord(string recordID)
        {
            Record hs = new Record("Giả lập", new DateTime(2025, 11, 14, 19, 30, 0), new DateTime(2025, 11, 14, 19, 30, 0), "Nhân sự", "Mới tạo", "admin");
            hs.RecordID = recordID;
            hs.CreateDate = DateTime.Now.AddDays(-3);
            hs.LastUpdateDate = DateTime.Now.AddDays(-1);
            hs.ProcessStatus = "Đang xử lý";
            return hs;
        }
        public static List<Record> GetRecords()
        {
            List<Record> records = new List<Record>();
            records.Add(new Record("HS0001", new DateTime(2025, 11, 14, 19, 30, 0), new DateTime(2025, 11, 14, 19, 30, 0), "Nhân sự", "Mới tạo", "NV0001"));
            records.Add(new Record("HS0002", new DateTime(2025, 11, 14, 19, 30, 0), new DateTime(2025, 11, 14, 19, 35, 11), "Nhân sự", "Mới tạo", "NV0001"));
            records.Add(new Record("HS0003", new DateTime(2025, 11, 14, 19, 30, 0), new DateTime(2025, 11, 14, 19, 40, 22), "Nhân sự", "Mới tạo", "NV0001"));
            records.Add(new Record("HS0004", new DateTime(2025, 11, 14, 19, 30, 0), new DateTime(2025, 11, 14, 19, 50, 33), "Nhân sự", "Mới tạo", "NV0001"));
            return records;
        }
        public void RefreshInfo(string newStatus = null, string newManager = null)
        {
            if (newStatus != null)
                ProcessStatus = newStatus;

            if (newManager != null)
                ManagerID = newManager;

            LastUpdateDate = DateTime.Now;
        }
        public void UpdateStatus(string status)
        {
            this.ProcessStatus = status;
            this.LastUpdateDate = DateTime.Now;
        }
        public void Insert()
        {
            // INSERT INTO HoSo (...)
            // giá trị: RecordID, CreateDate, LastUpdateDate, RecordType, ProcessStatus, ManagerID
        }
        public void Delete()
        {
            // DELETE FROM HoSo WHERE RecordID = this.RecordID
        }
        public static List<Record> Search(string keyword)
        {
            List<Record> list = new List<Record>();
            //list.Add(new HoSo("Hồ sơ nhân sự", "NV01"));
            return list;
        }
    }
}


namespace Class2
{
    public class Node
    {
        public int Data;
        public Node LeftNode;
        public Node RightNode;

        public Node(int data)
        {
            Data = data;
            LeftNode = null;
            RightNode = null;
        }
    }
}
