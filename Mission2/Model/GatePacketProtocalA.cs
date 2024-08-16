using System;

namespace Mission2.Model
{
    public class GatePacketProtocolA : GatePacket
    {
        public override RecordTypeEnum GetAccessType()
        {
            // Mengacu pada struktur paket yang diterapkan pada protokol, dan mendapatkan satu karakter sesuai dengan pintu masuk atau keluar
            // Mengembalikan RecordTypeEnum.Enter jika pintu sama dengan konstanta ENTER
            // Mengembalikan RecordTypeEnum.Leave jika sama dengan konstanta LEAVE
            if (PacketString.Substring(7, 1) == ENTER)
            {
                return RecordTypeEnum.Enter;
            }

            return RecordTypeEnum.Leave;
        }

        public override string GetCardId()
        {
            // Memotong dan mengambil string yang sesuai dengan CardID
            return PacketString.Substring(3, 4);
        }

        public override int GetGateId()
        {
            // Memotong dan mengambil string yang sesuai dengan GateID
            string gateId = PacketString.Substring(1, 2);
            return int.Parse(gateId);
        }

        public override DateTime GetRecordDate()
        {
            // Memotong string yang sesuai dengan tanggal catatan, mengonversinya menjadi DateTime
            string recordDate = PacketString.Substring(8);
            return DateTime.Parse(recordDate);
        }
    }
}
